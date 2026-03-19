using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Examist {
    public partial class ProgramSelectionPage : Form {
        private const int ONE_SECOND = 1000;
        private readonly Time time = new Time(timeInSeconds: 30);
        private readonly Student student;
        private readonly ILevel level;

        private Panel javaPanel;
        private Label javaLabel;
        private Panel pythonPanel;
        private Label pythonLabel;
        private Button pythonOpenButton;
        private Button javaOpenButton;
        private Timer timer;
        private IContainer components;
        private Panel footer;
        private Label batchNumber;
        private Label timerLabel;
        private Label studentName;
        private Panel header;
        private Label copyRightLabel;


        public ProgramSelectionPage(Student student, ILevel level) {
            InitializeComponent();

            this.student = student;
            this.level = level;

            timer.Interval = ONE_SECOND;
            timerLabel.Text = time.TimeLeftString;
            timer.Start();

            studentName.Text = student.Name;
            batchNumber.Text = student.BatchNumber;

            WindowState = FormWindowState.Maximized;
            FormBorderStyle = FormBorderStyle.None;
            TopMost = true;
        }


        #region Generated
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.javaPanel = new System.Windows.Forms.Panel();
            this.javaLabel = new System.Windows.Forms.Label();
            this.javaOpenButton = new System.Windows.Forms.Button();
            this.pythonPanel = new System.Windows.Forms.Panel();
            this.pythonLabel = new System.Windows.Forms.Label();
            this.pythonOpenButton = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.footer = new System.Windows.Forms.Panel();
            this.copyRightLabel = new System.Windows.Forms.Label();
            this.batchNumber = new System.Windows.Forms.Label();
            this.timerLabel = new System.Windows.Forms.Label();
            this.studentName = new System.Windows.Forms.Label();
            this.header = new System.Windows.Forms.Panel();
            this.javaPanel.SuspendLayout();
            this.pythonPanel.SuspendLayout();
            this.footer.SuspendLayout();
            this.header.SuspendLayout();
            this.SuspendLayout();
            // 
            // javaPanel
            // 
            this.javaPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.javaPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.javaPanel.Controls.Add(this.javaLabel);
            this.javaPanel.Controls.Add(this.javaOpenButton);
            this.javaPanel.Location = new System.Drawing.Point(174, 167);
            this.javaPanel.Name = "javaPanel";
            this.javaPanel.Size = new System.Drawing.Size(614, 74);
            this.javaPanel.TabIndex = 0;
            // 
            // javaLabel
            // 
            this.javaLabel.AutoSize = true;
            this.javaLabel.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte) 0);
            this.javaLabel.Location = new System.Drawing.Point(25, 22);
            this.javaLabel.Name = "javaLabel";
            this.javaLabel.Size = new System.Drawing.Size(147, 29);
            this.javaLabel.TabIndex = 2;
            this.javaLabel.Text = "Java Program";
            // 
            // javaOpenButton
            // 
            this.javaOpenButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.javaOpenButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte) 0);
            this.javaOpenButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.javaOpenButton.Location = new System.Drawing.Point(494, 20);
            this.javaOpenButton.Name = "javaOpenButton";
            this.javaOpenButton.Size = new System.Drawing.Size(103, 34);
            this.javaOpenButton.TabIndex = 1;
            this.javaOpenButton.Text = "Open";
            this.javaOpenButton.UseVisualStyleBackColor = false;
            this.javaOpenButton.Click += new System.EventHandler(this.JavaStartButton_Click);
            // 
            // pythonPanel
            // 
            this.pythonPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pythonPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pythonPanel.Controls.Add(this.pythonLabel);
            this.pythonPanel.Controls.Add(this.pythonOpenButton);
            this.pythonPanel.Location = new System.Drawing.Point(174, 256);
            this.pythonPanel.Name = "pythonPanel";
            this.pythonPanel.Size = new System.Drawing.Size(614, 74);
            this.pythonPanel.TabIndex = 3;
            // 
            // pythonLabel
            // 
            this.pythonLabel.AutoSize = true;
            this.pythonLabel.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte) 0);
            this.pythonLabel.Location = new System.Drawing.Point(25, 22);
            this.pythonLabel.Name = "pythonLabel";
            this.pythonLabel.Size = new System.Drawing.Size(175, 29);
            this.pythonLabel.TabIndex = 2;
            this.pythonLabel.Text = "Python Program";
            // 
            // pythonOpenButton
            // 
            this.pythonOpenButton.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.pythonOpenButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte) 0);
            this.pythonOpenButton.Location = new System.Drawing.Point(494, 20);
            this.pythonOpenButton.Name = "pythonOpenButton";
            this.pythonOpenButton.Size = new System.Drawing.Size(103, 34);
            this.pythonOpenButton.TabIndex = 1;
            this.pythonOpenButton.Text = "Open";
            this.pythonOpenButton.UseVisualStyleBackColor = true;
            this.pythonOpenButton.Click += new System.EventHandler(this.PythonStartButton_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.SelectionPageTimer_Tick);
            // 
            // footer
            // 
            this.footer.BackColor = System.Drawing.SystemColors.Highlight;
            this.footer.Controls.Add(this.copyRightLabel);
            this.footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footer.Location = new System.Drawing.Point(0, 452);
            this.footer.Name = "footer";
            this.footer.Size = new System.Drawing.Size(944, 49);
            this.footer.TabIndex = 8;
            // 
            // copyRightLabel
            // 
            this.copyRightLabel.Anchor = (System.Windows.Forms.AnchorStyles) (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
            this.copyRightLabel.AutoSize = true;
            this.copyRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte) 0);
            this.copyRightLabel.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.copyRightLabel.Location = new System.Drawing.Point(758, 24);
            this.copyRightLabel.Name = "copyRightLabel";
            this.copyRightLabel.Size = new System.Drawing.Size(174, 16);
            this.copyRightLabel.TabIndex = 0;
            this.copyRightLabel.Text = "Copyright © 2026 Dharshik S";
            // 
            // batchNumber
            // 
            this.batchNumber.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.batchNumber.AutoSize = true;
            this.batchNumber.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte) 0);
            this.batchNumber.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.batchNumber.Location = new System.Drawing.Point(12, 14);
            this.batchNumber.Name = "batchNumber";
            this.batchNumber.Size = new System.Drawing.Size(80, 26);
            this.batchNumber.TabIndex = 6;
            this.batchNumber.Text = "2612XX";
            // 
            // timerLabel
            // 
            this.timerLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.timerLabel.AutoSize = true;
            this.timerLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte) 0);
            this.timerLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.timerLabel.Location = new System.Drawing.Point(857, 14);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(62, 26);
            this.timerLabel.TabIndex = 4;
            this.timerLabel.Text = "30:00";
            // 
            // studentName
            // 
            this.studentName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.studentName.AutoSize = true;
            this.studentName.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte) 0);
            this.studentName.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.studentName.Location = new System.Drawing.Point(106, 14);
            this.studentName.Name = "studentName";
            this.studentName.Size = new System.Drawing.Size(162, 26);
            this.studentName.TabIndex = 5;
            this.studentName.Text = "<Student_Name>";
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.SystemColors.Highlight;
            this.header.Controls.Add(this.studentName);
            this.header.Controls.Add(this.timerLabel);
            this.header.Controls.Add(this.batchNumber);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(944, 56);
            this.header.TabIndex = 7;
            // 
            // ProgramSelectionPage
            // 
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(944, 501);
            this.Controls.Add(this.footer);
            this.Controls.Add(this.header);
            this.Controls.Add(this.pythonPanel);
            this.Controls.Add(this.javaPanel);
            this.Name = "ProgramSelectionPage";
            this.Text = "Eaxmist";
            this.javaPanel.ResumeLayout(false);
            this.javaPanel.PerformLayout();
            this.pythonPanel.ResumeLayout(false);
            this.pythonPanel.PerformLayout();
            this.footer.ResumeLayout(false);
            this.footer.PerformLayout();
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        public void PauseTimer() {
            timer.Stop();
        }

        public void ResumeTimer() {
            if (time.IsEnded) {
                return;
            }

            timerLabel.Text = time.TimeLeftString;
            timer.Start();
        }

        private void SelectionPageTimer_Tick(object sender, EventArgs e) {
            time.TimeLeft--;

            timerLabel.Text = time.TimeLeftString;

            if (time.IsEnded) {
                timer.Stop();
                var resultPage = new ResultPage(new Failed(student));
                this.SwitchForm(resultPage);
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e) {
            e.Cancel = false;
        }

        private void JavaStartButton_Click(object sender, EventArgs e) {
            OpenTestPage(level.GetJava());
        }

        private void PythonStartButton_Click(object sender, EventArgs e) {
            OpenTestPage(level.GetPython());
        }

        private void OpenTestPage(ILanguage language) {
            PauseTimer();
            var testPage = new TestPage(student, time, language, this);
            this.SwitchForm(testPage);
        }
    }
}
