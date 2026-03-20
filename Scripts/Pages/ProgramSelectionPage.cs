using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Examist {
    public partial class ProgramSelectionPage : Form {
        private const int ONE_SECOND = 1000;
        private readonly Time time;
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
        private Panel panel1;
        private Panel panel2;
        private Label levelLabel;
        private Label copyRightLabel;


        public ProgramSelectionPage(Student student, ILevel level) {
            InitializeComponent();

            this.student = student;
            this.level = level;

            time = new Time(timeInSeconds: level.TimeInMinutes);
            timer.Interval = ONE_SECOND;
            timerLabel.Text = time.TimeLeftString;
            timer.Start();

            studentName.Text = student.Name;
            batchNumber.Text = student.BatchNumber;
            levelLabel.Text = $"Level {level.Level}";
            this.WindowStyle();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.levelLabel = new System.Windows.Forms.Label();
            this.javaPanel.SuspendLayout();
            this.pythonPanel.SuspendLayout();
            this.footer.SuspendLayout();
            this.header.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // javaPanel
            // 
            this.javaPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.javaPanel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.javaPanel.Controls.Add(this.javaLabel);
            this.javaPanel.Controls.Add(this.javaOpenButton);
            this.javaPanel.Location = new System.Drawing.Point(26, 77);
            this.javaPanel.Name = "javaPanel";
            this.javaPanel.Size = new System.Drawing.Size(600, 80);
            this.javaPanel.TabIndex = 0;
            // 
            // javaLabel
            // 
            this.javaLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.javaLabel.AutoSize = true;
            this.javaLabel.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte) 0);
            this.javaLabel.Location = new System.Drawing.Point(25, 25);
            this.javaLabel.Name = "javaLabel";
            this.javaLabel.Size = new System.Drawing.Size(147, 29);
            this.javaLabel.TabIndex = 2;
            this.javaLabel.Text = "Java Program";
            // 
            // javaOpenButton
            // 
            this.javaOpenButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.javaOpenButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.javaOpenButton.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.javaOpenButton.FlatAppearance.BorderSize = 0;
            this.javaOpenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.javaOpenButton.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte) 0);
            this.javaOpenButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.javaOpenButton.Location = new System.Drawing.Point(463, 22);
            this.javaOpenButton.Name = "javaOpenButton";
            this.javaOpenButton.Size = new System.Drawing.Size(120, 40);
            this.javaOpenButton.TabIndex = 1;
            this.javaOpenButton.Text = "Open";
            this.javaOpenButton.UseVisualStyleBackColor = false;
            this.javaOpenButton.Click += new System.EventHandler(this.JavaStartButton_Click);
            // 
            // pythonPanel
            // 
            this.pythonPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pythonPanel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pythonPanel.Controls.Add(this.pythonLabel);
            this.pythonPanel.Controls.Add(this.pythonOpenButton);
            this.pythonPanel.Location = new System.Drawing.Point(26, 184);
            this.pythonPanel.Name = "pythonPanel";
            this.pythonPanel.Size = new System.Drawing.Size(600, 80);
            this.pythonPanel.TabIndex = 3;
            // 
            // pythonLabel
            // 
            this.pythonLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pythonLabel.AutoSize = true;
            this.pythonLabel.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte) 0);
            this.pythonLabel.Location = new System.Drawing.Point(25, 25);
            this.pythonLabel.Name = "pythonLabel";
            this.pythonLabel.Size = new System.Drawing.Size(175, 29);
            this.pythonLabel.TabIndex = 2;
            this.pythonLabel.Text = "Python Program";
            // 
            // pythonOpenButton
            // 
            this.pythonOpenButton.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.pythonOpenButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pythonOpenButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.pythonOpenButton.FlatAppearance.BorderSize = 0;
            this.pythonOpenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pythonOpenButton.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte) 0);
            this.pythonOpenButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.pythonOpenButton.Location = new System.Drawing.Point(463, 22);
            this.pythonOpenButton.Name = "pythonOpenButton";
            this.pythonOpenButton.Size = new System.Drawing.Size(120, 40);
            this.pythonOpenButton.TabIndex = 1;
            this.pythonOpenButton.Text = "Open";
            this.pythonOpenButton.UseVisualStyleBackColor = false;
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
            this.footer.Location = new System.Drawing.Point(0, 514);
            this.footer.Name = "footer";
            this.footer.Size = new System.Drawing.Size(1039, 49);
            this.footer.TabIndex = 8;
            // 
            // copyRightLabel
            // 
            this.copyRightLabel.Anchor = (System.Windows.Forms.AnchorStyles) (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
            this.copyRightLabel.AutoSize = true;
            this.copyRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte) 0);
            this.copyRightLabel.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.copyRightLabel.Location = new System.Drawing.Point(853, 24);
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
            this.timerLabel.Location = new System.Drawing.Point(952, 14);
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
            this.studentName.Size = new System.Drawing.Size(137, 26);
            this.studentName.TabIndex = 5;
            this.studentName.Text = "Student Name";
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
            this.header.Size = new System.Drawing.Size(1039, 56);
            this.header.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pythonPanel);
            this.panel1.Controls.Add(this.javaPanel);
            this.panel1.Location = new System.Drawing.Point(193, 141);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(653, 291);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.levelLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(653, 49);
            this.panel2.TabIndex = 4;
            // 
            // levelLabel
            // 
            this.levelLabel.BackColor = System.Drawing.Color.LightGray;
            this.levelLabel.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte) 0);
            this.levelLabel.ForeColor = System.Drawing.Color.DimGray;
            this.levelLabel.Location = new System.Drawing.Point(0, 0);
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.Size = new System.Drawing.Size(653, 49);
            this.levelLabel.TabIndex = 0;
            this.levelLabel.Text = "Level 1";
            this.levelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProgramSelectionPage
            // 
            this.BackColor = System.Drawing.Color.FromArgb((int) (byte) 232, (int) (byte) 232, (int) (byte) 232);
            this.ClientSize = new System.Drawing.Size(1039, 563);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.footer);
            this.Controls.Add(this.header);
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
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
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
