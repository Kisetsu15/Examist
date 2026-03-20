namespace Examist {
    public class LevelOne : ILevel {
        public int Level { get; } = 1;

        public int TimeInMinutes { get; } = 15;

        public Java GetJava() {
            return new Java(Config.Current.GetLevel(Level).Languages.Java);
        }

        public Python GetPython() {
            return new Python(Config.Current.GetLevel(Level).Languages.Python);
        }
    }
}
