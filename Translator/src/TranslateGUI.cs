using System;
using System.Windows.Forms;
using Translate.Translators;
using Translate.Translators.Dictionaries;
using Translate.Translators.Grammars;

namespace Translate
{
    public partial class TranslateGUI : Form
    {
        public TranslateMain translateMain;

        public TranslateGUI()
        {
            InitializeComponent();

            // Run the translator main.
            translateMain = new TranslateMain();
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
            // Translate the input text and place it in the output text. Cursors appears as 'Wait' cursor in the meanwhile.
            translateButton.UseWaitCursor = true;
            TranslatorManager tm = TranslateMain.TranslatorObjectList.Find("translatorManager") as TranslatorManager;
            string translatorID = string.Format("{0}_{1}", sourceLanguageTextBox.Text, targetLanguageTextBox.Text);
            outputTextBox.Text = tm.Translate(inputTextBox.Text, translatorID);
            translateButton.UseWaitCursor = false;
        }

        private void loadTranslatorButton_Click(object sender, EventArgs e)
        {
            // Initialise translator with the source and target language. Cursors appears as 'Wait' cursor in the meanwhile.
            loadTranslatorButton.UseWaitCursor = true;
            TranslatorManager tm = TranslateMain.TranslatorObjectList.Find("translatorManager") as TranslatorManager;
            tm.InitialiseTranslator(sourceLanguageTextBox.Text, targetLanguageTextBox.Text);
            loadTranslatorButton.UseWaitCursor = false;
        }

        private void updateTranslatorButton_Click(object sender, EventArgs e)
        {
            // Update the translator. Cursors appears as 'Wait' cursor in the meanwhile.
            updateTranslatorButton.UseWaitCursor = true;
            TranslatorManager tm = TranslateMain.TranslatorObjectList.Find("translatorManager") as TranslatorManager;
            string translatorID = string.Format("{0}_{1}", sourceLanguageTextBox.Text, targetLanguageTextBox.Text);
            tm.Update(translatorID);
            updateTranslatorButton.UseWaitCursor = false;
        }

        private void addDictionaryEntryButton_Click(object sender, EventArgs e)
        {
            // Add the entry to the dictionary. Cursors appears as 'Wait' cursor in the meanwhile.
            addDictionaryEntryButton.UseWaitCursor = true;
            TranslatorManager tm = TranslateMain.TranslatorObjectList.Find("translatorManager") as TranslatorManager;
            string id = string.Format("{0}_{1}", sourceLanguageTextBox.Text, targetLanguageTextBox.Text);
            Translator t = tm.Find(id) as Translator;
            try
            {
                Dictionary d = t.DictionaryManager.Find(id) as Dictionary;
                d.AddEntry(originalWordTextBox.Text, translationWordTextBox.Text);
            } catch (NullReferenceException)
            {
                Console.WriteLine("File not found: {0}. Dictionary not updated.", id);
            }
            addDictionaryEntryButton.UseWaitCursor = false;
        }

        private void addGrammarEntryButton_Click(object sender, EventArgs e)
        {
            // Add the entry to the grammar. Cursors appears as 'Wait' cursor in the meanwhile.
            addGrammarEntryButton.UseWaitCursor = true;
            TranslatorManager tm = TranslateMain.TranslatorObjectList.Find("translatorManager") as TranslatorManager;
            string id = sourceLanguageTextBox.Text;
            Translator t = tm.Find(string.Format("{0}_{1}", id, targetLanguageTextBox.Text)) as Translator;
            try
            {
                Grammar g = t.GrammarManager.Find(id) as Grammar;
                g.AddEntry(ruleTextBox.Text);
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("File not found: {0}. Grammar not updated.", id);
            }
            addGrammarEntryButton.UseWaitCursor = false;
        }
    }
}