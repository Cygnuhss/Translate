using System;
using Translate.Translators.Dictionaries;
using Translate.Translators.Grammars;
using Translate.Translators.Utilities;

namespace Translate.Translators
{
    class Translator : TranslatorObject
    {
        protected string sourceLanguage;
        protected string targetLanguage;

        DictionaryManager dictionaries;
        GrammarManager grammars;

        public Translator(string sourceLanguage, string targetLanguage, string id = "")
            : base(id)
        {
            this.sourceLanguage = sourceLanguage;
            this.targetLanguage = targetLanguage;

            dictionaries = new DictionaryManager();
            grammars = new GrammarManager();

            // Adding back and forth dictionaries.
            this.dictionaries.Add(new Dictionary(sourceLanguage, targetLanguage, sourceLanguage + '_' + targetLanguage));
            this.dictionaries.Add(new Dictionary(targetLanguage, sourceLanguage, targetLanguage + '_' + sourceLanguage));

            // Adding back and forth grammars.
            this.grammars.Add(new Grammar(sourceLanguage, sourceLanguage, sourceLanguage + '_' + targetLanguage));
            this.grammars.Add(new Grammar(targetLanguage, targetLanguage, targetLanguage + '_' + sourceLanguage));
        }

        public void Load()
        {
            // Loading the dictionaries and grammars.
            foreach (Dictionary d in dictionaries.Objects)
                d.Load();
            foreach (Grammar g in grammars.Objects)
                g.Load();
        }

        public string Translate(string inputText)
        {
            string outputText = "";
            Dictionary d = dictionaries.Find(sourceLanguage + "_" + targetLanguage) as Dictionary;
            foreach (Tuple<string, string> entry in d.Entries)
                if (entry.Item1 == inputText)
                    outputText = entry.Item2;

            return outputText;
        }

        public Tuple<string, string> Languages
        {
            get { return new Tuple<string, string>(sourceLanguage, targetLanguage); }
        }
    }
}