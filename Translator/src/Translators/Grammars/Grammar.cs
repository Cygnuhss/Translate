using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Translate.Translators.Utilities;
using Translate.Translators.Grammars.Parsers;

namespace Translate.Translators.Grammars
{
    class Grammar : TranslatorObject
    {
        protected string sourceLanguage;
        protected string fileName;

        // A grammar is a list of strings containing the grammatical rules.
        IList<string[]> entries;
        Parser parser;

        public Grammar(string sourceLanguage, string id = "")
            : base(id)
        {
            this.sourceLanguage = sourceLanguage;

            // File name is of this format: gram_[sourcelanguage].txt
            this.fileName = string.Format("gram_{0}.txt", sourceLanguage);

            entries = new List<string[]>();
            Load();
            parser = new Parser(this);
        }

        public void Load()
        {
            string cd = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string path = Path.Combine(cd, @"res\Grammars", fileName);

            Console.WriteLine("Loading grammar: {0}", fileName);

            try
            {
                string[] lines = File.ReadAllLines(path);

                foreach (string line in lines)
                {
                    // Split the rules into multiple parts for easier handling.
                    string[] rule = line.Split(' ');
                    this.entries.Add(rule);
                }

                Console.WriteLine("Grammar loaded: " + fileName);
            }
            catch (IOException)
            {
                Console.WriteLine("File not found: {0}. Grammar not loaded.", fileName);
            }

            parser.Load();
        }

        public void Update()
        {
            string cd = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string path = Path.Combine(cd, @"res\Grammars", fileName);

            Console.WriteLine("Updating grammar: {0}", fileName);

            RemoveDuplicates();

            int newLines = entries.Count;
            try
            {
                // Adding the entries in grammar to the text file.
                string[] lines = File.ReadAllLines(path);
                newLines -= lines.Length;
            }
            catch (IOException)
            {
                Console.WriteLine("File not found: {0}. Grammar not updated.", fileName);
            }
            finally
            {
                // Appending each new entry to the text file.
                for (int i = entries.Count - newLines; i < entries.Count; i++)
                {
                    string[] rule = entries[i];
                    AddEntryToFile(rule, fileName, path);
                }

                Console.WriteLine("Grammar updated: {0}", fileName);
            }

            parser.Update();
        }

        public void RemoveDuplicates()
        {
            // Make sure that even though multiple identical entries might be added,
            // only one will remain.
            entries = new List<string[]>(new HashSet<string[]>(entries));
        }

        public void AddEntry(string rule)
        {
            // Add the entry to the list.
            this.entries.Add(rule.Split(' '));
        }

        public void AddEntry(string[] rule)
        {
            this.entries.Add(rule);
        }

        public void AddEntryToFile(string[] rule, string fileName, string path)
        {
            // Write all of the entries to the file.
            string entry = string.Join(" ", rule);

            Console.WriteLine("Adding entry: {0} to grammar {1}", entry, fileName);

            using (StreamWriter w = File.AppendText(path))
                w.WriteLine(entry);

            Console.WriteLine("Entry added: {0} to grammar {1}", entry, fileName);
        }

        public string Languages
        {
            get { return sourceLanguage; }
        }

        public IList<string[]> Entries
        {
            get { return entries; }
        }
    }
}