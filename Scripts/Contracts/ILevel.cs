namespace Examist {
    public interface ILevel {
        int Level { get; }
        int TimeInMinutes { get; }
        Java GetJava();
        Python GetPython();
    }
}