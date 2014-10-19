using System;
using Translate.Translators.Utilities;

namespace Translate.Translators
{
    class TranslatorManager : TranslatorObjectList
    {
        public TranslatorManager(string id = "") : base(id)
        {
        }

        public void InitialiseTranslator(string sourceLanguage, string targetLanguage)
        {
            // Creating the translator and adding it to the translator manager.
            string id = sourceLanguage + '_' + targetLanguage;

            Console.WriteLine("Initialising translator: " + id);
            Translator translator = new Translator(sourceLanguage, targetLanguage, id);
            this.Add(translator);
            Console.WriteLine("Translator initialised: " + id);
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
                return text;
            } catch (NullReferenceException)
            {
                Console.WriteLine("No translator found: {0}", translatorID);
                return noTranslationMessage;
            }
        }
    }
}