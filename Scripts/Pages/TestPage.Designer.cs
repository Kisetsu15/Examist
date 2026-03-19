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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestPage));
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
            this.header.SuspendLayout();
            this.footer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.codeBox)).BeginInit();
            this.SuspendLayout();
            // 
            // proceedButton
            // 
            this.proceedButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.proceedButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proceedButton.Location = new System.Drawing.Point(963, 66);
            this.proceedButton.Name = "proceedButton";
            this.proceedButton.Size = new System.Drawing.Size(130, 50);
            this.proceedButton.TabIndex = 2;
            this.proceedButton.Text = "Proceed";
            this.proceedButton.UseVisualStyleBackColor = true;
            this.proceedButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // QuestionLabel
            // 
            this.QuestionLabel.AutoSize = true;
            this.QuestionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionLabel.Location = new System.Drawing.Point(80, 66);
            this.QuestionLabel.Name = "QuestionLabel";
            this.QuestionLabel.Size = new System.Drawing.Size(188, 20);
            this.QuestionLabel.TabIndex = 4;
            this.QuestionLabel.Text = "Debug the following code";
            // 
            // verifyButton
            // 
            this.verifyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.verifyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verifyButton.Location = new System.Drawing.Point(826, 66);
            this.verifyButton.Name = "verifyButton";
            this.verifyButton.Size = new System.Drawing.Size(130, 50);
            this.verifyButton.TabIndex = 5;
            this.verifyButton.Text = "Verify";
            this.verifyButton.UseVisualStyleBackColor = true;
            this.verifyButton.Click += new System.EventHandler(this.VerifyButton_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.TestPageTimer_Tick);
            // 
            // resetButton
            // 
            this.resetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.Location = new System.Drawing.Point(689, 66);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(130, 50);
            this.resetButton.TabIndex = 7;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
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
            this.header.Size = new System.Drawing.Size(1106, 56);
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
            this.studentName.Size = new System.Drawing.Size(162, 26);
            this.studentName.TabIndex = 5;
            this.studentName.Text = "<Student_Name>";
            // 
            // timerLabel
            // 
            this.timerLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.timerLabel.AutoSize = true;
            this.timerLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.timerLabel.Location = new System.Drawing.Point(1019, 14);
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
            this.footer.Location = new System.Drawing.Point(0, 662);
            this.footer.Name = "footer";
            this.footer.Size = new System.Drawing.Size(1106, 49);
            this.footer.TabIndex = 9;
            // 
            // copyRightLabel
            // 
            this.copyRightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.copyRightLabel.AutoSize = true;
            this.copyRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyRightLabel.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.copyRightLabel.Location = new System.Drawing.Point(920, 24);
            this.copyRightLabel.Name = "copyRightLabel";
            this.copyRightLabel.Size = new System.Drawing.Size(174, 16);
            this.copyRightLabel.TabIndex = 0;
            this.copyRightLabel.Text = "Copyright © 2026 Dharshik S";
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Salmon;
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.Color.Snow;
            this.backButton.Location = new System.Drawing.Point(12, 66);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(50, 50);
            this.backButton.TabIndex = 10;
            this.backButton.Text = "X";
            this.backButton.UseVisualStyleBackColor = false;
            // 
            // codeBox
            // 
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
            this.codeBox.AutoScrollMinSize = new System.Drawing.Size(179, 14);
            this.codeBox.BackBrush = null;
            this.codeBox.CharHeight = 14;
            this.codeBox.CharWidth = 8;
            this.codeBox.CurrentPenSize = 3;
            this.codeBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.codeBox.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.codeBox.DocumentPath = null;
            this.codeBox.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.codeBox.IsReplaceMode = false;
            this.codeBox.Location = new System.Drawing.Point(125, 146);
            this.codeBox.Name = "codeBox";
            this.codeBox.Paddings = new System.Windows.Forms.Padding(0);
            this.codeBox.SelectionChangedDelayedEnabled = false;
            this.codeBox.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.codeBox.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("codeBox.ServiceColors")));
            this.codeBox.Size = new System.Drawing.Size(838, 494);
            this.codeBox.TabIndex = 11;
            this.codeBox.Text = "fastColoredTextBox1";
            this.codeBox.Zoom = 100;
            // 
            // TestPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 711);
            this.Controls.Add(this.codeBox);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.footer);
            this.Controls.Add(this.header);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.verifyButton);
            this.Controls.Add(this.QuestionLabel);
            this.Controls.Add(this.proceedButton);
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Name = "TestPage";
            this.Text = "Examist";
            this.Load += new System.EventHandler(this.TestPage_Load);
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            this.footer.ResumeLayout(false);
            this.footer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.codeBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}

