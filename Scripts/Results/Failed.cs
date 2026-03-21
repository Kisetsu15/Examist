using System;
using System.Windows.Forms;

namespace Examist {
    public class Failed : IResult {
        public string Message => "Thank you for your participation";
        public Student Student { get; }
        public string TimeTaken { get; }
        public string ButtonName => "Exit";
        public bool IsPassed => false;

        public Failed(Student student) {
            Student = student;
            TimeTaken = string.Empty;
        }

        public void Execute(Form current, int level) {
            _ = level;
            current.Close();
            Environment.Exit(0);
        }
    }
}
