namespace Translate
{
    partial class TranslateGUI
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
            this.sourceLanguageTextBox = new System.Windows.Forms.TextBox();
            this.sourceLanguageLabel = new System.Windows.Forms.Label();
            this.targetLanguageLabel = new System.Windows.Forms.Label();
            this.translateButton = new System.Windows.Forms.Button();
            this.targetLanguageTextBox = new System.Windows.Forms.TextBox();
            this.inputLabel = new System.Windows.Forms.Label();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.outputLabel = new System.Windows.Forms.Label();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // sourceLanguageTextBox
            // 
            this.sourceLanguageTextBox.Location = new System.Drawing.Point(255, 44);
            this.sourceLanguageTextBox.Name = "sourceLanguageTextBox";
            this.sourceLanguageTextBox.Size = new System.Drawing.Size(92, 20);
            this.sourceLanguageTextBox.TabIndex = 0;
            // 
            // sourceLanguageLabel
            // 
            this.sourceLanguageLabel.AutoSize = true;
            this.sourceLanguageLabel.Location = new System.Drawing.Point(255, 28);
            this.sourceLanguageLabel.Name = "sourceLanguageLabel";
            this.sourceLanguageLabel.Size = new System.Drawing.Size(92, 13);
            this.sourceLanguageLabel.TabIndex = 1;
            this.sourceLanguageLabel.Text = "Source Language";
            // 
            // targetLanguageLabel
            // 
            this.targetLanguageLabel.AutoSize = true;
            this.targetLanguageLabel.Location = new System.Drawing.Point(258, 71);
            this.targetLanguageLabel.Name = "targetLanguageLabel";
            this.targetLanguageLabel.Size = new System.Drawing.Size(89, 13);
            this.targetLanguageLabel.TabIndex = 2;
            this.targetLanguageLabel.Text = "Target Language";
            // 
            // translateButton
            // 
            this.translateButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.translateButton.Location = new System.Drawing.Point(255, 125);
            this.translateButton.Name = "translateButton";
            this.translateButton.Size = new System.Drawing.Size(95, 40);
            this.translateButton.TabIndex = 3;
            this.translateButton.Text = "Translate";
            this.translateButton.UseVisualStyleBackColor = false;
            this.translateButton.Click += new System.EventHandler(this.translateButton_Click);
            // 
            // targetLanguageTextBox
            // 
            this.targetLanguageTextBox.Location = new System.Drawing.Point(255, 87);
            this.targetLanguageTextBox.Name = "targetLanguageTextBox";
            this.targetLanguageTextBox.Size = new System.Drawing.Size(95, 20);
            this.targetLanguageTextBox.TabIndex = 4;
            this.targetLanguageTextBox.TextChanged += new System.EventHandler(this.outputTextBox_TextChanged);
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.Location = new System.Drawing.Point(140, 182);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(31, 13);
            this.inputLabel.TabIndex = 7;
            this.inputLabel.Text = "Input";
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(15, 198);
            this.inputTextBox.Multiline = true;
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(280, 190);
            this.inputTextBox.TabIndex = 6;
            this.inputTextBox.TextChanged += new System.EventHandler(this.inputTextBox_TextChanged);
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(430, 182);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(39, 13);
            this.outputLabel.TabIndex = 9;
            this.outputLabel.Text = "Output";
            // 
            // outputTextBox
            // 
            this.outputTextBox.Location = new System.Drawing.Point(308, 198);
            this.outputTextBox.Multiline = true;
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.Size = new System.Drawing.Size(280, 190);
            this.outputTextBox.TabIndex = 8;
            // 
            // TranslateGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.inputLabel);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.targetLanguageTextBox);
            this.Controls.Add(this.translateButton);
            this.Controls.Add(this.targetLanguageLabel);
            this.Controls.Add(this.sourceLanguageLabel);
            this.Controls.Add(this.sourceLanguageTextBox);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "TranslateGUI";
            this.Text = "Translator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sourceLanguageTextBox;
        private System.Windows.Forms.Label sourceLanguageLabel;
        private System.Windows.Forms.Label targetLanguageLabel;
        private System.Windows.Forms.Button translateButton;
        private System.Windows.Forms.TextBox targetLanguageTextBox;
        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.TextBox outputTextBox;
    }
}