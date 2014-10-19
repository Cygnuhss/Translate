using System.Collections.Generic;

namespace Translate.Translators.Utilities
{
    public class TranslatorObjectList : TranslatorObject
    {
        protected IList<TranslatorObject> translatorObjects;

        public TranslatorObjectList(string id = "")
            : base(id)
        {
            translatorObjects = new List<TranslatorObject>();
        }

        public void Add(TranslatorObject obj)
        {
            obj.Parent = this;
            translatorObjects.Add(obj);
        }

        public void Remove(TranslatorObject obj)
        {
            translatorObjects.Remove(obj);
            obj.Parent = null;
        }

        public TranslatorObject Find(string id)
        {
            foreach (TranslatorObject obj in translatorObjects)
            {
                if (obj.ID == id)
                    return obj;
                if (obj is TranslatorObjectList)
                {
                    TranslatorObjectList objlist = obj as TranslatorObjectList;
                    TranslatorObject subobj = objlist.Find(id);
                    if (subobj != null)
                        return subobj;
                }
            }
            return null;
        }

        public IList<TranslatorObject> Objects
        {
            get { return translatorObjects; }
        }
    }
}