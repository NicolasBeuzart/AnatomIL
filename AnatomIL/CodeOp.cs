using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnatomIL
{
    public class OpCode // classe "père" de tout les CodeOp
    {
        internal string _name;
        internal bool _executable;

        public OpCode()
        {

        }

        public bool IsExecutable { get { return _executable; } }

        public string Name
        {
            get { return (_name); }
        }

        virtual public void Execute(Environment e) { } // méthode d'éxécution des opérations
    }

    public class AddOpCode : OpCode
    {
        Type _t;

        public AddOpCode()
        {
            base._name = "add";
            base._executable = true;
        }

        override public void Execute(Environment e)
        {
            _t = e.Stack.CurrentStack[e.Stack.Count - 1].Type;
            if (_t != e.Stack.CurrentStack[e.Stack.Count - 2].Type)
            {
                throw new InvalidOperationException("can't add two values using different type");
            }

            if (_t == typeof(Int64))
            {
                Int64 i1 = Convert.ToInt64(e.Stack.Pop().Value);
                Int64 i2 = Convert.ToInt64(e.Stack.Pop().Value);
                e.Stack.Push(_t, i1 + i2);
            }
            else if (_t == typeof(Int32))
            {
                Int32 i1 = Convert.ToInt32(e.Stack.Pop().Value);
                Int32 i2 = Convert.ToInt32(e.Stack.Pop().Value);
                e.Stack.Push(_t, i1 + i2);
            }
            else if (_t == typeof(Int16))
            {
                Int16 i1 = Convert.ToInt16(e.Stack.Pop().Value);
                Int16 i2 = Convert.ToInt16(e.Stack.Pop().Value);
                e.Stack.Push(_t, i1 + i2);
            }
        }
    }

    public class SubOpCode : OpCode
    {
         Type _t;

        public SubOpCode()
        {
            base._name = "sub";
            base._executable = true;
        }

        override public void Execute(Environment e)
        {
            _t = e.Stack.CurrentStack[e.Stack.Count - 1].Type;
            if (_t != e.Stack.CurrentStack[e.Stack.Count - 2].Type)
            {
                throw new InvalidOperationException("can't add two values using different type");
            }

            if (_t == typeof(Int64))
            {
                Int64 i1 = Convert.ToInt64(e.Stack.Pop().Value);
                Int64 i2 = Convert.ToInt64(e.Stack.Pop().Value);
                e.Stack.Push(_t, i1 - i2);
            }
            else if (_t == typeof(Int32))
            {
                Int32 i1 = Convert.ToInt32(e.Stack.Pop().Value);
                Int32 i2 = Convert.ToInt32(e.Stack.Pop().Value);
                e.Stack.Push(_t, i1 - i2);
            }
            else if (_t == typeof(Int16))
            {
                Int16 i1 = Convert.ToInt16(e.Stack.Pop().Value);
                Int16 i2 = Convert.ToInt16(e.Stack.Pop().Value);
                e.Stack.Push(_t, i1 - i2);
            }
        }
    }

    public class MulOpCode : OpCode
    {
        Type _t;

        public MulOpCode()
        {
            base._name = "mul";
            base._executable = true;
        }

        override public void Execute(Environment e)
        {
            _t = e.Stack.CurrentStack[e.Stack.Count - 1].Type;
            if (_t != e.Stack.CurrentStack[e.Stack.Count - 2].Type)
            {
                throw new InvalidOperationException("can't add two values using different type");
            }

            if (_t == typeof(Int64))
            {
                Int64 i1 = Convert.ToInt64(e.Stack.Pop().Value);
                Int64 i2 = Convert.ToInt64(e.Stack.Pop().Value);
                e.Stack.Push(_t, i1 * i2);
            }
            else if (_t == typeof(Int32))
            {
                Int32 i1 = Convert.ToInt32(e.Stack.Pop().Value);
                Int32 i2 = Convert.ToInt32(e.Stack.Pop().Value);
                e.Stack.Push(_t, i1 * i2);
            }
            else if (_t == typeof(Int16))
            {
                Int16 i1 = Convert.ToInt16(e.Stack.Pop().Value);
                Int16 i2 = Convert.ToInt16(e.Stack.Pop().Value);
                e.Stack.Push(_t, i1 * i2);
            }
        }
    }

    public class DivOpCode : OpCode
    {
        Type _t;

        public DivOpCode()
        {
            base._name = "div";
            base._executable = true;
        }

        override public void Execute(Environment e)
        {
            _t = e.Stack.CurrentStack[e.Stack.Count - 1].Type;
            if (_t != e.Stack.CurrentStack[e.Stack.Count - 2].Type)
            {
                throw new InvalidOperationException("can't add two values using different type");
            }

            if (_t == typeof(Int64))
            {
                Int64 i1 = Convert.ToInt64(e.Stack.Pop().Value);
                Int64 i2 = Convert.ToInt64(e.Stack.Pop().Value);
                e.Stack.Push(_t, i1 / i2);
            }
            else if (_t == typeof(Int32))
            {
                Int32 i1 = Convert.ToInt32(e.Stack.Pop().Value);
                Int32 i2 = Convert.ToInt32(e.Stack.Pop().Value);
                e.Stack.Push(_t, i1 / i2);
            }
            else if (_t == typeof(Int16))
            {
                Int16 i1 = Convert.ToInt16(e.Stack.Pop().Value);
                Int16 i2 = Convert.ToInt16(e.Stack.Pop().Value);
                e.Stack.Push(_t, i1 / i2);
            }
        }
    }

    public class RemOpCode : OpCode
    {
        Type _t;

        public RemOpCode()
        {
            base._name = "rem";
            base._executable = true;
        }

        override public void Execute(Environment e)
        {
            _t = e.Stack.CurrentStack[e.Stack.Count - 1].Type;
            if (_t != e.Stack.CurrentStack[e.Stack.Count - 2].Type)
            {
                throw new InvalidOperationException("can't add two values using different type");
            }

            if (_t == typeof(Int64))
            {
                Int64 i1 = Convert.ToInt64(e.Stack.Pop().Value);
                Int64 i2 = Convert.ToInt64(e.Stack.Pop().Value);
                e.Stack.Push(_t, i1 % i2);
            }
            else if (_t == typeof(Int32))
            {
                Int32 i1 = Convert.ToInt32(e.Stack.Pop().Value);
                Int32 i2 = Convert.ToInt32(e.Stack.Pop().Value);
                e.Stack.Push(_t, i1 % i2);
            }
            else if (_t == typeof(Int16))
            {
                Int16 i1 = Convert.ToInt16(e.Stack.Pop().Value);
                Int16 i2 = Convert.ToInt16(e.Stack.Pop().Value);
                e.Stack.Push(_t, i1 % i2);
            }
        }
    }

    public class LdcOpCode : OpCode
    {
        Type _t;
        object _value;

        public LdcOpCode(Type t, object value)
        {
            base._name = "ldc";
            _t = t;
            _value = value;
            base._executable = true;
        }

        override public void Execute(Environment e)
        {
            e.Stack.Push(_t, _value);
        }
    }

    public class BrOpCode : OpCode
    {
        string _label;

        public BrOpCode(string label)
        {
            base._name = "br";
            _label = label;
            base._executable = true;
        }

        public override void Execute(Environment e)
        {
           e.Pc = e.CompiledCode.IndexLabel(_label);
        }
    }

    public class LabelOpCode : OpCode
    {
        string _label;

        public string Label { get { return _label; } }

        public LabelOpCode(string label)
        {
            base._name = "br";
            base._executable = false;
            _label = label;
        }
    }
}
