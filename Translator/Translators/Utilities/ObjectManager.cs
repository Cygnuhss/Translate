using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Translate.Translators.Utilities
{
    class ObjectManager : List<Object>
    {
        IList<Object> objects;

        public ObjectManager()
        {
            objects = new List<Object>();
        }

        public void Add(Object obj)
        {
            this.objects.Add(obj);
        }

        public void Remove(Object obj)
        {
            this.objects.Remove(obj);
        }

        public void RemoveAll()
        {
            this.objects = new List<Object>();
        }
    }
}
