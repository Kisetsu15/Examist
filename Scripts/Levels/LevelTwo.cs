namespace Examist {
    public class LevelTwo : ILevel {
        public Java GetJava() {
            return new Java(Config.Current.LevelTwo.Java);
        }

        public Python GetPython() {
            return new Python(Config.Current.LevelTwo.Python);
        }
    }
}
