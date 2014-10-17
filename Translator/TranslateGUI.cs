using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Translate
{
    public partial class TranslateGUI : Form
    {
        TranslateMain translateMain;

        public TranslateGUI(TranslateMain translateMain)
        {
            InitializeComponent();

            this.translateMain = translateMain;
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
            translateMain.InitialiseTranslator(sourceLanguageTextBox.Text, targetLanguageTextBox.Text);
            // Translate the input text and place it in the output text. Cursors appears as 'Wait' cursor.
            translateButton.UseWaitCursor = true;
            outputTextBox.Text = translateMain.Translate(sourceLanguageTextBox.Text, targetLanguageTextBox.Text, inputTextBox.Text);
            translateButton.UseWaitCursor = false;
        }
    }
}
