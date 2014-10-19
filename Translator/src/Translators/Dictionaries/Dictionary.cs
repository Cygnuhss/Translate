using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Translate.Translators.Utilities;

namespace Translate.Translators.Dictionaries
{
    class Dictionary : TranslatorObject
    {
        protected string sourceLanguage;
        protected string targetLanguage;

        // A dictionary is a list of tuples containing the word in the source language
        // as a string and the translation of it in the target language as a string.
        IList<Tuple<string, string>> entries = new List<Tuple<string, string>>();

        public Dictionary(string sourceLanguage, string targetLanguage, string id = "")
            : base(id)
        {
            this.sourceLanguage = sourceLanguage;
            this.targetLanguage = targetLanguage;
            
            Load();
        }

        public void Load()
        {
            string fileName = "dict_" + sourceLanguage + "_" + targetLanguage + ".txt";
            string cd = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string path = Path.Combine(cd, @"res\Dictionaries", fileName);
            string[] lines = File.ReadAllLines(path);

            Console.WriteLine("Loading dictionary: " + fileName);
            foreach (string line in lines)
            {
                string[] pair = line.Split('\t');
                this.entries.Add(new Tuple<string, string>(pair[0], pair[1]));
            }
            Console.WriteLine("Dictionary loaded: " + fileName);
        }

        public void Update()
        {
            string fileName = "dict_" + sourceLanguage + "_" + targetLanguage + ".txt";
            string cd = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string path = Path.Combine(cd, @"res\Dictionaries", fileName);

            Console.WriteLine("Updating dictionary: " + fileName);

            // Adding the entries in dictionary to the text file.
            string[] lines = File.ReadAllLines(path);
            int linesNr = lines.Length;
            int newLines = entries.Count - linesNr;
            if (newLines <= 0)
                return;

            // Appending each new entry to the text file.
            for (int i = newLines - 1; i < entries.Count; i++)
            {
                string sourceWord = entries[i].Item1;
                string targetWord = entries[i].Item2;
                AddEntry(sourceWord, targetWord, fileName, path);
            }

            Console.WriteLine("Dictionary updated: " + fileName);
        }

        public void AddEntry(string sourceWord, string targetWord, string fileName, string path)
        {
            string entry = sourceWord + '\t' + targetWord;

            Console.WriteLine("Adding entry: " + entry + " to dictionary " + fileName);

            using (StreamWriter w = File.AppendText(path))
                w.WriteLine(entry);

            Console.WriteLine("Entry added: " + entry + " to dictionary " + fileName);
        }

        public Tuple<string, string> Languages
        {
            get { return new Tuple<string, string>(sourceLanguage, targetLanguage); }
        }

        public IList<Tuple<string, string>> Entries
        {
            get { return entries; }
        }
    }
}