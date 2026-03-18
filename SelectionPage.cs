using System;
using System.Windows.Forms;
using System.ComponentModel;

namespace Examist {
    public partial class SelectionPage : Form
    {
        private const int ONE_SECOND = 1000;
        private readonly Time time = new Time(timeInSeconds: 5);
        private bool canClose = false;
        private readonly Student student;

        private Panel javaPanel;
        private Label JavaLabel;
        private Panel pythonPanel;
        private Label pythonLabel;
        private Button pythonStartButton;
        private Button javaStartButton;
        private Timer selectionPageTimer;
        private IContainer components;
        private Label studentName;
        private Label batchNumber;
        private Label timerLabel;

        public SelectionPage(Student student)
        {
            InitializeComponent();
            selectionPageTimer.Interval = ONE_SECOND;
            selectionPageTimer.Start();

            this.student = student;

            studentName.Text = student.Name;
            batchNumber.Text = student.BatchNumber;

            WindowState = FormWindowState.Maximized;
            FormBorderStyle = FormBorderStyle.None;
            TopMost = true;
        }


        #region Generated
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.javaPanel = new System.Windows.Forms.Panel();
            this.JavaLabel = new System.Windows.Forms.Label();
            this.javaStartButton = new System.Windows.Forms.Button();
            this.pythonPanel = new System.Windows.Forms.Panel();
            this.pythonLabel = new System.Windows.Forms.Label();
            this.pythonStartButton = new System.Windows.Forms.Button();
            this.selectionPageTimer = new System.Windows.Forms.Timer(this.components);
            this.timerLabel = new System.Windows.Forms.Label();
            this.studentName = new System.Windows.Forms.Label();
            this.batchNumber = new System.Windows.Forms.Label();
            this.javaPanel.SuspendLayout();
            this.pythonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // javaPanel
            // 
            this.javaPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.javaPanel.Controls.Add(this.JavaLabel);
            this.javaPanel.Controls.Add(this.javaStartButton);
            this.javaPanel.Location = new System.Drawing.Point(176, 150);
            this.javaPanel.Name = "javaPanel";
            this.javaPanel.Size = new System.Drawing.Size(614, 74);
            this.javaPanel.TabIndex = 0;
            // 
            // JavaLabel
            // 
            this.JavaLabel.AutoSize = true;
            this.JavaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JavaLabel.Location = new System.Drawing.Point(25, 22);
            this.JavaLabel.Name = "JavaLabel";
            this.JavaLabel.Size = new System.Drawing.Size(145, 25);
            this.JavaLabel.TabIndex = 2;
            this.JavaLabel.Text = "Java Program";
            // 
            // javaStartButton
            // 
            this.javaStartButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.javaStartButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.javaStartButton.Location = new System.Drawing.Point(494, 20);
            this.javaStartButton.Name = "javaStartButton";
            this.javaStartButton.Size = new System.Drawing.Size(103, 34);
            this.javaStartButton.TabIndex = 1;
            this.javaStartButton.Text = "Start";
            this.javaStartButton.UseVisualStyleBackColor = false;
            this.javaStartButton.Click += new System.EventHandler(this.JavaStartButton_Click);
            // 
            // pythonPanel
            // 
            this.pythonPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pythonPanel.Controls.Add(this.pythonLabel);
            this.pythonPanel.Controls.Add(this.pythonStartButton);
            this.pythonPanel.Location = new System.Drawing.Point(176, 239);
            this.pythonPanel.Name = "pythonPanel";
            this.pythonPanel.Size = new System.Drawing.Size(614, 74);
            this.pythonPanel.TabIndex = 3;
            // 
            // pythonLabel
            // 
            this.pythonLabel.AutoSize = true;
            this.pythonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pythonLabel.Location = new System.Drawing.Point(25, 22);
            this.pythonLabel.Name = "pythonLabel";
            this.pythonLabel.Size = new System.Drawing.Size(166, 25);
            this.pythonLabel.TabIndex = 2;
            this.pythonLabel.Text = "Python Program";
            // 
            // pythonStartButton
            // 
            this.pythonStartButton.Location = new System.Drawing.Point(494, 20);
            this.pythonStartButton.Name = "pythonStartButton";
            this.pythonStartButton.Size = new System.Drawing.Size(103, 34);
            this.pythonStartButton.TabIndex = 1;
            this.pythonStartButton.Text = "Start";
            this.pythonStartButton.UseVisualStyleBackColor = true;
            this.pythonStartButton.Click += new System.EventHandler(this.PythonStartButton_Click);
            // 
            // selectionPageTimer
            // 
            this.selectionPageTimer.Tick += new System.EventHandler(this.SelectionPageTimer_Tick);
            // 
            // timerLabel
            // 
            this.timerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.timerLabel.AutoSize = true;
            this.timerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerLabel.Location = new System.Drawing.Point(827, 22);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(94, 25);
            this.timerLabel.TabIndex = 4;
            this.timerLabel.Text = "⏲ 30:00";
            // 
            // studentName
            // 
            this.studentName.AutoSize = true;
            this.studentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentName.Location = new System.Drawing.Point(196, 33);
            this.studentName.Name = "studentName";
            this.studentName.Size = new System.Drawing.Size(178, 25);
            this.studentName.TabIndex = 5;
            this.studentName.Text = "<Student_Name>";
            // 
            // batchNumber
            // 
            this.batchNumber.AutoSize = true;
            this.batchNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.batchNumber.Location = new System.Drawing.Point(12, 33);
            this.batchNumber.Name = "batchNumber";
            this.batchNumber.Size = new System.Drawing.Size(88, 25);
            this.batchNumber.TabIndex = 6;
            this.batchNumber.Text = "2612XX";
            // 
            // SelectionPage
            // 
            this.ClientSize = new System.Drawing.Size(944, 501);
            this.Controls.Add(this.batchNumber);
            this.Controls.Add(this.studentName);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.pythonPanel);
            this.Controls.Add(this.javaPanel);
            this.Name = "SelectionPage";
            this.Text = "Selection Page";
            this.javaPanel.ResumeLayout(false);
            this.javaPanel.PerformLayout();
            this.pythonPanel.ResumeLayout(false);
            this.pythonPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private void SelectionPageTimer_Tick(object sender, EventArgs e)
        {
            time.TimeLeft--;

            timerLabel.Text = $"⏲️:{time.TimeLeftString}";

            if (time.IsEnded)
            {
                CloseApplication("Test Time Over!");
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            e.Cancel = !canClose;
        }

        void CloseApplication(string message)
        {
            selectionPageTimer.Stop();
            MessageBox.Show(message);
            canClose = true;
            Application.Exit();
        }

        private void JavaStartButton_Click(object sender, EventArgs e)
        {
            TestPage testPage = new TestPage(student, time, selectionPageTimer, Language.Java);
            testPage.Show();
            Hide();
        }

        private void PythonStartButton_Click(object sender, EventArgs e)
        {
            TestPage testPage = new TestPage(student, time, selectionPageTimer, Language.Python);
            testPage.Show();
            Hide();
        }
    }

    public enum Language
    {
        Java,
        Python
    }
}