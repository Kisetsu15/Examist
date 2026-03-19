using System.Windows.Forms;

namespace Examist {
    public interface IResult {
        string ButtonName { get; }
        Student Student { get; }
        string Message { get; }
        string TimeTaken { get; }
        bool IsPassed { get; }
        void Execute(Form current);
    }
}