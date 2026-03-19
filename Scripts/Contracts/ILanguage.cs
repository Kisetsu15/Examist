namespace Examist {
    public interface ILanguage {
        string Question { get; }
        VerificationResult Verify(string program);
        string GetBuggedProgram();
    }
}
