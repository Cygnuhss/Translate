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
            this.loadTranslatorButton = new System.Windows.Forms.Button();
            this.originalWordLabel = new System.Windows.Forms.Label();
            this.originalWordTextBox = new System.Windows.Forms.TextBox();
            this.translationWordLabel = new System.Windows.Forms.Label();
            this.translationWordTextBox = new System.Windows.Forms.TextBox();
            this.updateTranslatorButton = new System.Windows.Forms.Button();
            this.addDictionaryEntryButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sourceLanguageTextBox
            // 
            this.sourceLanguageTextBox.Location = new System.Drawing.Point(55, 44);
            this.sourceLanguageTextBox.Name = "sourceLanguageTextBox";
            this.sourceLanguageTextBox.Size = new System.Drawing.Size(95, 20);
            this.sourceLanguageTextBox.TabIndex = 0;
            // 
            // sourceLanguageLabel
            // 
            this.sourceLanguageLabel.AutoSize = true;
            this.sourceLanguageLabel.Location = new System.Drawing.Point(55, 28);
            this.sourceLanguageLabel.Name = "sourceLanguageLabel";
            this.sourceLanguageLabel.Size = new System.Drawing.Size(92, 13);
            this.sourceLanguageLabel.TabIndex = 1;
            this.sourceLanguageLabel.Text = "Source Language";
            // 
            // targetLanguageLabel
            // 
            this.targetLanguageLabel.AutoSize = true;
            this.targetLanguageLabel.Location = new System.Drawing.Point(58, 71);
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
            this.targetLanguageTextBox.Location = new System.Drawing.Point(55, 87);
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
            // loadTranslatorButton
            // 
            this.loadTranslatorButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.loadTranslatorButton.Location = new System.Drawing.Point(156, 43);
            this.loadTranslatorButton.Name = "loadTranslatorButton";
            this.loadTranslatorButton.Size = new System.Drawing.Size(102, 20);
            this.loadTranslatorButton.TabIndex = 10;
            this.loadTranslatorButton.Text = "Load Translator";
            this.loadTranslatorButton.UseVisualStyleBackColor = false;
            this.loadTranslatorButton.Click += new System.EventHandler(this.loadTranslatorButton_Click);
            // 
            // originalWordLabel
            // 
            this.originalWordLabel.AutoSize = true;
            this.originalWordLabel.Location = new System.Drawing.Point(471, 28);
            this.originalWordLabel.Name = "originalWordLabel";
            this.originalWordLabel.Size = new System.Drawing.Size(71, 13);
            this.originalWordLabel.TabIndex = 12;
            this.originalWordLabel.Text = "Original Word";
            // 
            // originalWordTextBox
            // 
            this.originalWordTextBox.Location = new System.Drawing.Point(459, 44);
            this.originalWordTextBox.Name = "originalWordTextBox";
            this.originalWordTextBox.Size = new System.Drawing.Size(95, 20);
            this.originalWordTextBox.TabIndex = 11;
            // 
            // translationWordLabel
            // 
            this.translationWordLabel.AutoSize = true;
            this.translationWordLabel.Location = new System.Drawing.Point(477, 71);
            this.translationWordLabel.Name = "translationWordLabel";
            this.translationWordLabel.Size = new System.Drawing.Size(59, 13);
            this.translationWordLabel.TabIndex = 14;
            this.translationWordLabel.Text = "Translation";
            // 
            // translationWordTextBox
            // 
            this.translationWordTextBox.Location = new System.Drawing.Point(459, 87);
            this.translationWordTextBox.Name = "translationWordTextBox";
            this.translationWordTextBox.Size = new System.Drawing.Size(95, 20);
            this.translationWordTextBox.TabIndex = 13;
            // 
            // updateTranslatorButton
            // 
            this.updateTranslatorButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.updateTranslatorButton.Location = new System.Drawing.Point(156, 86);
            this.updateTranslatorButton.Name = "updateTranslatorButton";
            this.updateTranslatorButton.Size = new System.Drawing.Size(102, 20);
            this.updateTranslatorButton.TabIndex = 15;
            this.updateTranslatorButton.Text = "Update Translator";
            this.updateTranslatorButton.UseVisualStyleBackColor = false;
            this.updateTranslatorButton.Click += new System.EventHandler(this.updateTranslatorButton_Click);
            // 
            // addDictionaryEntryButton
            // 
            this.addDictionaryEntryButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.addDictionaryEntryButton.Location = new System.Drawing.Point(459, 113);
            this.addDictionaryEntryButton.Name = "addDictionaryEntryButton";
            this.addDictionaryEntryButton.Size = new System.Drawing.Size(95, 35);
            this.addDictionaryEntryButton.TabIndex = 16;
            this.addDictionaryEntryButton.Text = "Add Dictionary Entry";
            this.addDictionaryEntryButton.UseVisualStyleBackColor = false;
            this.addDictionaryEntryButton.Click += new System.EventHandler(this.addDictionaryEntryButton_Click);
            // 
            // TranslateGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.addDictionaryEntryButton);
            this.Controls.Add(this.updateTranslatorButton);
            this.Controls.Add(this.translationWordLabel);
            this.Controls.Add(this.translationWordTextBox);
            this.Controls.Add(this.originalWordLabel);
            this.Controls.Add(this.originalWordTextBox);
            this.Controls.Add(this.loadTranslatorButton);
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
        private System.Windows.Forms.Button loadTranslatorButton;
        private System.Windows.Forms.Label originalWordLabel;
        private System.Windows.Forms.TextBox originalWordTextBox;
        private System.Windows.Forms.Label translationWordLabel;
        private System.Windows.Forms.TextBox translationWordTextBox;
        private System.Windows.Forms.Button updateTranslatorButton;
        private System.Windows.Forms.Button addDictionaryEntryButton;
    }
}