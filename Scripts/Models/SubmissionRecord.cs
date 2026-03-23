using System;

namespace Examist {
    public sealed class SubmissionRecord {
        public int Rank { get; set; }
        public string BatchNumber { get; set; }
        public string StudentName { get; set; }
        public int Level { get; set; }
        public string TimeTaken { get; set; }
        public DateTime SubmittedAtUtc { get; set; }
    }
}
