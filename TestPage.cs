using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Examist {
    public partial class TestPage : Form {
        
        readonly Student student;

        bool canClose = false;
        readonly Time time;
        readonly Language language;
        
        public TestPage(Student student, Time time, Timer timer, Language language) {
            InitializeComponent();
            
            this.time = time;
            this.language = language;
            this.student = student;
            
            testPageTimer = timer;
            studentName.Text = student.Name;
            batchNumber.Text = student.BatchNumber;

            WindowState = FormWindowState.Maximized;
            FormBorderStyle = FormBorderStyle.None;
            TopMost = true;
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
            ResultPage resultPage = new ResultPage(student, time.TimeSpentString);
            resultPage.Show();
            Hide();
        }

        void VerifyButton_Click(object sender, EventArgs e)
        {
            string answer = codeBox.Text;
            switch (language)
            {
                case Language.Java:
                    HandleJava(answer);
                    return;
                case Language.Python:
                    HandlePython(answer);
                    return;
            }
        }

        private void HandleJava(string answer)
        {
            if (answer.Contains("boolean"))
            {
                testPageTimer.Stop();
                
                verifyButton.Text = "Verified";
                verifyButton.SetActive(false);
                MessageBox.Show("No Errors Exists");
                
                proceedButton.SetActive(true);
            }
            else
            {
                MessageBox.Show("Error Exists");
            }
        }    
        
        private void HandlePython(string answer)
        {
            if (answer.Contains("boolean"))
            {
                testPageTimer.Stop();
                verifyButton.Text = "Verified";
                verifyButton.SetActive(false);
                MessageBox.Show("No Errors Exists");
                proceedButton.SetActive(true);
            }
            else
            {
                MessageBox.Show("Error Exists");
            }
        }    

        void TestPageTimer_Tick(object sender, EventArgs e) {
            time.TimeLeft--;

            timerLabel.Text = $"⏲️:{time.TimeLeftString}";

            if (time.IsEnded) {
                CloseApplication("Test Time Over!");
            }
        }

        void CloseApplication(string message) {
            testPageTimer.Stop();
            MessageBox.Show(message);
            canClose = true;
            Application.Exit();
        }
    }
}