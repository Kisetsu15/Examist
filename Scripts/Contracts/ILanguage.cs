namespace Examist {
    public interface ILanguage {
        int Level { get; }
        string Question { get; }
        VerificationResult Verify(string program);
        string GetBuggedProgram();
    }
}
