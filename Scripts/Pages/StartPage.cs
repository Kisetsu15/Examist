using System;
using System.Windows.Forms;

namespace Examist {

    public partial class StartPage : Form {
        private Panel loginPanel;
        private Label batchNumberLabel;
        private Button startButton;
        private TextBox studentNameField;
        private TextBox batchNumberField;
        private Label nameLabel;
        private Label errorLabel;
        private Panel footer;
        private Label copyRightLabel;
        private Panel header;
        private Label examistLabel;

        public StartPage() {
            InitializeComponent();
            errorLabel.Hide();
        }

        #region Generated
        private void InitializeComponent() {
            this.loginPanel = new System.Windows.Forms.Panel();
            this.errorLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.batchNumberLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
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
            this.loginPanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.loginPanel.Controls.Add(this.errorLabel);
            this.loginPanel.Controls.Add(this.nameLabel);
            this.loginPanel.Controls.Add(this.batchNumberLabel);
            this.loginPanel.Controls.Add(this.startButton);
            this.loginPanel.Controls.Add(this.studentNameField);
            this.loginPanel.Controls.Add(this.batchNumberField);
            this.loginPanel.Location = new System.Drawing.Point(336, 188);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(393, 312);
            this.loginPanel.TabIndex = 0;
            // 
            // errorLabel
            // 
            this.errorLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte) 0);
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(151, 169);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(67, 15);
            this.errorLabel.TabIndex = 7;
            this.errorLabel.Text = "Error Label";
            this.errorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte) 0);
            this.nameLabel.Location = new System.Drawing.Point(39, 126);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(57, 23);
            this.nameLabel.TabIndex = 5;
            this.nameLabel.Text = "Name";
            // 
            // batchNumberLabel
            // 
            this.batchNumberLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.batchNumberLabel.AutoSize = true;
            this.batchNumberLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte) 0);
            this.batchNumberLabel.Location = new System.Drawing.Point(39, 89);
            this.batchNumberLabel.Name = "batchNumberLabel";
            this.batchNumberLabel.Size = new System.Drawing.Size(124, 23);
            this.batchNumberLabel.TabIndex = 4;
            this.batchNumberLabel.Text = "Batch Number";
            // 
            // startButton
            // 
            this.startButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.startButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.startButton.FlatAppearance.BorderSize = 0;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte) 0);
            this.startButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.startButton.Location = new System.Drawing.Point(104, 212);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(194, 54);
            this.startButton.TabIndex = 3;
            this.startButton.Text = "START";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // studentNameField
            // 
            this.studentNameField.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.studentNameField.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.studentNameField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.studentNameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte) 0);
            this.studentNameField.Location = new System.Drawing.Point(196, 121);
            this.studentNameField.Name = "studentNameField";
            this.studentNameField.Size = new System.Drawing.Size(169, 29);
            this.studentNameField.TabIndex = 1;
            // 
            // batchNumberField
            // 
            this.batchNumberField.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.batchNumberField.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.batchNumberField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.batchNumberField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte) 0);
            this.batchNumberField.Location = new System.Drawing.Point(196, 87);
            this.batchNumberField.Name = "batchNumberField";
            this.batchNumberField.Size = new System.Drawing.Size(169, 29);
            this.batchNumberField.TabIndex = 0;
            // 
            // footer
            // 
            this.footer.BackColor = System.Drawing.SystemColors.Highlight;
            this.footer.Controls.Add(this.copyRightLabel);
            this.footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footer.Location = new System.Drawing.Point(0, 625);
            this.footer.Name = "footer";
            this.footer.Size = new System.Drawing.Size(1050, 49);
            this.footer.TabIndex = 10;
            // 
            // copyRightLabel
            // 
            this.copyRightLabel.Anchor = (System.Windows.Forms.AnchorStyles) (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
            this.copyRightLabel.AutoSize = true;
            this.copyRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte) 0);
            this.copyRightLabel.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.copyRightLabel.Location = new System.Drawing.Point(865, 24);
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
            this.header.Size = new System.Drawing.Size(1050, 57);
            this.header.TabIndex = 11;
            // 
            // examistLabel
            // 
            this.examistLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.examistLabel.AutoSize = true;
            this.examistLabel.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte) 0);
            this.examistLabel.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.examistLabel.Location = new System.Drawing.Point(12, 9);
            this.examistLabel.Name = "examistLabel";
            this.examistLabel.Size = new System.Drawing.Size(106, 34);
            this.examistLabel.TabIndex = 5;
            this.examistLabel.Text = "EXAMIST";
            // 
            // StartPage
            // 
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1050, 674);
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

        private void StartButton_Click(object sender, EventArgs e) {
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