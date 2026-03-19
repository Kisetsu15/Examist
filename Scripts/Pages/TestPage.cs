using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Examist {
    public partial class TestPage : Form {

        private readonly Student student;
        private readonly ILanguage language;
        private readonly Time time;

        private bool canClose = false;

        public TestPage(Student student, Time time, Timer timer, ILanguage lang) {
            InitializeComponent();

            this.time = time;
            this.student = student;

            this.timer = timer;
            studentName.Text = student.Name;
            batchNumber.Text = student.BatchNumber;

            WindowState = FormWindowState.Maximized;
            FormBorderStyle = FormBorderStyle.None;
            TopMost = true;
            this.language = lang;
        }

        private void TestPage_Load(object sender, EventArgs e) {
            proceedButton.Enabled = false;
        }

        protected override void OnFormClosing(FormClosingEventArgs e) {
            e.Cancel = !canClose;
        }

        void KillPrograms() {
            string[] blocked = {
                "chrome",
                "msedge",
                "code",
                "notepad"
            };

            foreach (string name in blocked) {
                foreach (Process p in Process.GetProcessesByName(name)) {
                    try {
                        p.Kill();
                    } catch { }
                }
            }
        }

        void SubmitButton_Click(object sender, EventArgs e) {
            var resultPage = new ResultPage(new Passed(student, time.TimeSpentString));
            this.SwitchForm(resultPage);
        }

        void VerifyButton_Click(object sender, EventArgs e) {
            string answer = codeBox.Text;
            if (language.Verify(answer)) {
                timer.Stop();
                MessageBox.Show("Passed");
            } else {
                MessageBox.Show("Error Exists");
            }
        }

        void TestPageTimer_Tick(object sender, EventArgs e) {
            time.TimeLeft--;

            timerLabel.Text = $"{time.TimeLeftString}";

            if (time.IsEnded) {
                timer.Stop();
                var resultPage = new ResultPage(new Failed(student));
                this.SwitchForm(resultPage);
            }
        }
    }
}