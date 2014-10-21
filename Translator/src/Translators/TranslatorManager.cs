using System;
using System.Collections.Generic;
using System.IO;
using Translate.Translators.Dictionaries;
using Translate.Translators.Grammars;
using Translate.Translators.Utilities;

namespace Translate.Translators
{
    class TranslatorManager : TranslatorObjectList
    {
        protected Dictionary<string, string> languageIDs;

        public TranslatorManager(string id = "") : base(id)
        {
            languageIDs = new Dictionary<string, string>();
            LoadLanguageID();
        }

        public void LoadLanguageID()
        {
            string fileName = "languageIDs.txt";
            string cd = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string path = Path.Combine(cd, @"res\", fileName);

            Console.WriteLine("Loading language IDs from {0}.", fileName);

            try
            {
                using (StreamReader r = new StreamReader(path))
                    while(!r.EndOfStream)
                    {
                        // The format of the document is as follows:
                        // One ID <> Language pair per line, split by tab-character.
                        string[] elements = r.ReadLine().Split('\t');
                        languageIDs.Add(elements[0], elements[1]);
                    }

                Console.WriteLine("Language IDs loaded.", fileName);
            } catch (FileNotFoundException)
            {
                Console.WriteLine("File not found: {0}. Language IDs not loaded.", fileName);
            }
        }

        public void InitialiseTranslator(string sourceLanguage, string targetLanguage)
        {
            // Creating the translator and adding it to the translator manager.
            string id = sourceLanguage + '_' + targetLanguage;

            Console.WriteLine("Initialising translator: {0}", id);

            Translator translator = new Translator(sourceLanguage, targetLanguage, id);
            this.Add(translator);

            Dictionary d1 = translator.DictionaryManager.Find(id) as Dictionary;
            Dictionary d2 = translator.DictionaryManager.Find(string.Format("{0}_{1}", id.Split('_')[0], id.Split('_')[1])) as Dictionary;
            if (d1.Entries.Count == 0 || d2.Entries.Count == 0)
            {
                Console.WriteLine("Missing dictionaries in translator {0}. Translator not properly initialised.", id);
                return;
            }
            Grammar g = translator.GrammarManager.Find(id.Split('_')[0]) as Grammar;
            if (g.Entries.Count == 0)
            {
                Console.WriteLine("Missing grammars in translator {0}. Translator not properly initialised.", id);
                return;
            }

            Console.WriteLine("Translator initialised: {0}", id);
        }

        public void Update(string translatorID)
        {
            try
            {              
                // Update the corresponding translator.
                Translator t = this.Find(translatorID) as Translator;
                t.Update();
            } catch (NullReferenceException)
            {
                Console.WriteLine("No translator found: {0}", translatorID);
            }
        }

        public string Translate(string inputText, string translatorID)
        {
            string noTranslationMessage = String.Join(
                " ",
                "The sentence is not translated. This means that we do not have either",
                "a translator pair for the selected languages, or any dictionary entries,",
                "or the grammatical rules to make the translation possible.");

            try
            {
                // Search through the available translators to find the right pair.
                Translator t = this.Find(translatorID) as Translator;
                string text = t.Translate(inputText);
                if (text == "")
                    return noTranslationMessage;

                string[] id = translatorID.Split('_');
                Console.WriteLine("The text is translated from {0} to {1}.\nOriginal text: {2}\nTranslation: {3}",
                                  languageIDs[id[0]], languageIDs[id[1]], inputText, text);

                return text;
            } catch (NullReferenceException)
            {
                Console.WriteLine("No translator found: {0}", translatorID);
                return noTranslationMessage;
            }
        }
    }
}