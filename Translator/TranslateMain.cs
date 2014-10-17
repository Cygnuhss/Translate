using System.Windows.Forms;
using Translate.Translators;
using Translate.Translators.Utilities;

namespace Translate
{
    public class TranslateMain
    {
        protected static TranslatorObjectList translatorObjectList;

        public TranslateMain()
        {
            // Start the GUI.
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TranslateGUI());

            // Create the object list.
            translatorObjectList = new TranslatorObjectList();
            // Create the translator manager.
            translatorObjectList.Add(new TranslatorManager("translatorManager"));
        }

        public static TranslatorObjectList TranslatorObjectList
        {
            get { return translatorObjectList; }
        }
    }
}