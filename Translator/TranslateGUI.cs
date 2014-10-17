using System;
using System.Windows.Forms;
using Translate.Translators;

namespace Translate
{
    public partial class TranslateGUI : Form
    {
        public TranslateGUI()
        {
            InitializeComponent();
        }

        private void sourceLanguageTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void targetLanguageTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void inputTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void outputTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void translateButton_Click(object sender, EventArgs e)
        {
            // Initialise translator with the source and target language.
            TranslatorManager translatorManager = TranslateMain.TranslatorObjectList.Find("translatorManager") as TranslatorManager;
            translatorManager.InitialiseTranslator(sourceLanguageTextBox.Text, targetLanguageTextBox.Text);
            // Translate the input text and place it in the output text. Cursors appears as 'Wait' cursor.
            translateButton.UseWaitCursor = true;
            outputTextBox.Text = translatorManager.Translate(sourceLanguageTextBox.Text, targetLanguageTextBox.Text, inputTextBox.Text);
            translateButton.UseWaitCursor = false;
        }
    }
}