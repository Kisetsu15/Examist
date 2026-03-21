using System.Windows.Forms;

namespace Examist {
    public class Passed : IResult {
        public string Message => "Level Cleared!";
        public Student Student { get; }
        public string TimeTaken { get; }
        public string ButtonName => "Next";
        public bool IsPassed => true;

        public Passed(Student student, string time) {
            Student = student;
            TimeTaken = time;
        }

        public void Execute(Form current, int level) {
            Extensions.SaveResults(Student, TimeTaken, level);

            var nextPage = new LevelSelectionPage(Student, levelTwoUnlocked: true);
            current.SwitchForm(nextPage);
        }
    }
}