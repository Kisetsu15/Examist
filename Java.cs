namespace Examist {
    public class Java : ILanguage {
        public bool Verify(string program) {
            return program.Contains("boolean");
        }
    }
}