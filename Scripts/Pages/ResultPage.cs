using System.Windows.Forms;

namespace Examist {
    public partial class ResultPage : Form {
        private Label resultMessageLabel;
        private Label studentName;
        private Label batchNumber;
        private Label timeValue;
        private Panel footer;
        private Label copyRightLabel;
        private Button nextButton;
        private readonly IResult result;

        public ResultPage(IResult result) {
            this.result = result;

            resultMessageLabel.Text = result.Message;
            studentName.Text = result.Student.Name;
            batchNumber.Text = result.Student.BatchNumber;
            timeValue.Text = result.TimeTaken;
            nextButton.Text = result.ButtonName;

            InitializeComponent();
        }

        #region Generated
        private void InitializeComponent() {
            this.resultMessageLabel = new System.Windows.Forms.Label();
            this.timeValue = new System.Windows.Forms.Label();
            this.studentName = new System.Windows.Forms.Label();
            this.batchNumber = new System.Windows.Forms.Label();
            this.nextButton = new System.Windows.Forms.Button();
            this.footer = new System.Windows.Forms.Panel();
            this.copyRightLabel = new System.Windows.Forms.Label();
            this.footer.SuspendLayout();
            this.SuspendLayout();
            // 
            // resultMessageLabel
            // 
            this.resultMessageLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.resultMessageLabel.AutoSize = true;
            this.resultMessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte) 0);
            this.resultMessageLabel.Location = new System.Drawing.Point(388, 226);
            this.resultMessageLabel.Name = "resultMessageLabel";
            this.resultMessageLabel.Size = new System.Drawing.Size(181, 31);
            this.resultMessageLabel.TabIndex = 0;
            this.resultMessageLabel.Text = "Level Cleared";
            this.resultMessageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timeValue
            // 
            this.timeValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.timeValue.AutoSize = true;
            this.timeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte) 0);
            this.timeValue.Location = new System.Drawing.Point(434, 271);
            this.timeValue.Name = "timeValue";
            this.timeValue.Size = new System.Drawing.Size(98, 37);
            this.timeValue.TabIndex = 1;
            this.timeValue.Text = "30:00";
            // 
            // studentName
            // 
            this.studentName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.studentName.AutoSize = true;
            this.studentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte) 0);
            this.studentName.Location = new System.Drawing.Point(374, 178);
            this.studentName.Name = "studentName";
            this.studentName.Size = new System.Drawing.Size(219, 31);
            this.studentName.TabIndex = 2;
            this.studentName.Text = "<Student Name>";
            // 
            // batchNumber
            // 
            this.batchNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.batchNumber.AutoSize = true;
            this.batchNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte) 0);
            this.batchNumber.Location = new System.Drawing.Point(422, 132);
            this.batchNumber.Name = "batchNumber";
            this.batchNumber.Size = new System.Drawing.Size(110, 31);
            this.batchNumber.TabIndex = 3;
            this.batchNumber.Text = "2612XX";
            // 
            // nextButton
            // 
            this.nextButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nextButton.Location = new System.Drawing.Point(411, 333);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(144, 46);
            this.nextButton.TabIndex = 4;
            this.nextButton.Text = "EXIT";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // footer
            // 
            this.footer.BackColor = System.Drawing.SystemColors.Highlight;
            this.footer.Controls.Add(this.copyRightLabel);
            this.footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footer.Location = new System.Drawing.Point(0, 557);
            this.footer.Name = "footer";
            this.footer.Size = new System.Drawing.Size(970, 49);
            this.footer.TabIndex = 9;
            // 
            // copyRightLabel
            // 
            this.copyRightLabel.Anchor = (System.Windows.Forms.AnchorStyles) (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
            this.copyRightLabel.AutoSize = true;
            this.copyRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte) 0);
            this.copyRightLabel.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.copyRightLabel.Location = new System.Drawing.Point(784, 24);
            this.copyRightLabel.Name = "copyRightLabel";
            this.copyRightLabel.Size = new System.Drawing.Size(174, 16);
            this.copyRightLabel.TabIndex = 0;
            this.copyRightLabel.Text = "Copyright © 2026 Dharshik S";
            // 
            // ResultPage
            // 
            this.ClientSize = new System.Drawing.Size(970, 606);
            this.Controls.Add(this.footer);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.batchNumber);
            this.Controls.Add(this.studentName);
            this.Controls.Add(this.timeValue);
            this.Controls.Add(this.resultMessageLabel);
            this.Name = "ResultPage";
            this.footer.ResumeLayout(false);
            this.footer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected override void OnFormClosing(FormClosingEventArgs e) {
            e.Cancel = result.IsPassed;
        }

        private void NextButton_Click(object sender, System.EventArgs e) {
            result.Execute(this);
        }
    }
}