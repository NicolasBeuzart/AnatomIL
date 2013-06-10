using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AnatomIL
{
    public class Library
    {
        Dictionary<string, OpCodeRoot> _library;
        public EnumManager EnumManager = new EnumManager();


        public Library()
        {
            _library = new Dictionary<string, OpCodeRoot>();
            EnumManager.Register(typeof(KnownColor), "Color");
        }

        public void LibAddCodeOpRoot(OpCodeRoot methode)
        {
            _library.Add(methode.Name, methode);
        }

        public void LoadInstructionLib()
        {
            this.LibAddCodeOpRoot(new AddOpCodeRoot());
            this.LibAddCodeOpRoot(new SubOpCodeRoot());
            this.LibAddCodeOpRoot(new MulOpCodeRoot());
            this.LibAddCodeOpRoot(new DivOpCodeRoot());
            this.LibAddCodeOpRoot(new RemOpCodeRoot());
            this.LibAddCodeOpRoot(new LdcOpCodeRoot(EnumManager));
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
            this.LibAddCodeOpRoot(new DupOpCodeRoot());
            this.LibAddCodeOpRoot(new stlocOpCodeRoot());
            this.LibAddCodeOpRoot(new ldlocOpCodeRoot());
            this.LibAddCodeOpRoot(new CallOpCodeRoot());
            this.LibAddCodeOpRoot(new stargOpCodeRoot());
            this.LibAddCodeOpRoot(new ldargOpCodeRoot());
            this.LibAddCodeOpRoot(new MoveToOpCodeRoot());
            this.LibAddCodeOpRoot(new LineToOpCodeRoot());
            this.LibAddCodeOpRoot(new EllipseToOpCodeRoot());
        }

        public void LoadDirectiveLib()
        {
            this.LibAddCodeOpRoot(new LocalsInitOpCodeRoot());
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
