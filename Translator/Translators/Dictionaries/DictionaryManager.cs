using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Translate.Translators.Utilities;

namespace Translate.Translators.Dictionaries
{
    class DictionaryManager : ObjectManager
    {
        IList<Dictionary> dictionaries;

        public DictionaryManager()
        {
            dictionaries = new List<Dictionary>();
        }
    }
}
