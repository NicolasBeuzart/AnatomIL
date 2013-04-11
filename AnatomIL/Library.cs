using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnatomIL
{
    public class Library
    {
        Dictionary<string, CodeOpRoot> _library;

        public Library()
        {
            _library = new Dictionary<string, CodeOpRoot>();
            
        }

        public void LibAddOpCodeRoot(CodeOpRoot methode)
        {
            _library.Add(methode.Name, methode);
        }

        public bool LibIsOpCodeRootExiste(string name)
        {
            bool result = _library.ContainsKey(name);
            return (result);
        }

        public CodeOpRoot LibFindOpCodeRoot(string name)
        {
            return (_library[name]);
        }
    }
}
