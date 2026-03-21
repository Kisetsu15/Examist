using System;
using System.Drawing;
using System.Windows.Forms;

namespace Examist {

    public partial class StartPage : Form {
        private Panel loginPanel;
        private Label batchNumberLabel;
        private Button submitButton;
        private TextBox studentNameField;
        private TextBox batchNumberField;
        private Label nameLabel;
        private Label errorLabel;
        private Panel footer;
        private Label examistLabel;
        private Panel loginHolder;
        private Panel titleHolder;
        private Label taglineLabel;
        private Label welcomeLabel;
        private Label label1;
        private Button exitButton;
        private Label copyRightLabel;
        private bool canClose = false;

        public StartPage() {
            InitializeComponent();
            errorLabel.Hide();

            this.WindowStyle();
        }

        #region Generated
        private void InitializeComponent() {
            this.loginPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.batchNumberLabel = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.studentNameField = new System.Windows.Forms.TextBox();
            this.batchNumberField = new System.Windows.Forms.TextBox();
            this.footer = new System.Windows.Forms.Panel();
            this.copyRightLabel = new System.Windows.Forms.Label();
            this.examistLabel = new System.Windows.Forms.Label();
            this.loginHolder = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            this.titleHolder = new System.Windows.Forms.Panel();
            this.taglineLabel = new System.Windows.Forms.Label();
            this.loginPanel.SuspendLayout();
            this.footer.SuspendLayout();
            this.loginHolder.SuspendLayout();
            this.titleHolder.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginPanel
            // 
            this.loginPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.loginPanel.Controls.Add(this.label1);
            this.loginPanel.Controls.Add(this.welcomeLabel);
            this.loginPanel.Controls.Add(this.errorLabel);
            this.loginPanel.Controls.Add(this.nameLabel);
            this.loginPanel.Controls.Add(this.batchNumberLabel);
            this.loginPanel.Controls.Add(this.submitButton);
            this.loginPanel.Controls.Add(this.studentNameField);
            this.loginPanel.Controls.Add(this.batchNumberField);
            this.loginPanel.Location = new System.Drawing.Point(130, 60);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(350, 400);
            this.loginPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte) 0);
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(17, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 26);
            this.label1.TabIndex = 9;
            this.label1.Text = "Please Enter your details";
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte) 0);
            this.welcomeLabel.ForeColor = System.Drawing.Color.FromArgb((int) (byte) 50, (int) (byte) 50, (int) (byte) 50);
            this.welcomeLabel.Location = new System.Drawing.Point(16, 58);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(141, 39);
            this.welcomeLabel.TabIndex = 8;
            this.welcomeLabel.Text = "Welcome";
            // 
            // errorLabel
            // 
            this.errorLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.errorLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte) 0);
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(0, 261);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(350, 15);
            this.errorLabel.TabIndex = 7;
            this.errorLabel.Text = "Error Label";
            this.errorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, (byte) 0);
            this.nameLabel.Location = new System.Drawing.Point(21, 193);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(48, 19);
            this.nameLabel.TabIndex = 5;
            this.nameLabel.Text = "Name";
            // 
            // batchNumberLabel
            // 
            this.batchNumberLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.batchNumberLabel.AutoSize = true;
            this.batchNumberLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, (byte) 0);
            this.batchNumberLabel.Location = new System.Drawing.Point(21, 126);
            this.batchNumberLabel.Name = "batchNumberLabel";
            this.batchNumberLabel.Size = new System.Drawing.Size(102, 19);
            this.batchNumberLabel.TabIndex = 4;
            this.batchNumberLabel.Text = "Batch Number";
            // 
            // submitButton
            // 
            this.submitButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.submitButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.submitButton.FlatAppearance.BorderSize = 0;
            this.submitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitButton.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte) 0);
            this.submitButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.submitButton.Location = new System.Drawing.Point(25, 305);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(300, 54);
            this.submitButton.TabIndex = 3;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // studentNameField
            // 
            this.studentNameField.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.studentNameField.BackColor = System.Drawing.Color.WhiteSmoke;
            this.studentNameField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.studentNameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte) 0);
            this.studentNameField.ForeColor = System.Drawing.Color.FromArgb((int) (byte) 30, (int) (byte) 30, (int) (byte) 30);
            this.studentNameField.Location = new System.Drawing.Point(25, 215);
            this.studentNameField.Name = "studentNameField";
            this.studentNameField.Size = new System.Drawing.Size(300, 29);
            this.studentNameField.TabIndex = 1;
            // 
            // batchNumberField
            // 
            this.batchNumberField.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.batchNumberField.BackColor = System.Drawing.Color.WhiteSmoke;
            this.batchNumberField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.batchNumberField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte) 0);
            this.batchNumberField.ForeColor = System.Drawing.Color.FromArgb((int) (byte) 30, (int) (byte) 30, (int) (byte) 30);
            this.batchNumberField.Location = new System.Drawing.Point(25, 148);
            this.batchNumberField.Name = "batchNumberField";
            this.batchNumberField.Size = new System.Drawing.Size(300, 29);
            this.batchNumberField.TabIndex = 0;
            // 
            // footer
            // 
            this.footer.BackColor = System.Drawing.SystemColors.Highlight;
            this.footer.Controls.Add(this.copyRightLabel);
            this.footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footer.Location = new System.Drawing.Point(0, 532);
            this.footer.Name = "footer";
            this.footer.Size = new System.Drawing.Size(1134, 49);
            this.footer.TabIndex = 10;
            // 
            // copyRightLabel
            // 
            this.copyRightLabel.Anchor = (System.Windows.Forms.AnchorStyles) (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
            this.copyRightLabel.AutoSize = true;
            this.copyRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte) 0);
            this.copyRightLabel.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.copyRightLabel.Location = new System.Drawing.Point(948, 24);
            this.copyRightLabel.Name = "copyRightLabel";
            this.copyRightLabel.Size = new System.Drawing.Size(174, 16);
            this.copyRightLabel.TabIndex = 0;
            this.copyRightLabel.Text = "Copyright © 2026 Dharshik S";
            // 
            // examistLabel
            // 
            this.examistLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.examistLabel.AutoSize = true;
            this.examistLabel.Font = new System.Drawing.Font("Impact", 99.75F, (System.Drawing.FontStyle) (System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline), System.Drawing.GraphicsUnit.Point, (byte) 0);
            this.examistLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.examistLabel.Location = new System.Drawing.Point(1, 143);
            this.examistLabel.Name = "examistLabel";
            this.examistLabel.Size = new System.Drawing.Size(527, 161);
            this.examistLabel.TabIndex = 5;
            this.examistLabel.Text = "EXAMIST";
            // 
            // loginHolder
            // 
            this.loginHolder.BackColor = System.Drawing.Color.FromArgb((int) (byte) 232, (int) (byte) 232, (int) (byte) 232);
            this.loginHolder.Controls.Add(this.exitButton);
            this.loginHolder.Controls.Add(this.loginPanel);
            this.loginHolder.Dock = System.Windows.Forms.DockStyle.Right;
            this.loginHolder.Location = new System.Drawing.Point(532, 0);
            this.loginHolder.Name = "loginHolder";
            this.loginHolder.Size = new System.Drawing.Size(602, 532);
            this.loginHolder.TabIndex = 11;
            // 
            // exitButton
            // 
            this.exitButton.Anchor = (System.Windows.Forms.AnchorStyles) (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
            this.exitButton.BackColor = System.Drawing.Color.FromArgb((int) (byte) 232, (int) (byte) 232, (int) (byte) 232);
            this.exitButton.FlatAppearance.BorderColor = System.Drawing.Color.LightCoral;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte) 0);
            this.exitButton.ForeColor = System.Drawing.Color.DimGray;
            this.exitButton.Location = new System.Drawing.Point(543, 12);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(50, 50);
            this.exitButton.TabIndex = 10;
            this.exitButton.Text = "✕";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            this.exitButton.MouseEnter += new System.EventHandler(this.ExitButton_Enter);
            this.exitButton.MouseLeave += new System.EventHandler(this.ExitButton_Leave);
            // 
            // titleHolder
            // 
            this.titleHolder.Anchor = (System.Windows.Forms.AnchorStyles) (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom
            | System.Windows.Forms.AnchorStyles.Left
            | System.Windows.Forms.AnchorStyles.Right);
            this.titleHolder.BackColor = System.Drawing.Color.DodgerBlue;
            this.titleHolder.Controls.Add(this.taglineLabel);
            this.titleHolder.Controls.Add(this.examistLabel);
            this.titleHolder.Location = new System.Drawing.Point(0, 0);
            this.titleHolder.Name = "titleHolder";
            this.titleHolder.Size = new System.Drawing.Size(533, 532);
            this.titleHolder.TabIndex = 12;
            // 
            // taglineLabel
            // 
            this.taglineLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.taglineLabel.AutoSize = true;
            this.taglineLabel.Font = new System.Drawing.Font("Magneto", 20.25F, (System.Drawing.FontStyle) (System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic), System.Drawing.GraphicsUnit.Point, (byte) 0);
            this.taglineLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.taglineLabel.Location = new System.Drawing.Point(22, 304);
            this.taglineLabel.Name = "taglineLabel";
            this.taglineLabel.Size = new System.Drawing.Size(476, 32);
            this.taglineLabel.TabIndex = 6;
            this.taglineLabel.Text = "A Proprietary examination tool";
            // 
            // StartPage
            // 
            this.BackColor = System.Drawing.Color.FromArgb((int) (byte) 224, (int) (byte) 224, (int) (byte) 224);
            this.ClientSize = new System.Drawing.Size(1134, 581);
            this.Controls.Add(this.titleHolder);
            this.Controls.Add(this.loginHolder);
            this.Controls.Add(this.footer);
            this.Name = "StartPage";
            this.Text = "Examist";
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            this.footer.ResumeLayout(false);
            this.footer.PerformLayout();
            this.loginHolder.ResumeLayout(false);
            this.titleHolder.ResumeLayout(false);
            this.titleHolder.PerformLayout();
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
                    new Student(batchNumber, name)
                );

            selectionPage.Show();
            Hide();
        }

        private void SetError(string errorMessage) {
            errorLabel.Text = errorMessage;
            errorLabel.Show();
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
            exitButton.ForeColor = Color.FromArgb((int) (byte) 232, (int) (byte) 232, (int) (byte) 232);
        }

        void ExitButton_Leave(object sender, EventArgs e) {
            exitButton.ForeColor = Color.DimGray;
        }
        #endregion

    }
}