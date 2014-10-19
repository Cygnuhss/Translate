using System;
namespace Translate.Translators.Utilities
{
    public abstract class TranslatorObject
    {
        protected string id;
        protected TranslatorObject parent;

        public TranslatorObject(string id = "")
        {
            this.id = id;
        }

        public TranslatorObject Root
        {
            get
            {
                if (parent != null)
                    return parent.Root;
                else
                    return this;
            }
        }

        public virtual TranslatorObject Parent
        {
            get { return parent; }
            set { parent = value; }
        }

        public string ID
        {
            get { return id; }
        }
    }
}