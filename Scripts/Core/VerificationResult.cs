namespace Examist {
    public sealed class VerificationResult {
        public static VerificationResult Success(string message = null) {
            return new VerificationResult(VerificationStatus.Success, message ?? "Verified successfully.");
        }

        public static VerificationResult Error(string message) {
            return new VerificationResult(VerificationStatus.Error, message);
        }

        public static VerificationResult Invalid(string message) {
            return new VerificationResult(VerificationStatus.Invalid, message);
        }

        public VerificationStatus Status { get; }

        public string Message { get; }

        private VerificationResult(VerificationStatus status, string message) {
            Status = status;
            Message = message;
        }
    }

    public enum VerificationStatus {
        Success,
        Error,
        Invalid,
    }
}
