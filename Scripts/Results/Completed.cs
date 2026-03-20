using System.Windows.Forms;

namespace Examist {
    public class Completed : IResult {
        public string Message => "Round Completed";
        public Student Student { get; }
        public string TimeTaken { get; }
        public string ButtonName => "Exit";
        public bool IsPassed => false;

        public Completed(Student student, string time) {
            Student = student;
            TimeTaken = time;
        }

        public void Execute(Form current) {
            Application.Exit();
        }
    }
}