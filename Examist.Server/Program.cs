using System.Text.Json;
using Examist.Server.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.ConfigureHttpJsonOptions(options => {
    options.SerializerOptions.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
    options.SerializerOptions.WriteIndented = true;
});
builder.Services.AddSingleton<SubmissionStore>();

var app = builder.Build();

app.MapGet("/api/submissions", (SubmissionStore store) => Results.Ok(store.GetLeaderboard()));

app.MapPost("/api/submissions", (SubmissionRequest request, SubmissionStore store) => {
    if (string.IsNullOrWhiteSpace(request.BatchNumber) ||
        string.IsNullOrWhiteSpace(request.StudentName) ||
        string.IsNullOrWhiteSpace(request.TimeTaken) ||
        request.Level <= 0) {
        return Results.BadRequest(new { message = "Batch number, student name, level, and time taken are required." });
    }

    if (request.SubmittedAtUtc == default) {
        request.SubmittedAtUtc = DateTime.UtcNow;
    }

    var leaderboard = store.Add(request);
    return Results.Ok(leaderboard);
});

app.Run();

namespace Examist.Server.Data {
    public sealed class SubmissionRequest {
        public string BatchNumber { get; set; }
        public string StudentName { get; set; }
        public int Level { get; set; }
        public string TimeTaken { get; set; }
        public DateTime SubmittedAtUtc { get; set; }
    }

    public sealed class SubmissionRecord {
        public int Rank { get; set; }
        public string BatchNumber { get; set; }
        public string StudentName { get; set; }
        public int Level { get; set; }
        public string TimeTaken { get; set; }
        public DateTime SubmittedAtUtc { get; set; }
    }
}
