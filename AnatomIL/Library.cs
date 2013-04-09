using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnatomIL
{
    public class Library
    {
        Dictionary<string, Methode> _library;

        public Library()
        {
            _library = new Dictionary<string, Methode>();
            
        }
        public void AddMethode(Methode methode)
        {
            _library.Add(methode.name, methode);
        }

        public bool IsMethodeExiste(string name)
        {
            bool result = _library.ContainsKey(name);
            return (result);
        }

        public Methode FoundMethode(string name)
        {
            return (_library[name]);
        }
    }
}
