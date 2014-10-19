using Translate.Translators;
using Translate.Translators.Utilities;

namespace Translate
{
    public class TranslateMain
    {
        public static TranslatorObjectList translatorObjectList;

        public TranslateMain()
        {
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