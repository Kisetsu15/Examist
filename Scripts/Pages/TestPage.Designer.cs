namespace Examist {
    partial class TestPage {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.proceedButton = new System.Windows.Forms.Button();
            this.QuestionLabel = new System.Windows.Forms.Label();
            this.verifyButton = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.resetButton = new System.Windows.Forms.Button();
            this.header = new System.Windows.Forms.Panel();
            this.studentName = new System.Windows.Forms.Label();
            this.timerLabel = new System.Windows.Forms.Label();
            this.batchNumber = new System.Windows.Forms.Label();
            this.footer = new System.Windows.Forms.Panel();
            this.copyRightLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.codeBox = new FastColoredTextBoxNS.FastColoredTextBox();
            this.buttonsPanel = new System.Windows.Forms.Panel();
            this.questionPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.QuestionHeader = new System.Windows.Forms.Label();
            this.statusPanel = new System.Windows.Forms.Panel();
            this.programStatusLabel = new System.Windows.Forms.Label();
            this.statusTimer = new System.Windows.Forms.Timer(this.components);
            this.header.SuspendLayout();
            this.footer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.codeBox)).BeginInit();
            this.buttonsPanel.SuspendLayout();
            this.questionPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.statusPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // proceedButton
            // 
            this.proceedButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.proceedButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.proceedButton.FlatAppearance.BorderSize = 0;
            this.proceedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.proceedButton.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proceedButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.proceedButton.Location = new System.Drawing.Point(963, 28);
            this.proceedButton.Name = "proceedButton";
            this.proceedButton.Size = new System.Drawing.Size(130, 50);
            this.proceedButton.TabIndex = 2;
            this.proceedButton.Text = "Proceed";
            this.proceedButton.UseVisualStyleBackColor = false;
            this.proceedButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // QuestionLabel
            // 
            this.QuestionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.QuestionLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionLabel.ForeColor = System.Drawing.Color.Black;
            this.QuestionLabel.Location = new System.Drawing.Point(15, 80);
            this.QuestionLabel.Name = "QuestionLabel";
            this.QuestionLabel.Size = new System.Drawing.Size(618, 275);
            this.QuestionLabel.TabIndex = 4;
            this.QuestionLabel.Text = "Question will be updated here";
            // 
            // verifyButton
            // 
            this.verifyButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.verifyButton.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.verifyButton.FlatAppearance.BorderSize = 3;
            this.verifyButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.verifyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.verifyButton.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verifyButton.ForeColor = System.Drawing.Color.LimeGreen;
            this.verifyButton.Location = new System.Drawing.Point(827, 28);
            this.verifyButton.Name = "verifyButton";
            this.verifyButton.Size = new System.Drawing.Size(130, 50);
            this.verifyButton.TabIndex = 5;
            this.verifyButton.Text = "Verify";
            this.verifyButton.UseVisualStyleBackColor = true;
            this.verifyButton.Click += new System.EventHandler(this.VerifyButton_Click);
            this.verifyButton.MouseEnter += new System.EventHandler(this.VerifyButton_Enter);
            this.verifyButton.MouseLeave += new System.EventHandler(this.VerifyButton_Leave);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // resetButton
            // 
            this.resetButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.resetButton.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.resetButton.FlatAppearance.BorderSize = 3;
            this.resetButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.resetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetButton.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.ForeColor = System.Drawing.Color.SteelBlue;
            this.resetButton.Location = new System.Drawing.Point(691, 28);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(130, 50);
            this.resetButton.TabIndex = 7;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.ResetButton_Click);
            this.resetButton.MouseEnter += new System.EventHandler(this.ResetButton_Enter);
            this.resetButton.MouseLeave += new System.EventHandler(this.ResetButton_Leave);
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
            this.header.Size = new System.Drawing.Size(1118, 56);
            this.header.TabIndex = 8;
            // 
            // studentName
            // 
            this.studentName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.studentName.AutoSize = true;
            this.studentName.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentName.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.studentName.Location = new System.Drawing.Point(106, 14);
            this.studentName.Name = "studentName";
            this.studentName.Size = new System.Drawing.Size(137, 26);
            this.studentName.TabIndex = 5;
            this.studentName.Text = "Student Name";
            // 
            // timerLabel
            // 
            this.timerLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.timerLabel.AutoSize = true;
            this.timerLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerLabel.ForeColor = System.Drawing.Color.White;
            this.timerLabel.Location = new System.Drawing.Point(1031, 14);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(62, 26);
            this.timerLabel.TabIndex = 4;
            this.timerLabel.Text = "30:00";
            // 
            // batchNumber
            // 
            this.batchNumber.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.batchNumber.AutoSize = true;
            this.batchNumber.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.batchNumber.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.batchNumber.Location = new System.Drawing.Point(12, 14);
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
            this.footer.Location = new System.Drawing.Point(0, 571);
            this.footer.Name = "footer";
            this.footer.Size = new System.Drawing.Size(1118, 49);
            this.footer.TabIndex = 9;
            // 
            // copyRightLabel
            // 
            this.copyRightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.copyRightLabel.AutoSize = true;
            this.copyRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyRightLabel.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.copyRightLabel.Location = new System.Drawing.Point(919, 24);
            this.copyRightLabel.Name = "copyRightLabel";
            this.copyRightLabel.Size = new System.Drawing.Size(174, 16);
            this.copyRightLabel.TabIndex = 0;
            this.copyRightLabel.Text = "Copyright © 2026 Dharshik S";
            // 
            // backButton
            // 
            this.backButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.backButton.BackColor = System.Drawing.SystemColors.Control;
            this.backButton.FlatAppearance.BorderColor = System.Drawing.Color.LightCoral;
            this.backButton.FlatAppearance.BorderSize = 3;
            this.backButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.Color.LightCoral;
            this.backButton.Location = new System.Drawing.Point(17, 28);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(130, 50);
            this.backButton.TabIndex = 10;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.BackButton_Click);
            this.backButton.MouseEnter += new System.EventHandler(this.BackButton_Enter);
            this.backButton.MouseLeave += new System.EventHandler(this.BackButton_Leave);
            // 
            // codeBox
            // 
            this.codeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.codeBox.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.codeBox.AutoIndentCharsPatterns = "^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;=]+);\r\n^\\s*(case|default)\\s*[^:]*" +
    "(?<range>:)\\s*(?<range>[^;]+);";
            this.codeBox.AutoScrollMinSize = new System.Drawing.Size(121, 21);
            this.codeBox.BackBrush = null;
            this.codeBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.codeBox.CaretColor = System.Drawing.Color.BlanchedAlmond;
            this.codeBox.CharHeight = 21;
            this.codeBox.CharWidth = 11;
            this.codeBox.CurrentPenSize = 3;
            this.codeBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.codeBox.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.codeBox.DocumentPath = null;
            this.codeBox.Font = new System.Drawing.Font("Courier New", 14.25F);
            this.codeBox.IsReplaceMode = false;
            this.codeBox.Location = new System.Drawing.Point(673, 170);
            this.codeBox.Name = "codeBox";
            this.codeBox.Paddings = new System.Windows.Forms.Padding(0);
            this.codeBox.SelectionChangedDelayedEnabled = false;
            this.codeBox.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.codeBox.ServiceColors = new FastColoredTextBoxNS.ServiceColors();
            this.codeBox.Size = new System.Drawing.Size(420, 324);
            this.codeBox.TabIndex = 11;
            this.codeBox.Text = "Code Box";
            this.codeBox.Zoom = 100;
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonsPanel.BackColor = System.Drawing.SystemColors.Control;
            this.buttonsPanel.Controls.Add(this.proceedButton);
            this.buttonsPanel.Controls.Add(this.verifyButton);
            this.buttonsPanel.Controls.Add(this.backButton);
            this.buttonsPanel.Controls.Add(this.resetButton);
            this.buttonsPanel.Location = new System.Drawing.Point(0, 43);
            this.buttonsPanel.Name = "buttonsPanel";
            this.buttonsPanel.Size = new System.Drawing.Size(1118, 98);
            this.buttonsPanel.TabIndex = 12;
            // 
            // questionPanel
            // 
            this.questionPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.questionPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.questionPanel.Controls.Add(this.panel1);
            this.questionPanel.Controls.Add(this.QuestionLabel);
            this.questionPanel.Location = new System.Drawing.Point(17, 170);
            this.questionPanel.Name = "questionPanel";
            this.questionPanel.Size = new System.Drawing.Size(650, 376);
            this.questionPanel.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.QuestionHeader);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(650, 60);
            this.panel1.TabIndex = 6;
            // 
            // QuestionHeader
            // 
            this.QuestionHeader.AutoSize = true;
            this.QuestionHeader.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionHeader.ForeColor = System.Drawing.Color.Black;
            this.QuestionHeader.Location = new System.Drawing.Point(15, 15);
            this.QuestionHeader.Name = "QuestionHeader";
            this.QuestionHeader.Size = new System.Drawing.Size(118, 33);
            this.QuestionHeader.TabIndex = 5;
            this.QuestionHeader.Text = "Question";
            // 
            // statusPanel
            // 
            this.statusPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statusPanel.BackColor = System.Drawing.Color.Orange;
            this.statusPanel.Controls.Add(this.programStatusLabel);
            this.statusPanel.Location = new System.Drawing.Point(673, 500);
            this.statusPanel.Name = "statusPanel";
            this.statusPanel.Size = new System.Drawing.Size(419, 45);
            this.statusPanel.TabIndex = 14;
            // 
            // programStatusLabel
            // 
            this.programStatusLabel.AutoSize = true;
            this.programStatusLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.programStatusLabel.ForeColor = System.Drawing.Color.White;
            this.programStatusLabel.Location = new System.Drawing.Point(13, 9);
            this.programStatusLabel.Name = "programStatusLabel";
            this.programStatusLabel.Size = new System.Drawing.Size(141, 26);
            this.programStatusLabel.TabIndex = 0;
            this.programStatusLabel.Text = "Program status";
            // 
            // statusTimer
            // 
            this.statusTimer.Interval = 1000;
            this.statusTimer.Tick += new System.EventHandler(this.StatusTimer_Tick);
            // 
            // TestPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1118, 620);
            this.Controls.Add(this.header);
            this.Controls.Add(this.buttonsPanel);
            this.Controls.Add(this.statusPanel);
            this.Controls.Add(this.questionPanel);
            this.Controls.Add(this.codeBox);
            this.Controls.Add(this.footer);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Name = "TestPage";
            this.Text = "Examist";
            this.Load += new System.EventHandler(this.TestPage_Load);
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            this.footer.ResumeLayout(false);
            this.footer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.codeBox)).EndInit();
            this.buttonsPanel.ResumeLayout(false);
            this.questionPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusPanel.ResumeLayout(false);
            this.statusPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button proceedButton;
        private System.Windows.Forms.Label QuestionLabel;
        private System.Windows.Forms.Button verifyButton;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Label studentName;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.Label batchNumber;
        private System.Windows.Forms.Panel footer;
        private System.Windows.Forms.Label copyRightLabel;
        private System.Windows.Forms.Button backButton;
        private FastColoredTextBoxNS.FastColoredTextBox codeBox;
        private System.Windows.Forms.Panel buttonsPanel;
        private System.Windows.Forms.Panel questionPanel;
        private System.Windows.Forms.Panel statusPanel;
        private System.Windows.Forms.Label programStatusLabel;
        private System.Windows.Forms.Timer statusTimer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label QuestionHeader;
    }
}


