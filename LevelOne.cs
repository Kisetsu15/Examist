namespace Examist {
    public class LevelOne : ILevel {

        Java java;
        Python python;

        public Java GetJava() {
            return java;
        }

        public Python GetPython() {
            return python;
        }
    }
}