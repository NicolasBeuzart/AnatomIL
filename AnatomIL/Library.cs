using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnatomIL
{
    public class Library
    {
        Dictionary<string, OpCodeRoot> _library;

        public Library()
        {
            _library = new Dictionary<string, OpCodeRoot>();
            
        }

        public void LibAddCodeOpRoot(OpCodeRoot methode)
        {
            _library.Add(methode.Name, methode);
        }

        public bool LibIsCodeOpRootExiste(string name)
        {
            bool result = _library.ContainsKey(name);
            return (result);
        }

        public OpCodeRoot LibFindOpCodeRoot(string name)
        {
            return (_library[name]);
        }
    }
}
