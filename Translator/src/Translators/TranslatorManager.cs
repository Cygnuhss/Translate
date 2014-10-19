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

        public string Translate(string sourceLanguage, string targetLanguage, string inputText)
        {
            // Search through the available translators to find the right pair.
            foreach (Translator t in this.Objects)
                if (sourceLanguage == t.Languages.Item1 && targetLanguage == t.Languages.Item2)
                    return t.Translate(inputText);

            return String.Empty;
        }
    }
}