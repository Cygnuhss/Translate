using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Translate.Translators;

namespace Translate
{
    public class TranslateMain
    {
        TranslatorManager translatorManager;

        public TranslateMain()
        {
            // Start the GUI.
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TranslateGUI(this));

            // Create the translator manager.
            translatorManager = new TranslatorManager();
        }

        public void InitialiseTranslator(string sourceLanguage, string targetLanguage)
        {
            // Creating the translator and adding it to the translator manager.
            Translator translator = new Translator(sourceLanguage, targetLanguage);
            translatorManager.Add(translator);
        }

        public string Translate(string sourceLanguage, string targetLanguage, string inputText)
        {
            // Search through the available translators to find the right pair.
            foreach (Translator t in translatorManager)
                if (sourceLanguage == t.Languages.Item1 && targetLanguage == t.Languages.Item2)
                    return t.TranslateText(inputText);

            return String.Empty;
        }
    }
}
