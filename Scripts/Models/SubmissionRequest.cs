using System;

namespace Examist {
    public sealed class SubmissionRequest {
        public string BatchNumber { get; set; }
        public string StudentName { get; set; }
        public int Level { get; set; }
        public string TimeTaken { get; set; }
        public DateTime SubmittedAtUtc { get; set; }

        public static SubmissionRequest Create(Student student, int level, string timeTaken) {
            return new SubmissionRequest {
                BatchNumber = student.BatchNumber,
                StudentName = student.Name,
                Level = level,
                TimeTaken = timeTaken,
                SubmittedAtUtc = DateTime.UtcNow
            };
        }
    }
}
