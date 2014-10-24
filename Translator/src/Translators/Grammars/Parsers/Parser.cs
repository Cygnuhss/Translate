using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Translate.Translators.Utilities;

namespace Translate.Translators.Grammars.Parsers
{
    class Parser : TranslatorObject
    {
        protected string sourceLanguage;
        protected string fileName;

        protected Grammar relatedGrammar;

        //
        IList<string> term = new List<string>();
        IList<string> nterm = new List<string>();
        IList<string[]> rules = new List<string[]>();

        public Parser(Grammar g, string id = "")
            : base(id)
        {
            this.sourceLanguage = g.Languages;

            // File name is of this format: pars_[sourcelanguage].txt
            this.fileName = string.Format("pars_{0}.txt", sourceLanguage);

            Load();
        }

        public void Load()
        {
            string cd = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string path = Path.Combine(cd, @"res\Grammars\Parsers", fileName);

            Console.WriteLine("Loading parser: {0}", fileName);

            try
            {
                string[] lines = File.ReadAllLines(path);

                // Put each non-terminal on the line in the list.
                // Non-terminals are on the first line in the text file.
                string[] nterms = lines[0].Split(' ');
                for (int i = 0; i < nterms.Length; i++)
                    this.nterm.Add(nterms[i]);

                // Put each terminal on the line in the list.
                // Terminals are on the second line in the text file.
                string[] terms = lines[1].Split(' ');
                for (int i = 0; i < terms.Length; i++)
                    this.term.Add(terms[i]);

                rules = relatedGrammar.Entries;

                Console.WriteLine("Parser loaded: " + fileName);
            }
            catch (IOException)
            {
                Console.WriteLine("File not found: {0}. Parser not loaded.", fileName);
            }
        }

        public void Update()
        {
            rules = relatedGrammar.Entries;
        }

        public string Languages
        {
            get { return sourceLanguage; }
        }
    }
}