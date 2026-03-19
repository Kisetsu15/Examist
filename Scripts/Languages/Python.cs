namespace Examist {
    public class Python : ILanguage {
        public string Question { get; }
        public string BuggedProgram { get; }

        public Python(string question, string buggedProgram) {
            Question = question;
            BuggedProgram = buggedProgram;
        }

        public bool Verify(string program) {
            return true;
        }
    }
}