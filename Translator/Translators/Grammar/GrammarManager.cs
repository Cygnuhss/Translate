using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Translate.Translators.Utilities;

namespace Translate.Translators.Grammars
{
    class GrammarManager : ObjectManager
    {
        IList<Grammar> grammars;

        public GrammarManager()
        {
            grammars = new List<Grammar>();
        }
    }
}

