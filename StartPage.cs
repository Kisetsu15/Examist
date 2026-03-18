using System.Windows.Forms;

namespace Examist {

    public partial class StartPage : Form {
        private Panel loginPanel;
        private Label batchNumberLabel;
        private Button startButton;
        private ComboBox yearComboBox;
        private TextBox studentNameField;
        private TextBox batchNumberField;
        private Label nameLabel;
        private Label errorLabel;
        private Panel footer;
        private Label copyRightLabel;
        private Panel header;
        private Label examistLabel;
        private Label yearLabel;

        public StartPage() {
            InitializeComponent();
            errorLabel.Hide();
        }

        #region Generated
        private void InitializeComponent() {
            this.loginPanel = new System.Windows.Forms.Panel();
            this.errorLabel = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.batchNumberLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.yearComboBox = new System.Windows.Forms.ComboBox();
            this.studentNameField = new System.Windows.Forms.TextBox();
            this.batchNumberField = new System.Windows.Forms.TextBox();
            this.footer = new System.Windows.Forms.Panel();
            this.copyRightLabel = new System.Windows.Forms.Label();
            this.header = new System.Windows.Forms.Panel();
            this.examistLabel = new System.Windows.Forms.Label();
            this.loginPanel.SuspendLayout();
            this.footer.SuspendLayout();
            this.header.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginPanel
            // 
            this.loginPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginPanel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.loginPanel.Controls.Add(this.errorLabel);
            this.loginPanel.Controls.Add(this.yearLabel);
            this.loginPanel.Controls.Add(this.nameLabel);
            this.loginPanel.Controls.Add(this.batchNumberLabel);
            this.loginPanel.Controls.Add(this.startButton);
            this.loginPanel.Controls.Add(this.yearComboBox);
            this.loginPanel.Controls.Add(this.studentNameField);
            this.loginPanel.Controls.Add(this.batchNumberField);
            this.loginPanel.Location = new System.Drawing.Point(315, 111);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(393, 312);
            this.loginPanel.TabIndex = 0;
            // 
            // errorLabel
            // 
            this.errorLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte) 0);
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(154, 169);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(84, 16);
            this.errorLabel.TabIndex = 7;
            this.errorLabel.Text = "Error Label";
            this.errorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yearLabel
            // 
            this.yearLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.yearLabel.AutoSize = true;
            this.yearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte) 0);
            this.yearLabel.Location = new System.Drawing.Point(35, 131);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(49, 24);
            this.yearLabel.TabIndex = 6;
            this.yearLabel.Text = "Year";
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte) 0);
            this.nameLabel.Location = new System.Drawing.Point(35, 93);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(61, 24);
            this.nameLabel.TabIndex = 5;
            this.nameLabel.Text = "Name";
            // 
            // batchNumberLabel
            // 
            this.batchNumberLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.batchNumberLabel.AutoSize = true;
            this.batchNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte) 0);
            this.batchNumberLabel.Location = new System.Drawing.Point(35, 56);
            this.batchNumberLabel.Name = "batchNumberLabel";
            this.batchNumberLabel.Size = new System.Drawing.Size(131, 24);
            this.batchNumberLabel.TabIndex = 4;
            this.batchNumberLabel.Text = "Batch Number";
            // 
            // startButton
            // 
            this.startButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte) 0);
            this.startButton.Location = new System.Drawing.Point(101, 200);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(194, 54);
            this.startButton.TabIndex = 3;
            this.startButton.Text = "START";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // yearComboBox
            // 
            this.yearComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.yearComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.yearComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte) 0);
            this.yearComboBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.yearComboBox.FormattingEnabled = true;
            this.yearComboBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.yearComboBox.Items.AddRange(new object[] {
            "First",
            "Second"});
            this.yearComboBox.Location = new System.Drawing.Point(192, 123);
            this.yearComboBox.Name = "yearComboBox";
            this.yearComboBox.Size = new System.Drawing.Size(169, 32);
            this.yearComboBox.Sorted = true;
            this.yearComboBox.TabIndex = 2;
            // 
            // studentNameField
            // 
            this.studentNameField.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.studentNameField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.studentNameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte) 0);
            this.studentNameField.Location = new System.Drawing.Point(192, 88);
            this.studentNameField.Name = "studentNameField";
            this.studentNameField.Size = new System.Drawing.Size(169, 29);
            this.studentNameField.TabIndex = 1;
            // 
            // batchNumberField
            // 
            this.batchNumberField.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.batchNumberField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.batchNumberField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte) 0);
            this.batchNumberField.Location = new System.Drawing.Point(192, 54);
            this.batchNumberField.Name = "batchNumberField";
            this.batchNumberField.Size = new System.Drawing.Size(169, 29);
            this.batchNumberField.TabIndex = 0;
            // 
            // footer
            // 
            this.footer.BackColor = System.Drawing.SystemColors.Highlight;
            this.footer.Controls.Add(this.copyRightLabel);
            this.footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footer.Location = new System.Drawing.Point(0, 472);
            this.footer.Name = "footer";
            this.footer.Size = new System.Drawing.Size(1009, 49);
            this.footer.TabIndex = 10;
            // 
            // copyRightLabel
            // 
            this.copyRightLabel.Anchor = (System.Windows.Forms.AnchorStyles) (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
            this.copyRightLabel.AutoSize = true;
            this.copyRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte) 0);
            this.copyRightLabel.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.copyRightLabel.Location = new System.Drawing.Point(824, 24);
            this.copyRightLabel.Name = "copyRightLabel";
            this.copyRightLabel.Size = new System.Drawing.Size(174, 16);
            this.copyRightLabel.TabIndex = 0;
            this.copyRightLabel.Text = "Copyright © 2026 Dharshik S";
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.SystemColors.Highlight;
            this.header.Controls.Add(this.examistLabel);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1009, 57);
            this.header.TabIndex = 11;
            // 
            // examistLabel
            // 
            this.examistLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.examistLabel.AutoSize = true;
            this.examistLabel.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte) 0);
            this.examistLabel.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.examistLabel.Location = new System.Drawing.Point(12, 9);
            this.examistLabel.Name = "examistLabel";
            this.examistLabel.Size = new System.Drawing.Size(169, 39);
            this.examistLabel.TabIndex = 5;
            this.examistLabel.Text = "EXAMIST";
            // 
            // StartPage
            // 
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1009, 521);
            this.Controls.Add(this.header);
            this.Controls.Add(this.footer);
            this.Controls.Add(this.loginPanel);
            this.Name = "StartPage";
            this.Text = "Start Page";
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            this.footer.ResumeLayout(false);
            this.footer.PerformLayout();
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private void StartButton_Click(object sender, System.EventArgs e) {
            errorLabel.Hide();

            if (studentNameField == null || batchNumberField == null) {
                return;
            }

            string name = studentNameField.Text;
            string batchNumber = batchNumberField.Text;


            if (name == string.Empty || batchNumber == string.Empty) {
                SetError("All fields are required");
                return;
            }

            int lowerThreshold = 270000;
            int higherThreshold = 290000;

            if (!int.TryParse(batchNumber, out int number) ||
                number < lowerThreshold ||
                number > higherThreshold) {

                SetError("Invalid Batch Number");
                return;
            }


            var selectionPage = new LevelSelectionPage(
                    new Student(name, batchNumber)
                );

            selectionPage.Show();
            Hide();
        }

        private void SetError(string errorMessage) {
            errorLabel.Text = errorMessage;
            errorLabel.Show();
        }
    }
}