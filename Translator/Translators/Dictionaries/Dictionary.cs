using Translate.Translators.Utilities;

namespace Translate.Translators.Dictionaries
{
    class Dictionary : TranslatorObject
    {
        string sourceLanguage;
        string targetLanguage;

        public Dictionary(string sourceLanguage, string targetLanguage, string id = "")
            : base(id)
        {
            this.sourceLanguage = sourceLanguage;
            this.targetLanguage = targetLanguage;
        }

        public void Load()
        {

        }

        public void Update()
        {

        }
    }
}