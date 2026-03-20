namespace Examist {
    public class LevelTwo : ILevel {
        public int Level { get; } = 2;

        public int TimeInMinutes { get; } = 20;

        public Java GetJava() {
            return new Java(Config.Current.GetLevel(Level).Languages.Java);
        }

        public Python GetPython() {
            return new Python(Config.Current.GetLevel(Level).Languages.Python);
        }
    }
}
