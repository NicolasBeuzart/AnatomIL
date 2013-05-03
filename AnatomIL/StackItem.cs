using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnatomIL
{
    public class StackItem
    {
        public Type Type;
        public object Value;

        public StackItem(Type t, object o)
        {
            Type = t;
            Value = o;
        }
    }

    public class StackItemFrame : StackItem
    {



    }
}
