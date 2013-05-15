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
        internal int _line;

        public OpCode()
        {

        }

        public string Type { get { return _type; } }
        public bool IsExecutable { get { return _executable; } }
        public int Line { get { return _line; } }

        public string Name
        {
            get { return (_name); }
        }

        virtual public void Execute(Environment e) { } // méthode d'éxécution des opérations
    }

    public class AddOpCode : OpCode
    {
        Type _t;

        public AddOpCode(int line)
        {
            _line = line;
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

        public SubOpCode(int line)
        {
            _line = line;
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

        public MulOpCode(int line)
        {
            _line = line;
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

        public DivOpCode(int line)
        {
            _line = line;
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

        public RemOpCode(int line)
        {
            _line = line;
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

        public LdcOpCode(Type t, object value, int line)
        {
            _line = line;
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

        public LabelOpCode(string label, int line)
        {
            _line = line;
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


        public LocalsInitOpCode(List<string> locals, int line)
        {
            _line = line;
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
        public DupOpCode(int line)
        {
            _line = line;
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

    public class stlocOpCode : OpCode
    {
        internal int _localidx;

        public stlocOpCode(int i, int line)
        {
            _line = line;
            base._name = "stloc";
            base._type = "operation";
            base._executable = true;
            _localidx = i;
        }

        override public void Execute(Environment e)
        {
            StackItemValue siv;
            if (e.Stack.Pop(out siv))
            {
                StackItemFrame sif = e.Stack.CurentStackItemFrame();
                sif.VarLocals[_localidx] = siv;
            }
        }

    }

    public class ldlocOpCode : OpCode
    {
        internal int _localidx;

        public ldlocOpCode(int i, int line)
        {
            _line = line;
            base._name = "ldloc";
            base._type = "operation";
            base._executable = true;
            _localidx = i;
        }

        override public void Execute(Environment e)
        {
            StackItemFrame sif = e.Stack.CurentStackItemFrame();
            if (_localidx < sif.VarLocals.Count)
            {
                e.Stack.Push(sif.VarLocals[_localidx].Type, sif.VarLocals[_localidx].Value);
            }
        }

    }

    public class PrototypeOpCode : OpCode
    {
        List<StackItemValue> _args;
        Type _type2;
        public PrototypeOpCode(string name, Type type, List<StackItemValue> args, int line)
        {
            _line = line;
            base._type = "directive";
            base._executable = true;
            _name = name;
            _type2 = type;
            _args = args;
        }

        override public void Execute(Environment e)
        {
            e.Stack.CurentStackItemFrame().VarLocals = _args;
            e.Stack.CurentStackItemFrame().RetType = _type2;
            e.Stack.CurentStackItemFrame().FrameName = _name;
        }

    }

    public class CallOpCode : OpCode
    {
        string _name2;
        List<StackItemValue> _args;

        public CallOpCode(string name,List<StackItemValue> args, int line)
        {
            _line = line;
            base._name = "prototype";
            base._type = "operation";
            base._executable = true;
            _name2 = name;
            _args = args;
        }

        override public void Execute(Environment e)
        {
            e.Stack.CurentStackItemFrame().Line = _line;
            foreach (OpCode o in e.CompiledCode.Code)
            {
                if (o != null && o.Name == _name2) e.Pc = o.Line - 1;
            }

            e.Stack.PushFrame(_args, new List<StackItemValue>(), null, null);
        }
    }

    public class RetOpCode : OpCode
    {
        public RetOpCode(int line)
        {
            _line = line;
            base._name = "ret";
            base._type = "operation";
            base._executable = true;
        }

        public override void Execute(Environment e)
        {
            StackItemValue s;
            if (e.Stack.CurentStackItemFrame().FrameName == "main") e.Pc = e.CompiledCode.Count;
            else
            {
                if (e.Stack.CurentStackItemFrame().RetType != typeof(void))
                {
                    e.Stack.Pop(out s);
                    if (!e.Stack.PopFrame()) ;
                    e.Stack.Push(s.Type, s.Value);
                }
                else
                {
                    if (!e.Stack.PopFrame()) ;
                }
                e.Pc = e.Stack.CurentStackItemFrame().Line;
            }

        }
    }
}
