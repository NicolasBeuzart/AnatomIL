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
        
    }

    public class StackItemFrame : StackItem
    {

        public StackItemFrame(List<StackItemValue> args, List<StackItemValue> vars, Type rt, string name)
        {
            Args = args;
            VarLocals = vars;
            RetType = rt;
            FrameName = name;
        }

    }

    public class StackItemValue : StackItem
    {

        public StackItemValue(Type t, object o)
        {
            Type = t;
            Value = o;
        }

    }
}
