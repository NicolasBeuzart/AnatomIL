using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnatomIL
{
    public class StackItem
    {
        Type _t;
        object _value;

        public object Value
        {
            get { return _value; }
        }

        public Type Type
        {
            get { return _t; }
        }

        public StackItem(Type t, object Value)
        {
            _t = t;
            _value = Value;
        }
    }
}
