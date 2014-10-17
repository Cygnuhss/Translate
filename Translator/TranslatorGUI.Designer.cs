namespace Translator
{
    partial class TranslatorGUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SourceLanguageTextBox = new System.Windows.Forms.TextBox();
            this.SourceLanguageLabel = new System.Windows.Forms.Label();
            this.TargetLanguageLabel = new System.Windows.Forms.Label();
            this.TranslateButton = new System.Windows.Forms.Button();
            this.TargetLanguageTextBox = new System.Windows.Forms.TextBox();
            this.InputLabel = new System.Windows.Forms.Label();
            this.InputTextBox = new System.Windows.Forms.TextBox();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.OutputTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SourceLanguageTextBox
            // 
            this.SourceLanguageTextBox.Location = new System.Drawing.Point(255, 44);
            this.SourceLanguageTextBox.Name = "SourceLanguageTextBox";
            this.SourceLanguageTextBox.Size = new System.Drawing.Size(92, 20);
            this.SourceLanguageTextBox.TabIndex = 0;
            // 
            // SourceLanguageLabel
            // 
            this.SourceLanguageLabel.AutoSize = true;
            this.SourceLanguageLabel.Location = new System.Drawing.Point(255, 28);
            this.SourceLanguageLabel.Name = "SourceLanguageLabel";
            this.SourceLanguageLabel.Size = new System.Drawing.Size(92, 13);
            this.SourceLanguageLabel.TabIndex = 1;
            this.SourceLanguageLabel.Text = "Source Language";
            this.SourceLanguageLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // TargetLanguageLabel
            // 
            this.TargetLanguageLabel.AutoSize = true;
            this.TargetLanguageLabel.Location = new System.Drawing.Point(258, 71);
            this.TargetLanguageLabel.Name = "TargetLanguageLabel";
            this.TargetLanguageLabel.Size = new System.Drawing.Size(89, 13);
            this.TargetLanguageLabel.TabIndex = 2;
            this.TargetLanguageLabel.Text = "Target Language";
            // 
            // TranslateButton
            // 
            this.TranslateButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TranslateButton.Location = new System.Drawing.Point(255, 125);
            this.TranslateButton.Name = "TranslateButton";
            this.TranslateButton.Size = new System.Drawing.Size(95, 40);
            this.TranslateButton.TabIndex = 3;
            this.TranslateButton.Text = "Translate";
            this.TranslateButton.UseVisualStyleBackColor = false;
            // 
            // TargetLanguageTextBox
            // 
            this.TargetLanguageTextBox.Location = new System.Drawing.Point(255, 87);
            this.TargetLanguageTextBox.Name = "TargetLanguageTextBox";
            this.TargetLanguageTextBox.Size = new System.Drawing.Size(95, 20);
            this.TargetLanguageTextBox.TabIndex = 4;
            this.TargetLanguageTextBox.TextChanged += new System.EventHandler(this.TargetLanguageTextBox_TextChanged);
            // 
            // InputLabel
            // 
            this.InputLabel.AutoSize = true;
            this.InputLabel.Location = new System.Drawing.Point(140, 182);
            this.InputLabel.Name = "InputLabel";
            this.InputLabel.Size = new System.Drawing.Size(31, 13);
            this.InputLabel.TabIndex = 7;
            this.InputLabel.Text = "Input";
            this.InputLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // InputTextBox
            // 
            this.InputTextBox.Location = new System.Drawing.Point(15, 198);
            this.InputTextBox.Multiline = true;
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.Size = new System.Drawing.Size(280, 190);
            this.InputTextBox.TabIndex = 6;
            this.InputTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // OutputLabel
            // 
            this.OutputLabel.AutoSize = true;
            this.OutputLabel.Location = new System.Drawing.Point(430, 182);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(39, 13);
            this.OutputLabel.TabIndex = 9;
            this.OutputLabel.Text = "Output";
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.Location = new System.Drawing.Point(308, 198);
            this.OutputTextBox.Multiline = true;
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.Size = new System.Drawing.Size(280, 190);
            this.OutputTextBox.TabIndex = 8;
            // 
            // TranslatorGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.OutputLabel);
            this.Controls.Add(this.OutputTextBox);
            this.Controls.Add(this.InputLabel);
            this.Controls.Add(this.InputTextBox);
            this.Controls.Add(this.TargetLanguageTextBox);
            this.Controls.Add(this.TranslateButton);
            this.Controls.Add(this.TargetLanguageLabel);
            this.Controls.Add(this.SourceLanguageLabel);
            this.Controls.Add(this.SourceLanguageTextBox);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "TranslatorGUI";
            this.Text = "Translator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SourceLanguageTextBox;
        private System.Windows.Forms.Label SourceLanguageLabel;
        private System.Windows.Forms.Label TargetLanguageLabel;
        private System.Windows.Forms.Button TranslateButton;
        private System.Windows.Forms.TextBox TargetLanguageTextBox;
        private System.Windows.Forms.Label InputLabel;
        private System.Windows.Forms.TextBox InputTextBox;
        private System.Windows.Forms.Label OutputLabel;
        private System.Windows.Forms.TextBox OutputTextBox;
    }
}

