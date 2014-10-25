using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Translate.Translators.Grammars;
using Translate.Translators.Grammars.Parsers;

namespace Translate.src.Translators.Grammars.Parsers
{
    class TopDownParser : Parser
    {
        protected string parsed = "";

        public TopDownParser(Grammar g, string id = "")
            : base(g, id)
        {
        }

        //public void Parse(string[] sentence)
        //{
        //    int i = 0;
        //    START_SYMBOL(i);
        //    if (parsed[i] == '$')
        //        Console.WriteLine("Valid string.");
        //    else
        //        Console.WriteLine("Invalid string.");
        //    i = 0;
        //}

        //public void START_SYMBOL(int i)
        //{
        //    NP(i++);
        //    VP(i++);
        //    return;
        //}

        //public void NP(int i++)
        //{
        //    N(i++);
        //    return;
        //}

        //public void VP(int i++)
        //{
        //    V(i++);
        //    return;
        //}
    }
}
