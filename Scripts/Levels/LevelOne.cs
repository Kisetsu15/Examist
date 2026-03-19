namespace Examist {
    public class LevelOne : ILevel {

        const string JAVA_QUESTION = "Debug the Java program";
        const string JAVA_PROGRAM = "java_program_1.txt";

        const string PYTHON_QUESTION = "Debug the python program";
        const string PYTHON_PROGRAM = "python_program_1.txt";

        public Java GetJava() {
            return new Java(JAVA_QUESTION, JAVA_PROGRAM);
        }

        public Python GetPython() {
            return new Python(PYTHON_QUESTION, PYTHON_PROGRAM);
        }
    }
}