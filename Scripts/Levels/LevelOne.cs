namespace Examist {
    public class LevelOne : ILevel {
        public int Level { get; } = 1;

        public int TimeInMinutes { get; }

        public LevelOne() {
            TimeInMinutes = Config.Current.GetLevel(Level).TimeInMinutes;
        }

        public Java GetJava() {
            return new Java(Config.Current.GetLevel(Level).Languages.Java);
        }

        public Python GetPython() {
            return new Python(Config.Current.GetLevel(Level).Languages.Python);
        }
    }
}
