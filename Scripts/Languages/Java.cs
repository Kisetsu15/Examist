namespace Examist {
    public class Java : ILanguage {
        public string Question { get; }
        public string BuggedProgram { get; }

        public Java(string question, string buggedProgram) {
            Question = question;
            BuggedProgram = buggedProgram;
        }

        public bool Verify(string program) {
            return program.Contains("boolean");
        }
    }
}