using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Translate.Translators.Utilities;

namespace Translate.Translators
{
    class TranslatorManager : ObjectManager
    {
        IList<Translator> translators;

        public TranslatorManager()
        {
            translators = new List<Translator>();
        }
    }
}
