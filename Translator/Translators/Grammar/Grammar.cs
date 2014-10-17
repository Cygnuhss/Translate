using Translate.Translators.Utilities;

namespace Translate.Translators.Grammars
{
    class Grammar : TranslatorObject
    {
        string sourceLanguage;
        string targetLanguage;

        public Grammar(string sourceLanguage, string targetLanguage, string id = "")
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