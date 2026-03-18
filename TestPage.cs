using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Examist {
    public partial class TestPage : Form {
        bool canClose = false;
        Time time = new Time(timeInSeconds: 30);


        public TestPage() {
            InitializeComponent();

            timer.Start();
            timer.Interval = 1000;

            WindowState = FormWindowState.Maximized;
            FormBorderStyle = FormBorderStyle.None;
            TopMost = true;
        }

        private void TestPage_Load(object sender, EventArgs e) {
            submitButton.Enabled = false;

        }

        protected override void OnFormClosing(FormClosingEventArgs e) {
            e.Cancel = !canClose;
        }

        void DisableTaskManager() {
            RegistryKey key = Registry.CurrentUser.CreateSubKey(
                @"Software\Microsoft\Windows\CurrentVersion\Policies\System");

            key.SetValue("DisableTaskMgr", 1);
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

        void EnableTaskManager() {
            RegistryKey key = Registry.CurrentUser.CreateSubKey(
                @"Software\Microsoft\Windows\CurrentVersion\Policies\System");

            key.DeleteValue("DisableTaskMgr", false);
        }

        void SubmitButton_Click(object sender, EventArgs e) {
            CloseApplication($"Test Completed in {time.NowAsString}");
        }

        void VerifyButton_Click(object sender, EventArgs e) {
            string answer = codeBox.Text;

            if (answer.Contains("boolean")) {
                MessageBox.Show("No Errors Exists");
                submitButton.SetActive(true);
            } else {
                MessageBox.Show("Error Exists");
            }
        }

        void Timer_Tick(object sender, EventArgs e) {
            time.Now--;

            timerLabel.Text = $"⏲️:{time.NowAsString}";

            if (time.IsEnded) {
                CloseApplication("Test Time Over!");
            }
        }

        void CloseApplication(string message) {
            timer.Stop();
            MessageBox.Show(message);
            canClose = true;
            Application.Exit();
        }


    }
}