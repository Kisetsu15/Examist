namespace Examist {
    public interface ILanguage {
        string Question { get; }
        string BuggedProgram { get; }
        bool Verify(string program);
    }
}