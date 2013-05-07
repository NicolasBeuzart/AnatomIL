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
        internal string _type;

        public OpCode()
        {

        }

        public string Type { get { return _type; } }
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
            base._type = "operation";
        }

        override public void Execute(Environment e)
        {
            _t = e.Stack.CurrentStack[e.Stack.Count - 1].Type;
            if (_t != e.Stack.CurrentStack[e.Stack.Count - 2].Type)
            {
                throw new InvalidOperationException("can't add two values using different type");
            }

            StackItemValue StV1;
            StackItemValue StV2;

            if (e.Stack.Pop(out StV1) && e.Stack.Pop(out StV2))
            {
                if (_t == typeof(Int64))
                {
                    Int64 i1 = Convert.ToInt64(StV1.Value);
                    Int64 i2 = Convert.ToInt64(StV2.Value);
                    e.Stack.Push(_t, i1 + i2);
                }
                else if (_t == typeof(Int32))
                {
                    Int32 i1 = Convert.ToInt32(StV1.Value);
                    Int32 i2 = Convert.ToInt32(StV2.Value);
                    e.Stack.Push(_t, i1 + i2);
                }
                else if (_t == typeof(Int16))
                {
                    Int16 i1 = Convert.ToInt16(StV1.Value);
                    Int16 i2 = Convert.ToInt16(StV2.Value);
                    e.Stack.Push(_t, i1 + i2);
                }
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
            base._type = "operation";
        }

        override public void Execute(Environment e)
        {
            _t = e.Stack.CurrentStack[e.Stack.Count - 1].Type;
            if (_t != e.Stack.CurrentStack[e.Stack.Count - 2].Type)
            {
                throw new InvalidOperationException("can't add two values using different type");
            }

            StackItemValue StV1;
            StackItemValue StV2;

            if (e.Stack.Pop(out StV1) && e.Stack.Pop(out StV2))
            {
                if (_t == typeof(Int64))
                {
                    Int64 i1 = Convert.ToInt64(StV1.Value);
                    Int64 i2 = Convert.ToInt64(StV2.Value);
                    e.Stack.Push(_t, i1 - i2);
                }
                else if (_t == typeof(Int32))
                {
                    Int32 i1 = Convert.ToInt32(StV1.Value);
                    Int32 i2 = Convert.ToInt32(StV2.Value);
                    e.Stack.Push(_t, i1 - i2);
                }
                else if (_t == typeof(Int16))
                {
                    Int16 i1 = Convert.ToInt16(StV1.Value);
                    Int16 i2 = Convert.ToInt16(StV2.Value);
                    e.Stack.Push(_t, i1 - i2);
                }
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
            base._type = "operation";
        }

        override public void Execute(Environment e)
        {
            _t = e.Stack.CurrentStack[e.Stack.Count - 1].Type;
            if (_t != e.Stack.CurrentStack[e.Stack.Count - 2].Type)
            {
                throw new InvalidOperationException("can't add two values using different type");
            }

            StackItemValue StV1;
            StackItemValue StV2;

            if (e.Stack.Pop(out StV1) && e.Stack.Pop(out StV2))
            {
                if (_t == typeof(Int64))
                {
                    Int64 i1 = Convert.ToInt64(StV1.Value);
                    Int64 i2 = Convert.ToInt64(StV2.Value);
                    e.Stack.Push(_t, i1 * i2);
                }
                else if (_t == typeof(Int32))
                {
                    Int32 i1 = Convert.ToInt32(StV1.Value);
                    Int32 i2 = Convert.ToInt32(StV2.Value);
                    e.Stack.Push(_t, i1 * i2);
                }
                else if (_t == typeof(Int16))
                {
                    Int16 i1 = Convert.ToInt16(StV1.Value);
                    Int16 i2 = Convert.ToInt16(StV2.Value);
                    e.Stack.Push(_t, i1 * i2);
                }
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
            base._type = "operation";
        }

        override public void Execute(Environment e)
        {
            _t = e.Stack.CurrentStack[e.Stack.Count - 1].Type;
            if (_t != e.Stack.CurrentStack[e.Stack.Count - 2].Type)
            {
                throw new InvalidOperationException("can't add two values using different type");
            }

            StackItemValue StV1;
            StackItemValue StV2;

            if (e.Stack.Pop(out StV1) && e.Stack.Pop(out StV2))
            {
                if (_t == typeof(Int64))
                {
                    Int64 i1 = Convert.ToInt64(StV1.Value);
                    Int64 i2 = Convert.ToInt64(StV2.Value);
                    e.Stack.Push(_t, i1 / i2);
                }
                else if (_t == typeof(Int32))
                {
                    Int32 i1 = Convert.ToInt32(StV1.Value);
                    Int32 i2 = Convert.ToInt32(StV2.Value);
                    e.Stack.Push(_t, i1 / i2);
                }
                else if (_t == typeof(Int16))
                {
                    Int16 i1 = Convert.ToInt16(StV1.Value);
                    Int16 i2 = Convert.ToInt16(StV2.Value);
                    e.Stack.Push(_t, i1 / i2);
                }
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
            base._type = "operation";
        }

        override public void Execute(Environment e)
        {
            _t = e.Stack.CurrentStack[e.Stack.Count - 1].Type;
            if (_t != e.Stack.CurrentStack[e.Stack.Count - 2].Type)
            {
                throw new InvalidOperationException("can't add two values using different type");
            }

            StackItemValue StV1;
            StackItemValue StV2;

            if (e.Stack.Pop(out StV1) && e.Stack.Pop(out StV2))
            {
                if (_t == typeof(Int64))
                {
                    Int64 i1 = Convert.ToInt64(StV1.Value);
                    Int64 i2 = Convert.ToInt64(StV2.Value);
                    e.Stack.Push(_t, i1 % i2);
                }
                else if (_t == typeof(Int32))
                {
                    Int32 i1 = Convert.ToInt32(StV1.Value);
                    Int32 i2 = Convert.ToInt32(StV2.Value);
                    e.Stack.Push(_t, i1 % i2);
                }
                else if (_t == typeof(Int16))
                {
                    Int16 i1 = Convert.ToInt16(StV1.Value);
                    Int16 i2 = Convert.ToInt16(StV2.Value);
                    e.Stack.Push(_t, i1 % i2);
                }
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
            base._type = "operation";
            _t = t;
            _value = value;
            base._executable = true;
        }

        override public void Execute(Environment e)
        {
            e.Stack.Push(_t, _value);
        }
    }

    

    public class LabelOpCode : OpCode
    {
        string _label;

        public string Label { get { return _label; } }

        public LabelOpCode(string label)
        {
            base._name = label;
            base._executable = false;
            base._type = "label";
            _label = label;
        }
    }

    public class LocalsInitOpCode : OpCode
    {
        List<string> _locals;
        List<StackItemValue> _stv = new List<StackItemValue>();


        public LocalsInitOpCode(List<string> locals)
        {
            base._name = "localsInit";
            base._type = "directive";
            _locals = locals;
            base._executable = true;
        }

        override public void Execute(Environment e)
        {
            for (int i = 0; i < _locals.Count(); i++)
            {
                if (_locals[i] == "int16") _stv.Add(new StackItemValue(typeof(Int16), 0));
                else if (_locals[i] == "int32") _stv.Add(new StackItemValue(typeof(Int32), 0));
                else if (_locals[i] == "int64") _stv.Add(new StackItemValue(typeof(Int64), 0));
                else if (_locals[i] == "bool") _stv.Add(new StackItemValue(typeof(bool), 0));

                StackItemFrame s = e.Stack.CurentStackItemFrame();
                s.VarLocals = _stv;
            }

        }
    }

    public class DupOpCode : OpCode
    {
        public DupOpCode()
        {
            base._name = "dup";
            base._type = "operation";
            base._executable = true;
        }

        override public void Execute(Environment e)
        {
           StackItemValue s;
           if (e.Stack.Pop(out s))
           {
               e.Stack.Push(s.Type, s.Value);
               e.Stack.Push(s.Type, s.Value);
           }
        }
    }
}
