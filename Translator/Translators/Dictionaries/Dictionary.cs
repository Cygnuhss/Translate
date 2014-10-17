using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Translate.Translators.Dictionaries
{
    class Dictionary
    {
        string sourceLanguage;
        string targetLanguage;

        public Dictionary(string sourceLanguage, string targetLanguage)
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
