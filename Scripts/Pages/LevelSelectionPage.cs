using System;
using System.Windows.Forms;

namespace Examist {
    public partial class LevelSelectionPage : Form {
        private Panel levelTwoPanel;
        private Label levelTwoLabel;
        private Button levelTwoStartButton;
        private Panel levelOnePanel;
        private Label levelOneLabel;
        private Panel header;
        private Label studentName;
        private Label batchNumber;
        private Panel footer;
        private Label copyRightLabel;
        private Panel panel1;
        private Button levelOneStartButton;

        private readonly Student student;
        private readonly bool levelTwoUnlocked;


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
            }
        }

        #region Generated
        private void InitializeComponent() {
            this.levelTwoPanel = new System.Windows.Forms.Panel();
            this.levelTwoLabel = new System.Windows.Forms.Label();
            this.levelTwoStartButton = new System.Windows.Forms.Button();
            this.levelOnePanel = new System.Windows.Forms.Panel();
            this.levelOneLabel = new System.Windows.Forms.Label();
            this.levelOneStartButton = new System.Windows.Forms.Button();
            this.header = new System.Windows.Forms.Panel();
            this.studentName = new System.Windows.Forms.Label();
            this.batchNumber = new System.Windows.Forms.Label();
            this.footer = new System.Windows.Forms.Panel();
            this.copyRightLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.levelTwoPanel.SuspendLayout();
            this.levelOnePanel.SuspendLayout();
            this.header.SuspendLayout();
            this.footer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // levelTwoPanel
            // 
            this.levelTwoPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.levelTwoPanel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.levelTwoPanel.Controls.Add(this.levelTwoLabel);
            this.levelTwoPanel.Controls.Add(this.levelTwoStartButton);
            this.levelTwoPanel.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.levelTwoPanel.Location = new System.Drawing.Point(19, 119);
            this.levelTwoPanel.Name = "levelTwoPanel";
            this.levelTwoPanel.Size = new System.Drawing.Size(656, 64);
            this.levelTwoPanel.TabIndex = 5;
            // 
            // levelTwoLabel
            // 
            this.levelTwoLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.levelTwoLabel.AutoSize = true;
            this.levelTwoLabel.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte) 0);
            this.levelTwoLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.levelTwoLabel.Location = new System.Drawing.Point(26, 15);
            this.levelTwoLabel.Name = "levelTwoLabel";
            this.levelTwoLabel.Size = new System.Drawing.Size(81, 29);
            this.levelTwoLabel.TabIndex = 2;
            this.levelTwoLabel.Text = "Level 2";
            // 
            // levelTwoStartButton
            // 
            this.levelTwoStartButton.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.levelTwoStartButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.levelTwoStartButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.levelTwoStartButton.Enabled = false;
            this.levelTwoStartButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.levelTwoStartButton.FlatAppearance.BorderSize = 0;
            this.levelTwoStartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.levelTwoStartButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.levelTwoStartButton.Location = new System.Drawing.Point(524, 15);
            this.levelTwoStartButton.Name = "levelTwoStartButton";
            this.levelTwoStartButton.Size = new System.Drawing.Size(103, 34);
            this.levelTwoStartButton.TabIndex = 1;
            this.levelTwoStartButton.Text = "Locked";
            this.levelTwoStartButton.UseVisualStyleBackColor = false;
            this.levelTwoStartButton.Click += new System.EventHandler(this.LevelTwoStartButton_Click);
            // 
            // levelOnePanel
            // 
            this.levelOnePanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.levelOnePanel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.levelOnePanel.Controls.Add(this.levelOneLabel);
            this.levelOnePanel.Controls.Add(this.levelOneStartButton);
            this.levelOnePanel.Location = new System.Drawing.Point(19, 30);
            this.levelOnePanel.Name = "levelOnePanel";
            this.levelOnePanel.Size = new System.Drawing.Size(656, 64);
            this.levelOnePanel.TabIndex = 4;
            // 
            // levelOneLabel
            // 
            this.levelOneLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.levelOneLabel.AutoSize = true;
            this.levelOneLabel.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte) 0);
            this.levelOneLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.levelOneLabel.Location = new System.Drawing.Point(25, 17);
            this.levelOneLabel.Name = "levelOneLabel";
            this.levelOneLabel.Size = new System.Drawing.Size(81, 29);
            this.levelOneLabel.TabIndex = 2;
            this.levelOneLabel.Text = "Level 1";
            // 
            // levelOneStartButton
            // 
            this.levelOneStartButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.levelOneStartButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.levelOneStartButton.FlatAppearance.BorderSize = 0;
            this.levelOneStartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.levelOneStartButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.levelOneStartButton.Location = new System.Drawing.Point(524, 17);
            this.levelOneStartButton.Name = "levelOneStartButton";
            this.levelOneStartButton.Size = new System.Drawing.Size(103, 34);
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
            this.header.Size = new System.Drawing.Size(1029, 57);
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
            this.studentName.Size = new System.Drawing.Size(162, 26);
            this.studentName.TabIndex = 5;
            this.studentName.Text = "<Student_Name>";
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
            this.footer.Location = new System.Drawing.Point(0, 479);
            this.footer.Name = "footer";
            this.footer.Size = new System.Drawing.Size(1029, 49);
            this.footer.TabIndex = 9;
            // 
            // copyRightLabel
            // 
            this.copyRightLabel.Anchor = (System.Windows.Forms.AnchorStyles) (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
            this.copyRightLabel.AutoSize = true;
            this.copyRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte) 0);
            this.copyRightLabel.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.copyRightLabel.Location = new System.Drawing.Point(844, 24);
            this.copyRightLabel.Name = "copyRightLabel";
            this.copyRightLabel.Size = new System.Drawing.Size(174, 16);
            this.copyRightLabel.TabIndex = 0;
            this.copyRightLabel.Text = "Copyright © 2026 Dharshik S";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.levelTwoPanel);
            this.panel1.Controls.Add(this.levelOnePanel);
            this.panel1.Location = new System.Drawing.Point(167, 158);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(688, 208);
            this.panel1.TabIndex = 10;
            // 
            // LevelSelectionPage
            // 
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1029, 528);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.footer);
            this.Controls.Add(this.header);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte) 0);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "LevelSelectionPage";
            this.Text = "Level Selection Page";
            this.levelTwoPanel.ResumeLayout(false);
            this.levelTwoPanel.PerformLayout();
            this.levelOnePanel.ResumeLayout(false);
            this.levelOnePanel.PerformLayout();
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            this.footer.ResumeLayout(false);
            this.footer.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        private void LevelOneStartButton_Click(object sender, EventArgs e) {
            var page = new ProgramSelectionPage(student, new LevelOne());
            page.Show();
            Hide();
        }

        private void LevelTwoStartButton_Click(object sender, EventArgs e) {
            if (levelTwoUnlocked) {
                var page = new ProgramSelectionPage(student, new LevelTwo());
                page.Show();
                Hide();
            }
        }
    }
}