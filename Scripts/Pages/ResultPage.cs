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
        private Panel resultHolder;
        private Panel panel1;
        private Label label1;
        private readonly IResult result;
        private int level;

        public ResultPage(IResult result, int levelCleared = 0) {
            InitializeComponent();


            this.level = levelCleared;
            this.result = result;
            resultMessageLabel.Text = result.Message;
            studentName.Text = result.Student.Name;
            batchNumber.Text = result.Student.BatchNumber;
            timeValue.Text = result.TimeTaken;
            nextButton.Text = result.ButtonName;


            this.WindowStyle();
            Keyboard.Stop();
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
            this.resultHolder = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.footer.SuspendLayout();
            this.resultHolder.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // resultMessageLabel
            // 
            this.resultMessageLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.resultMessageLabel.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte) 0);
            this.resultMessageLabel.Location = new System.Drawing.Point(0, 232);
            this.resultMessageLabel.Name = "resultMessageLabel";
            this.resultMessageLabel.Size = new System.Drawing.Size(500, 100);
            this.resultMessageLabel.TabIndex = 0;
            this.resultMessageLabel.Text = "Level Cleared";
            this.resultMessageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timeValue
            // 
            this.timeValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.timeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte) 0);
            this.timeValue.Location = new System.Drawing.Point(0, 332);
            this.timeValue.Name = "timeValue";
            this.timeValue.Size = new System.Drawing.Size(500, 61);
            this.timeValue.TabIndex = 1;
            this.timeValue.Text = "30:00";
            this.timeValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // studentName
            // 
            this.studentName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.studentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte) 0);
            this.studentName.Location = new System.Drawing.Point(0, 196);
            this.studentName.Name = "studentName";
            this.studentName.Size = new System.Drawing.Size(500, 31);
            this.studentName.TabIndex = 2;
            this.studentName.Text = "Student Name";
            this.studentName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // batchNumber
            // 
            this.batchNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.batchNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte) 0);
            this.batchNumber.Location = new System.Drawing.Point(0, 143);
            this.batchNumber.Name = "batchNumber";
            this.batchNumber.Size = new System.Drawing.Size(500, 31);
            this.batchNumber.TabIndex = 3;
            this.batchNumber.Text = "2612XX";
            this.batchNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nextButton
            // 
            this.nextButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nextButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.nextButton.FlatAppearance.BorderSize = 0;
            this.nextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextButton.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte) 0);
            this.nextButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.nextButton.Location = new System.Drawing.Point(100, 450);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(300, 50);
            this.nextButton.TabIndex = 4;
            this.nextButton.Text = "Exit";
            this.nextButton.UseVisualStyleBackColor = false;
            this.nextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // footer
            // 
            this.footer.BackColor = System.Drawing.SystemColors.Highlight;
            this.footer.Controls.Add(this.copyRightLabel);
            this.footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footer.Location = new System.Drawing.Point(0, 762);
            this.footer.Name = "footer";
            this.footer.Size = new System.Drawing.Size(1077, 49);
            this.footer.TabIndex = 9;
            // 
            // copyRightLabel
            // 
            this.copyRightLabel.Anchor = (System.Windows.Forms.AnchorStyles) (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
            this.copyRightLabel.AutoSize = true;
            this.copyRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte) 0);
            this.copyRightLabel.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.copyRightLabel.Location = new System.Drawing.Point(891, 24);
            this.copyRightLabel.Name = "copyRightLabel";
            this.copyRightLabel.Size = new System.Drawing.Size(174, 16);
            this.copyRightLabel.TabIndex = 0;
            this.copyRightLabel.Text = "Copyright � 2026 Dharshik S";
            // 
            // resultHolder
            // 
            this.resultHolder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.resultHolder.BackColor = System.Drawing.Color.WhiteSmoke;
            this.resultHolder.Controls.Add(this.resultMessageLabel);
            this.resultHolder.Controls.Add(this.panel1);
            this.resultHolder.Controls.Add(this.nextButton);
            this.resultHolder.Controls.Add(this.batchNumber);
            this.resultHolder.Controls.Add(this.studentName);
            this.resultHolder.Controls.Add(this.timeValue);
            this.resultHolder.Location = new System.Drawing.Point(290, 94);
            this.resultHolder.Name = "resultHolder";
            this.resultHolder.Size = new System.Drawing.Size(500, 600);
            this.resultHolder.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 80);
            this.panel1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte) 0);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(0, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(500, 54);
            this.label1.TabIndex = 12;
            this.label1.Text = "Result";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ResultPage
            // 
            this.BackColor = System.Drawing.Color.FromArgb((int) (byte) 232, (int) (byte) 232, (int) (byte) 232);
            this.ClientSize = new System.Drawing.Size(1077, 811);
            this.Controls.Add(this.resultHolder);
            this.Controls.Add(this.footer);
            this.Name = "ResultPage";
            this.footer.ResumeLayout(false);
            this.footer.PerformLayout();
            this.resultHolder.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected override void OnFormClosing(FormClosingEventArgs e) {
            e.Cancel = result.IsPassed;
        }

        private void NextButton_Click(object sender, System.EventArgs e) {
            result.Execute(this, level);
        }
    }
}
