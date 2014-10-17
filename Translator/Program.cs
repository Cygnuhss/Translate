using System;

namespace Translate
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Run the translator main.
            TranslateMain translateMain = new TranslateMain();
        }
    }
}