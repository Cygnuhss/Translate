using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Translate.Translators.Utilities;

namespace Translate.Translators.Grammars
{
    class Grammar : TranslatorObject
    {
        protected string sourceLanguage;

        protected string fileName;

        // A grammar is a list of strings containing the grammatical rules.
        IList<string[]> entries;

        public Grammar(string sourceLanguage, string id = "")
            : base(id)
        {
            this.sourceLanguage = sourceLanguage;

            entries = new List<string[]>();

            this.fileName = string.Format("gram_{0}.txt", sourceLanguage);
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
        }

        public void Update()
        {
            string cd = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string path = Path.Combine(cd, @"res\Grammars", fileName);

            Console.WriteLine("Updating grammar: {0}", fileName);

            int newLines = 1;
            try
            {
                // Adding the entries in grammar to the text file.
                string[] lines = File.ReadAllLines(path);
                int linesNr = lines.Length;
                newLines = entries.Count - linesNr;
            }
            catch (IOException)
            {
                Console.WriteLine("File not found: {0}. Grammar not updated.", fileName);
            }
            finally
            {
                // Appending each new entry to the text file.
                if (newLines > 0)
                    for (int i = newLines - 1; i < entries.Count; i++)
                    {
                        string[] rule = entries[i];
                        AddEntryToFile(rule, fileName, path);
                    }

                Console.WriteLine("Grammar updated: {0}", fileName);
            }
        }

        public void AddEntry(string rule)
        {
            this.entries.Add(rule.Split(' '));
        }

        public void AddEntry(string[] rule)
        {
            this.entries.Add(rule);
        }

        public void AddEntryToFile(string[] rule, string fileName, string path)
        {
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