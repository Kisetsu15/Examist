using System;
using System.Drawing;
using System.Windows.Forms;

namespace Examist {
    public partial class LevelSelectionPage : Form {
        private Panel levelTwoPanel;
        private Label levelTwoLabel;
        private Button levelTwoStartButton;
        private Button levelOneStartButton;
        private Panel levelOnePanel;
        private Label levelOneLabel;
        private Panel header;
        private Label studentName;
        private Label batchNumber;
        private Panel footer;
        private Label copyRightLabel;
        private Panel panel1;

        private readonly Student student;
        private Label levelOneDifficulty;
        private Label levelTwoTimeLimit;
        private Label levelTwoDifficulty;
        private Panel levelOneHeader;
        private Label levelOneTimeLimit;
        private Panel panel2;
        private readonly bool levelTwoUnlocked;
        private Button exitButton;
        private Panel panel3;
        private Label levelSelectionLabel;
        private bool canClose = false;



        public LevelSelectionPage(Student student, bool levelTwoUnlocked = false) {
            InitializeComponent();

            this.student = student;
            this.levelTwoUnlocked = levelTwoUnlocked;

            studentName.Text = student.Name;
            batchNumber.Text = student.BatchNumber;

            if (levelTwoUnlocked) {
                levelOneStartButton.Text = "Completed";
                levelOneStartButton.Disable();
                levelTwoStartButton.Enable();
                levelTwoStartButton.Text = "Start";
                exitButton.Hide();
            } else {
                levelOneStartButton.Enable();
                levelOneStartButton.Text = "Start";
                levelTwoStartButton.Disable();
                levelTwoStartButton.Text = "Locked";
            }

            this.WindowStyle();
        }

        #region Generated
        private void InitializeComponent() {
            this.levelTwoPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.levelTwoLabel = new System.Windows.Forms.Label();
            this.levelTwoTimeLimit = new System.Windows.Forms.Label();
            this.levelTwoDifficulty = new System.Windows.Forms.Label();
            this.levelTwoStartButton = new System.Windows.Forms.Button();
            this.levelOnePanel = new System.Windows.Forms.Panel();
            this.levelOneHeader = new System.Windows.Forms.Panel();
            this.levelOneLabel = new System.Windows.Forms.Label();
            this.levelOneTimeLimit = new System.Windows.Forms.Label();
            this.levelOneDifficulty = new System.Windows.Forms.Label();
            this.levelOneStartButton = new System.Windows.Forms.Button();
            this.header = new System.Windows.Forms.Panel();
            this.studentName = new System.Windows.Forms.Label();
            this.batchNumber = new System.Windows.Forms.Label();
            this.footer = new System.Windows.Forms.Panel();
            this.copyRightLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.levelSelectionLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.levelTwoPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.levelOnePanel.SuspendLayout();
            this.levelOneHeader.SuspendLayout();
            this.header.SuspendLayout();
            this.footer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // levelTwoPanel
            // 
            this.levelTwoPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.levelTwoPanel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.levelTwoPanel.Controls.Add(this.panel2);
            this.levelTwoPanel.Controls.Add(this.levelTwoTimeLimit);
            this.levelTwoPanel.Controls.Add(this.levelTwoDifficulty);
            this.levelTwoPanel.Controls.Add(this.levelTwoStartButton);
            this.levelTwoPanel.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.levelTwoPanel.Location = new System.Drawing.Point(360, 75);
            this.levelTwoPanel.Name = "levelTwoPanel";
            this.levelTwoPanel.Size = new System.Drawing.Size(320, 250);
            this.levelTwoPanel.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel2.Controls.Add(this.levelTwoLabel);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(320, 64);
            this.panel2.TabIndex = 6;
            // 
            // levelTwoLabel
            // 
            this.levelTwoLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.levelTwoLabel.AutoSize = true;
            this.levelTwoLabel.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte) 0);
            this.levelTwoLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.levelTwoLabel.Location = new System.Drawing.Point(15, 15);
            this.levelTwoLabel.Name = "levelTwoLabel";
            this.levelTwoLabel.Size = new System.Drawing.Size(94, 33);
            this.levelTwoLabel.TabIndex = 2;
            this.levelTwoLabel.Text = "Level 2";
            // 
            // levelTwoTimeLimit
            // 
            this.levelTwoTimeLimit.AutoSize = true;
            this.levelTwoTimeLimit.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte) 0);
            this.levelTwoTimeLimit.ForeColor = System.Drawing.Color.DimGray;
            this.levelTwoTimeLimit.Location = new System.Drawing.Point(20, 110);
            this.levelTwoTimeLimit.Name = "levelTwoTimeLimit";
            this.levelTwoTimeLimit.Size = new System.Drawing.Size(193, 23);
            this.levelTwoTimeLimit.TabIndex = 6;
            this.levelTwoTimeLimit.Text = "Time Limit: 20 Minutes";
            // 
            // levelTwoDifficulty
            // 
            this.levelTwoDifficulty.AutoSize = true;
            this.levelTwoDifficulty.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte) 0);
            this.levelTwoDifficulty.ForeColor = System.Drawing.Color.DimGray;
            this.levelTwoDifficulty.Location = new System.Drawing.Point(20, 80);
            this.levelTwoDifficulty.Name = "levelTwoDifficulty";
            this.levelTwoDifficulty.Size = new System.Drawing.Size(171, 23);
            this.levelTwoDifficulty.TabIndex = 5;
            this.levelTwoDifficulty.Text = "Difficulty: Moderate";
            // 
            // levelTwoStartButton
            // 
            this.levelTwoStartButton.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.levelTwoStartButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.levelTwoStartButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.levelTwoStartButton.Enabled = false;
            this.levelTwoStartButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.levelTwoStartButton.FlatAppearance.BorderSize = 0;
            this.levelTwoStartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.levelTwoStartButton.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte) 0);
            this.levelTwoStartButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.levelTwoStartButton.Location = new System.Drawing.Point(180, 190);
            this.levelTwoStartButton.Name = "levelTwoStartButton";
            this.levelTwoStartButton.Size = new System.Drawing.Size(120, 40);
            this.levelTwoStartButton.TabIndex = 1;
            this.levelTwoStartButton.Text = "Locked";
            this.levelTwoStartButton.UseVisualStyleBackColor = false;
            this.levelTwoStartButton.Click += new System.EventHandler(this.LevelTwoStartButton_Click);
            // 
            // levelOnePanel
            // 
            this.levelOnePanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.levelOnePanel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.levelOnePanel.Controls.Add(this.levelOneHeader);
            this.levelOnePanel.Controls.Add(this.levelOneTimeLimit);
            this.levelOnePanel.Controls.Add(this.levelOneDifficulty);
            this.levelOnePanel.Controls.Add(this.levelOneStartButton);
            this.levelOnePanel.Location = new System.Drawing.Point(20, 75);
            this.levelOnePanel.Name = "levelOnePanel";
            this.levelOnePanel.Size = new System.Drawing.Size(320, 250);
            this.levelOnePanel.TabIndex = 4;
            // 
            // levelOneHeader
            // 
            this.levelOneHeader.BackColor = System.Drawing.Color.LightSkyBlue;
            this.levelOneHeader.Controls.Add(this.levelOneLabel);
            this.levelOneHeader.Location = new System.Drawing.Point(0, 0);
            this.levelOneHeader.Name = "levelOneHeader";
            this.levelOneHeader.Size = new System.Drawing.Size(320, 64);
            this.levelOneHeader.TabIndex = 5;
            // 
            // levelOneLabel
            // 
            this.levelOneLabel.AutoSize = true;
            this.levelOneLabel.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte) 0);
            this.levelOneLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.levelOneLabel.Location = new System.Drawing.Point(15, 15);
            this.levelOneLabel.Name = "levelOneLabel";
            this.levelOneLabel.Size = new System.Drawing.Size(94, 33);
            this.levelOneLabel.TabIndex = 2;
            this.levelOneLabel.Text = "Level 1";
            // 
            // levelOneTimeLimit
            // 
            this.levelOneTimeLimit.AutoSize = true;
            this.levelOneTimeLimit.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte) 0);
            this.levelOneTimeLimit.ForeColor = System.Drawing.Color.DimGray;
            this.levelOneTimeLimit.Location = new System.Drawing.Point(20, 110);
            this.levelOneTimeLimit.Name = "levelOneTimeLimit";
            this.levelOneTimeLimit.Size = new System.Drawing.Size(193, 23);
            this.levelOneTimeLimit.TabIndex = 4;
            this.levelOneTimeLimit.Text = "Time Limit: 15 Minutes";
            // 
            // levelOneDifficulty
            // 
            this.levelOneDifficulty.AutoSize = true;
            this.levelOneDifficulty.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte) 0);
            this.levelOneDifficulty.ForeColor = System.Drawing.Color.DimGray;
            this.levelOneDifficulty.Location = new System.Drawing.Point(20, 80);
            this.levelOneDifficulty.Name = "levelOneDifficulty";
            this.levelOneDifficulty.Size = new System.Drawing.Size(126, 23);
            this.levelOneDifficulty.TabIndex = 3;
            this.levelOneDifficulty.Text = "Difficulty: Easy";
            // 
            // levelOneStartButton
            // 
            this.levelOneStartButton.Anchor = (System.Windows.Forms.AnchorStyles) (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
            this.levelOneStartButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.levelOneStartButton.FlatAppearance.BorderSize = 0;
            this.levelOneStartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.levelOneStartButton.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte) 0);
            this.levelOneStartButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.levelOneStartButton.Location = new System.Drawing.Point(180, 190);
            this.levelOneStartButton.Name = "levelOneStartButton";
            this.levelOneStartButton.Size = new System.Drawing.Size(120, 40);
            this.levelOneStartButton.TabIndex = 1;
            this.levelOneStartButton.Text = "Start";
            this.levelOneStartButton.UseVisualStyleBackColor = false;
            this.levelOneStartButton.Click += new System.EventHandler(this.LevelOneStartButton_Click);
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.SystemColors.Highlight;
            this.header.Controls.Add(this.studentName);
            this.header.Controls.Add(this.batchNumber);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1041, 57);
            this.header.TabIndex = 8;
            // 
            // studentName
            // 
            this.studentName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.studentName.AutoSize = true;
            this.studentName.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte) 0);
            this.studentName.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.studentName.Location = new System.Drawing.Point(106, 13);
            this.studentName.Name = "studentName";
            this.studentName.Size = new System.Drawing.Size(137, 26);
            this.studentName.TabIndex = 5;
            this.studentName.Text = "Student Name";
            // 
            // batchNumber
            // 
            this.batchNumber.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.batchNumber.AutoSize = true;
            this.batchNumber.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte) 0);
            this.batchNumber.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.batchNumber.Location = new System.Drawing.Point(12, 13);
            this.batchNumber.Name = "batchNumber";
            this.batchNumber.Size = new System.Drawing.Size(80, 26);
            this.batchNumber.TabIndex = 6;
            this.batchNumber.Text = "2612XX";
            // 
            // footer
            // 
            this.footer.BackColor = System.Drawing.SystemColors.Highlight;
            this.footer.Controls.Add(this.copyRightLabel);
            this.footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footer.Location = new System.Drawing.Point(0, 509);
            this.footer.Name = "footer";
            this.footer.Size = new System.Drawing.Size(1041, 49);
            this.footer.TabIndex = 9;
            // 
            // copyRightLabel
            // 
            this.copyRightLabel.Anchor = (System.Windows.Forms.AnchorStyles) (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
            this.copyRightLabel.AutoSize = true;
            this.copyRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte) 0);
            this.copyRightLabel.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.copyRightLabel.Location = new System.Drawing.Point(856, 24);
            this.copyRightLabel.Name = "copyRightLabel";
            this.copyRightLabel.Size = new System.Drawing.Size(174, 16);
            this.copyRightLabel.TabIndex = 0;
            this.copyRightLabel.Text = "Copyright © 2026 Dharshik S";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.levelTwoPanel);
            this.panel1.Controls.Add(this.levelOnePanel);
            this.panel1.Location = new System.Drawing.Point(169, 112);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 350);
            this.panel1.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.Controls.Add(this.levelSelectionLabel);
            this.panel3.Controls.Add(this.exitButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(700, 50);
            this.panel3.TabIndex = 6;
            // 
            // levelSelectionLabel
            // 
            this.levelSelectionLabel.AutoSize = true;
            this.levelSelectionLabel.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte) 0);
            this.levelSelectionLabel.ForeColor = System.Drawing.Color.DimGray;
            this.levelSelectionLabel.Location = new System.Drawing.Point(10, 10);
            this.levelSelectionLabel.Name = "levelSelectionLabel";
            this.levelSelectionLabel.Size = new System.Drawing.Size(160, 29);
            this.levelSelectionLabel.TabIndex = 12;
            this.levelSelectionLabel.Text = "Level Selection";
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.LightGray;
            this.exitButton.FlatAppearance.BorderColor = System.Drawing.Color.LightCoral;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte) 0);
            this.exitButton.ForeColor = System.Drawing.Color.DimGray;
            this.exitButton.Location = new System.Drawing.Point(650, 0);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(50, 50);
            this.exitButton.TabIndex = 11;
            this.exitButton.Text = "✕";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            this.exitButton.MouseEnter += new System.EventHandler(this.ExitButton_Enter);
            this.exitButton.MouseLeave += new System.EventHandler(this.ExitButton_Leave);
            // 
            // LevelSelectionPage
            // 
            this.BackColor = System.Drawing.Color.FromArgb((int) (byte) 232, (int) (byte) 232, (int) (byte) 232);
            this.ClientSize = new System.Drawing.Size(1041, 558);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.footer);
            this.Controls.Add(this.header);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte) 0);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "LevelSelectionPage";
            this.Text = "Level Selection Page";
            this.levelTwoPanel.ResumeLayout(false);
            this.levelTwoPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.levelOnePanel.ResumeLayout(false);
            this.levelOnePanel.PerformLayout();
            this.levelOneHeader.ResumeLayout(false);
            this.levelOneHeader.PerformLayout();
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            this.footer.ResumeLayout(false);
            this.footer.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private void LevelOneStartButton_Click(object sender, EventArgs e) {
            var nextPage = new ProgramSelectionPage(student, new LevelOne());
            this.SwitchForm(nextPage);
        }

        private void LevelTwoStartButton_Click(object sender, EventArgs e) {
            if (levelTwoUnlocked) {
                var nextPage = new ProgramSelectionPage(student, new LevelTwo());
                this.SwitchForm(nextPage);
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e) {
            e.Cancel = !canClose;
        }

        private void ExitButton_Click(object sender, EventArgs e) {
            canClose = true;
            Application.Exit();
        }

        #region Aesthetics
        void ExitButton_Enter(object sender, EventArgs e) {
            exitButton.ForeColor = Color.LightGray;
        }

        void ExitButton_Leave(object sender, EventArgs e) {
            exitButton.ForeColor = Color.DimGray;
        }
        #endregion
    }
}