using System.Windows.Forms;

namespace Examist {
    public partial class ResultPage : Form {
        private Label completionTimeText;
        private Label studentName;
        private Label batchNumber;
        private Label timeValue;
        private Panel footer;
        private Label copyRightLabel;
        private Button exitButton;

        public ResultPage(Student student, string time) {
            studentName.Text = student.Name;
            batchNumber.Text = student.BatchNumber.ToString();
            timeValue.Text = time;
        }

        #region Generated
        private void InitializeComponent() {
            this.completionTimeText = new System.Windows.Forms.Label();
            this.timeValue = new System.Windows.Forms.Label();
            this.studentName = new System.Windows.Forms.Label();
            this.batchNumber = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.footer = new System.Windows.Forms.Panel();
            this.copyRightLabel = new System.Windows.Forms.Label();
            this.footer.SuspendLayout();
            this.SuspendLayout();
            // 
            // completionTimeText
            // 
            this.completionTimeText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.completionTimeText.AutoSize = true;
            this.completionTimeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.completionTimeText.Location = new System.Drawing.Point(279, 179);
            this.completionTimeText.Name = "completionTimeText";
            this.completionTimeText.Size = new System.Drawing.Size(218, 31);
            this.completionTimeText.TabIndex = 0;
            this.completionTimeText.Text = "Completion Time";
            // 
            // timeValue
            // 
            this.timeValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.timeValue.AutoSize = true;
            this.timeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeValue.Location = new System.Drawing.Point(339, 226);
            this.timeValue.Name = "timeValue";
            this.timeValue.Size = new System.Drawing.Size(98, 37);
            this.timeValue.TabIndex = 1;
            this.timeValue.Text = "30:00";
            // 
            // studentName
            // 
            this.studentName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.studentName.AutoSize = true;
            this.studentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentName.Location = new System.Drawing.Point(279, 133);
            this.studentName.Name = "studentName";
            this.studentName.Size = new System.Drawing.Size(219, 31);
            this.studentName.TabIndex = 2;
            this.studentName.Text = "<Student Name>";
            // 
            // batchNumber
            // 
            this.batchNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.batchNumber.AutoSize = true;
            this.batchNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.batchNumber.Location = new System.Drawing.Point(327, 87);
            this.batchNumber.Name = "batchNumber";
            this.batchNumber.Size = new System.Drawing.Size(110, 31);
            this.batchNumber.TabIndex = 3;
            this.batchNumber.Text = "2612XX";
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.Location = new System.Drawing.Point(316, 288);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(144, 46);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "EXIT";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // footer
            // 
            this.footer.BackColor = System.Drawing.SystemColors.Highlight;
            this.footer.Controls.Add(this.copyRightLabel);
            this.footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footer.Location = new System.Drawing.Point(0, 467);
            this.footer.Name = "footer";
            this.footer.Size = new System.Drawing.Size(781, 49);
            this.footer.TabIndex = 9;
            // 
            // copyRightLabel
            // 
            this.copyRightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.copyRightLabel.AutoSize = true;
            this.copyRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyRightLabel.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.copyRightLabel.Location = new System.Drawing.Point(595, 24);
            this.copyRightLabel.Name = "copyRightLabel";
            this.copyRightLabel.Size = new System.Drawing.Size(174, 16);
            this.copyRightLabel.TabIndex = 0;
            this.copyRightLabel.Text = "Copyright © 2026 Dharshik S";
            // 
            // ResultPage
            // 
            this.ClientSize = new System.Drawing.Size(781, 516);
            this.Controls.Add(this.footer);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.batchNumber);
            this.Controls.Add(this.studentName);
            this.Controls.Add(this.timeValue);
            this.Controls.Add(this.completionTimeText);
            this.Name = "ResultPage";
            this.footer.ResumeLayout(false);
            this.footer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected override void OnFormClosing(FormClosingEventArgs e) {
            e.Cancel = false;
        }

        private void ExitButton_Click(object sender, System.EventArgs e) {
            Application.Exit();
        }
    }
}