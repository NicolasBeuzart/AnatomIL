using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnatomIL
{
    public class StackItem
    {
        public List<StackItemValue> Args;
        public List<StackItemValue> VarLocals;
        public Type RetType;
        public string FrameName;

        public Type Type;
        public object Value;

        virtual public StackItemFrame Convert() { return null; }
    }

    public class StackItemFrame : StackItem
    {

        public StackItemFrame(List<StackItemValue> args, List<StackItemValue> vars, Type rt, string name)
        {
            Type = typeof(StackItemFrame);
            base.Args = args;
            VarLocals = vars;
            RetType = rt;
            FrameName = name;
        }

        public override StackItemFrame Convert()
        {
            return this;
        }

    }

    public class StackItemValue : StackItem
    {

        public StackItemValue(Type t, object o)
        {
            base.Type = t;
            base.Value = o;
        }

    }
}
