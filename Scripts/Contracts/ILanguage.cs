namespace Examist {
    public interface ILanguage {
        int CurrentLevel { get; }
        string Question { get; }
        VerificationResult Verify(string program);
        string GetBuggedProgram();
    }
}
