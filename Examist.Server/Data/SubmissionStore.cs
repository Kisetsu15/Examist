using System.Globalization;
using System.Text.Json;

namespace Examist.Server.Data {
    public sealed class SubmissionStore {
        private readonly object gate = new object();
        private readonly string storagePath;
        private readonly JsonSerializerOptions jsonOptions = new JsonSerializerOptions {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            WriteIndented = true
        };

        public SubmissionStore(IHostEnvironment environment) {
            string dataDirectory = Path.Combine(environment.ContentRootPath, "App_Data");
            Directory.CreateDirectory(dataDirectory);
            storagePath = Path.Combine(dataDirectory, "submissions.json");
        }

        public IReadOnlyList<SubmissionRecord> GetLeaderboard() {
            lock (gate) {
                return SortAndRank(LoadUnsafe());
            }
        }

        public IReadOnlyList<SubmissionRecord> Add(SubmissionRequest request) {
            lock (gate) {
                List<SubmissionRecord> records = LoadUnsafe();
                records.Add(new SubmissionRecord {
                    BatchNumber = request.BatchNumber.Trim(),
                    StudentName = request.StudentName.Trim(),
                    Level = request.Level,
                    TimeTaken = request.TimeTaken.Trim(),
                    SubmittedAtUtc = request.SubmittedAtUtc
                });

                SaveUnsafe(records);
                return SortAndRank(records);
            }
        }

        private List<SubmissionRecord> LoadUnsafe() {
            if (!File.Exists(storagePath)) {
                return new List<SubmissionRecord>();
            }

            string json = File.ReadAllText(storagePath);
            return JsonSerializer.Deserialize<List<SubmissionRecord>>(json, jsonOptions) ?? new List<SubmissionRecord>();
        }

        private void SaveUnsafe(List<SubmissionRecord> records) {
            string json = JsonSerializer.Serialize(records, jsonOptions);
            File.WriteAllText(storagePath, json);
        }

        private static List<SubmissionRecord> SortAndRank(IEnumerable<SubmissionRecord> records) {
            List<SubmissionRecord> sorted = records
                .OrderBy(record => record.SubmittedAtUtc)
                .ThenBy(record => ParseTime(record.TimeTaken))
                .ThenBy(record => record.BatchNumber, StringComparer.OrdinalIgnoreCase)
                .Select((record, index) => new SubmissionRecord {
                    Rank = index + 1,
                    BatchNumber = record.BatchNumber,
                    StudentName = record.StudentName,
                    Level = record.Level,
                    TimeTaken = record.TimeTaken,
                    SubmittedAtUtc = record.SubmittedAtUtc
                })
                .ToList();

            return sorted;
        }

        private static TimeSpan ParseTime(string value) {
            if (TimeSpan.TryParseExact(value, @"mm\:ss", CultureInfo.InvariantCulture, out TimeSpan parsed)) {
                return parsed;
            }

            return TimeSpan.MaxValue;
        }
    }
}
