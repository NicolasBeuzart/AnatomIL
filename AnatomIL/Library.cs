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
            this.LibAddCodeOpRoot(new AddOpCodeRoot());
            this.LibAddCodeOpRoot(new SubCodeOpRoot());
            this.LibAddCodeOpRoot(new MulCodeOpRoot());
            this.LibAddCodeOpRoot(new DivCodeOpRoot());
            this.LibAddCodeOpRoot(new RemCodeOpRoot());
            this.LibAddCodeOpRoot(new LdcCodeOpRoot());
            this.LibAddCodeOpRoot(new BrOpCodeRoot());
            this.LibAddCodeOpRoot(new LabelOpCodeRoot());
            this.LibAddCodeOpRoot(new BeqOpCodeRoot());
            this.LibAddCodeOpRoot(new BgeOpCodeRoot());
            this.LibAddCodeOpRoot(new BgtOpCodeRoot());
            this.LibAddCodeOpRoot(new BleOpCodeRoot());
            this.LibAddCodeOpRoot(new BltOpCodeRoot());
            this.LibAddCodeOpRoot(new BrfalseOpCodeRoot());
            this.LibAddCodeOpRoot(new BrtrueOpCodeRoot());
            this.LibAddCodeOpRoot(new BrzeroOpCodeRoot());
            this.LibAddCodeOpRoot(new BrnullOpCodeRoot());
            this.LibAddCodeOpRoot(new BrinstOpCodeRoot());
            this.LibAddCodeOpRoot(new LocalsInitOpCodeRoot());
            this.LibAddCodeOpRoot(new DupOpCodeRoot());
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
