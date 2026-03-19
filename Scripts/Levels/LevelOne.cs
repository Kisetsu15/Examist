namespace Examist {
    public class LevelOne : ILevel {
        public Java GetJava() {
            return new Java(Config.Current.LevelOne.Java);
        }

        public Python GetPython() {
            return new Python(Config.Current.LevelOne.Python);
        }
    }
}
