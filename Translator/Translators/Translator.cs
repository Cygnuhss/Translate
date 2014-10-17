using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Translate.Translators.Dictionaries;
using Translate.Translators.Grammars;

namespace Translate.Translators
{
    class Translator
    {
        string sourceLanguage;
        string targetLanguage;

        DictionaryManager dictionaries;
        GrammarManager grammars;

        public Translator(string sourceLanguage, string targetLanguage)
        {
            this.sourceLanguage = sourceLanguage;
            this.targetLanguage = targetLanguage;

            dictionaries = new DictionaryManager();
            grammars = new GrammarManager();

            // Adding back and forth dictionaries.
            this.dictionaries.Add(new Dictionary(sourceLanguage, targetLanguage));
            this.dictionaries.Add(new Dictionary(targetLanguage, sourceLanguage));

            // Adding back and forth grammars.
            this.grammars.Add(new Grammar(sourceLanguage, targetLanguage));
            this.grammars.Add(new Grammar(targetLanguage, sourceLanguage));
        }

        public void Load()
        {
            // Loading the dictionaries and grammars.
            foreach (Dictionary d in dictionaries)
                d.Load();
            foreach (Grammar g in grammars)
                g.Load();
        }

        public string TranslateText(string inputText)
        {
            string outputText = "Hi";

            return outputText;
        }

        public Tuple<string, string> Languages
        {
            get { return new Tuple<string, string>(sourceLanguage, targetLanguage); }
        }
    }
}
