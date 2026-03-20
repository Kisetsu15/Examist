using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Examist {
    public partial class TestPage : Form {
        private readonly Student student;
        private readonly ILanguage language;
        private readonly Time time;
        private int statusTime = 5;
        private readonly Form previous;


        public TestPage(Student student, Time time, ILanguage language, Form previous) {
            InitializeComponent();

            this.time = time;
            this.student = student;
            this.previous = previous;
            this.language = language;

            studentName.Text = student.Name;
            batchNumber.Text = student.BatchNumber;
            timerLabel.Text = time.TimeLeftString;
            QuestionLabel.Text = language.Question;

            this.WindowStyle();
        }

        private void TestPage_Load(object sender, EventArgs e) {
            LoadBuggedProgram();
            proceedButton.Enabled = false;
            timer.Start();
            ShowStatus(string.Empty, Color.Black, Color.LightSteelBlue);
        }

        private void ShowStatus(string message, Color foreColor, Color backColor) {
            statusTime = 5;
            statusTimer.Start();
            programStatusLabel.Text = message;
            statusPanel.ForeColor = foreColor;
            statusPanel.BackColor = backColor;
        }

        protected override void OnFormClosing(FormClosingEventArgs e) {
            e.Cancel = false;
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
            if (!proceedButton.Enabled) {
                return;
            }

            IResult result; ;
            result = language.CurrentLevel == 2 ? new Completed(student, time.TimeSpentString) : (IResult) new Passed(student, time.TimeSpentString);

            var resultPage = new ResultPage(result);
            this.SwitchForm(resultPage);
        }

        void VerifyButton_Click(object sender, EventArgs e) {
            string answer = codeBox.Text;
            if (string.IsNullOrWhiteSpace(answer)) {
                ShowStatus("Warning: Please enter your solution before verifying", Color.Black, Color.Orange);
                return;
            }

            VerificationResult verification = language.Verify(answer);

            switch (verification.Status) {
                case VerificationStatus.Success:
                    timer.Stop();

                    proceedButton.Enable();
                    resetButton.Disable();
                    backButton.Disable();
                    verifyButton.Disable();
                    ShowStatus($"Success: {verification.Message}", Color.White, Color.LimeGreen);
                    break;
                case VerificationStatus.Error:
                    proceedButton.Disable();
                    ShowStatus($"Failed: {verification.Message}", Color.White, Color.LightCoral);
                    break;
                case VerificationStatus.Invalid:
                    proceedButton.Disable();
                    ShowStatus($"Warning: {verification.Message}", Color.Black, Color.Orange);
                    break;
            }
        }


        void Timer_Tick(object sender, EventArgs e) {
            time.TimeLeft--;

            timerLabel.Text = time.TimeLeftString;

            if (time.IsEnded) {
                timer.Stop();
                var resultPage = new ResultPage(new Failed(student));
                this.SwitchForm(resultPage);
            }
        }

        private void StatusTimer_Tick(object sender, EventArgs e) {
            if (statusTime > 0) {
                statusTime--;
            } else {
                ShowStatus(string.Empty, Color.Black, Color.LightSteelBlue);
                statusTimer.Stop();
            }
        }

        private void ResetButton_Click(object sender, EventArgs e) {
            LoadBuggedProgram();
        }

        private void BackButton_Click(object sender, EventArgs e) {
            timer.Stop();

            if (previous is ProgramSelectionPage selectionPage) {
                selectionPage.ResumeTimer();
            }

            this.SwitchForm(previous);
        }

        private void LoadBuggedProgram() {
            codeBox.Text = language.GetBuggedProgram();
            ShowStatus(string.Empty, Color.Black, Color.LightSteelBlue);
        }

        #region Aesthetics
        void VerifyButton_Enter(object sender, EventArgs e) {
            verifyButton.ForeColor = Color.White;
        }

        void BackButton_Enter(object sender, EventArgs e) {
            backButton.ForeColor = Color.White;
        }

        void ResetButton_Enter(object sender, EventArgs e) {
            resetButton.ForeColor = Color.White;
        }

        void VerifyButton_Leave(object sender, EventArgs e) {
            verifyButton.ForeColor = Color.LimeGreen;
        }

        void BackButton_Leave(object sender, EventArgs e) {
            backButton.ForeColor = Color.LightCoral;
        }

        void ResetButton_Leave(object sender, EventArgs e) {
            resetButton.ForeColor = Color.SteelBlue;
        }
        #endregion
    }
}
