using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnatomIL
{
    public class CodeOp // classe "père" de tout les CodeOp
    {
        internal string _name;

        public CodeOp()
        {

        }

        public string Name
        {
            get { return (_name); }
        }

        virtual public void Execute(Stack s) { } // méthode d'éxécution des opérations
    }

    public class AddCodeOp : CodeOp
    {
        Type _t;

        public AddCodeOp(Type t)
        {
            base._name = "add";
            _t = t;
        }

        override public void Execute(Stack s)
        {
            if (_t == typeof(Int64))
            {
                Int64 i1 = Convert.ToInt64(s.Pop().Value);
                Int64 i2 = Convert.ToInt64(s.Pop().Value);
                s.Push(_t, i1 + i2);
            }
            else if (_t == typeof(Int32))
            {
                Int32 i1 = Convert.ToInt32(s.Pop().Value);
                Int32 i2 = Convert.ToInt32(s.Pop().Value);
                s.Push(_t, i1 + i2);
            }
            else if (_t == typeof(Int16))
            {
                Int16 i1 = Convert.ToInt16(s.Pop().Value);
                Int16 i2 = Convert.ToInt16(s.Pop().Value);
                s.Push(_t, i1 + i2);
            }
        }
    }

    public class SubCodeOp : CodeOp
    {
         Type _t;

        public SubCodeOp(Type t)
        {
            base._name = "sub";
            _t = t;
        }

        override public void Execute(Stack s)
        {
            if (_t == typeof(Int64))
            {
                Int64 i1 = Convert.ToInt32(s.Pop().Value);
                Int64 i2 = Convert.ToInt32(s.Pop().Value);
                s.Push(_t, i1 - i2);
            }
            else if (_t == typeof(Int32))
            {
                Int32 i1 = Convert.ToInt32(s.Pop().Value);
                Int32 i2 = Convert.ToInt32(s.Pop().Value);
                s.Push(_t, i1 - i2);
            }
            else if (_t == typeof(Int16))
            {
                Int16 i1 = Convert.ToInt16(s.Pop().Value);
                Int16 i2 = Convert.ToInt16(s.Pop().Value);
                s.Push(_t, i1 - i2);
            }
        }
    }

    public class MulCodeOp : CodeOp
    {
        Type _t;

        public MulCodeOp(Type t)
        {
            base._name = "sub";
            _t = t;
        }

        override public void Execute(Stack s)
        {
            if (_t == typeof(Int64))
            {
                Int64 i1 = Convert.ToInt32(s.Pop().Value);
                Int64 i2 = Convert.ToInt32(s.Pop().Value);
                s.Push(_t, i1 * i2);
            }
            else if (_t == typeof(Int32))
            {
                Int32 i1 = Convert.ToInt32(s.Pop().Value);
                Int32 i2 = Convert.ToInt32(s.Pop().Value);
                s.Push(_t, i1 * i2);
            }
            else if (_t == typeof(Int16))
            {
                Int16 i1 = Convert.ToInt16(s.Pop().Value);
                Int16 i2 = Convert.ToInt16(s.Pop().Value);
                s.Push(_t, i1 * i2);
            }
        }
    }

    public class DivCodeOp : CodeOp
    {
        Type _t;

        public DivCodeOp(Type t)
        {
            base._name = "sub";
            _t = t;
        }

        override public void Execute(Stack s)
        {
            if (_t == typeof(Int64))
            {
                Int64 i1 = Convert.ToInt32(s.Pop().Value);
                Int64 i2 = Convert.ToInt32(s.Pop().Value);
                s.Push(_t, i1 / i2);
            }
            else if (_t == typeof(Int32))
            {
                Int32 i1 = Convert.ToInt32(s.Pop().Value);
                Int32 i2 = Convert.ToInt32(s.Pop().Value);
                s.Push(_t, i1 / i2);
            }
            else if (_t == typeof(Int16))
            {
                Int16 i1 = Convert.ToInt16(s.Pop().Value);
                Int16 i2 = Convert.ToInt16(s.Pop().Value);
                s.Push(_t, i1 / i2);
            }
        }
    }

    public class RemCodeOp : CodeOp
    {
        Type _t;

        public RemCodeOp(Type t)
        {
            base._name = "sub";
            _t = t;
        }

        override public void Execute(Stack s)
        {
            if (_t == typeof(Int64))
            {
                Int64 i1 = Convert.ToInt32(s.Pop().Value);
                Int64 i2 = Convert.ToInt32(s.Pop().Value);
                s.Push(_t, i1 % i2);
            }
            else if (_t == typeof(Int32))
            {
                Int32 i1 = Convert.ToInt32(s.Pop().Value);
                Int32 i2 = Convert.ToInt32(s.Pop().Value);
                s.Push(_t, i1 % i2);
            }
            else if (_t == typeof(Int16))
            {
                Int16 i1 = Convert.ToInt16(s.Pop().Value);
                Int16 i2 = Convert.ToInt16(s.Pop().Value);
                s.Push(_t, i1 % i2);
            }
        }
    }

    public class LdcCodeOp : CodeOp
    {
        Type _t;
        object _value;

        public LdcCodeOp(Type t, object value)
        {
            _t = t;
            _value = value;
        }

        override public void Execute(Stack s)
        {
            s.Push(_t, _value);
        }
    }
}
