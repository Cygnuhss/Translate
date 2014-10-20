﻿using System;
using Translate.Translators.Dictionaries;
using Translate.Translators.Grammars;
using Translate.Translators.Utilities;

namespace Translate.Translators
{
    class Translator : TranslatorObject
    {
        protected string sourceLanguage;
        protected string targetLanguage;

        DictionaryManager dictionaries;
        GrammarManager grammars;

        public Translator(string sourceLanguage, string targetLanguage, string id = "")
            : base(id)
        {
            this.sourceLanguage = sourceLanguage;
            this.targetLanguage = targetLanguage;

            dictionaries = new DictionaryManager();
            grammars = new GrammarManager();

            // Adding back and forth dictionaries.
            this.dictionaries.Add(new Dictionary(sourceLanguage, targetLanguage, sourceLanguage + '_' + targetLanguage));
            this.dictionaries.Add(new Dictionary(targetLanguage, sourceLanguage, targetLanguage + '_' + sourceLanguage));

            // Adding back and forth grammars.
            this.grammars.Add(new Grammar(sourceLanguage, sourceLanguage, sourceLanguage + '_' + targetLanguage));
            this.grammars.Add(new Grammar(targetLanguage, targetLanguage, targetLanguage + '_' + sourceLanguage));

            Load();
        }

        public void Load()
        {
            // Loading the dictionaries and grammars.
            foreach (Dictionary d in dictionaries.Objects)
                d.Load();
            foreach (Grammar g in grammars.Objects)
                g.Load();
        }

        public void Update()
        {
            // Updating the dictionaries and grammars.
            foreach (Dictionary d in dictionaries.Objects)
                d.Update();
            foreach (Grammar g in grammars.Objects)
                g.Update();
        }

        public string Translate(string inputText)
        {
            // Translate the input.
            // Takes an input as string and outputs the translation as a string.
            // This translation is very basic, it translates every single word to its dictionary pair.
            string outputText = "";
            string[] s = inputText.Split(' ');

            Dictionary d = dictionaries.Find(sourceLanguage + "_" + targetLanguage) as Dictionary;
            for (int w = 0; w < s.Length; w++)
                foreach (Tuple<string, string> entry in d.Entries)
                {
                    if (entry.Item1 == s[w])
                        outputText += entry.Item2 + ' ';
                    else
                    {
                        outputText += string.Format("[NOT TRANSLATED: {0}]", s[w]);
                        Console.WriteLine("Word not translated: {0}. The word is probably not in the dictionary.", s[w]);
                    }
                }

            // Output text with uppercase starting character and added period at the end.
            return char.ToUpper(outputText[0]) + outputText.Substring(1, outputText.Length - 1) + '.';
        }

        public Tuple<string, string> Languages
        {
            get { return new Tuple<string, string>(sourceLanguage, targetLanguage); }
        }

        public DictionaryManager DictionaryManager
        {
            get { return dictionaries; }
        }

        public GrammarManager GrammarManager
        {
            get { return grammars; }
        }
    }
}