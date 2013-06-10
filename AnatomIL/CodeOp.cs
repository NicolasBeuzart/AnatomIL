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
        internal string _nameFrame = "";
        internal bool _executable;
        internal string _type;
        internal int _line;
        internal List<StackItemValue> _args;


        public OpCode()
        {

        }

        public List<StackItemValue> Args { get { return _args; } }
        public string Type { get { return _type; } }
        public bool IsExecutable { get { return _executable; } }
        public int Line { get { return _line; } }
        public string NameFrame { get { return (_nameFrame); } }
        public string Name { get { return (_name); } }

        virtual public OpCodeResult Execute(Environment e) { return null; } // méthode d'éxécution des opérations
    }

    public class AddOpCode : OpCode
    {

        public AddOpCode(int line)
        {
            _line = line;
            base._name = "add";
            base._executable = true;
            base._type = "operation";
        }

        override public OpCodeResult Execute(Environment e)
        {
            string errorMessage = "";

            StackItemValue StV1;
            StackItemValue StV2;

            if (e.Stack.Pop(out StV1) && e.Stack.Pop(out StV2))
            {
                Type t = StV1.Type;
                if (StV1.Type != StV2.Type) errorMessage = "can't add two values using different type line :" + (Line + 1);
                else if (t == typeof(Int64))
                {
                    Int64 i1 = Convert.ToInt64(StV1.Value);
                    Int64 i2 = Convert.ToInt64(StV2.Value);
                    e.Stack.Push(t, i1 + i2);
                }
                else if (t == typeof(Int32))
                {
                    Int32 i1 = Convert.ToInt32(StV1.Value);
                    Int32 i2 = Convert.ToInt32(StV2.Value);
                    e.Stack.Push(t, i1 + i2);
                }
                else if (t == typeof(Int16))
                {
                    Int16 i1 = Convert.ToInt16(StV1.Value);
                    Int16 i2 = Convert.ToInt16(StV2.Value);
                    e.Stack.Push(t, i1 + i2);
                }
            }
            else errorMessage = "Can't execute operation " + _name + " empty stack line :" + (_line + 1);
            return new OpCodeResult(errorMessage);
        }
    }

    public class SubOpCode : OpCode
    {

        public SubOpCode(int line)
        {
            _line = line;
            base._name = "sub";
            base._executable = true;
            base._type = "operation";
        }

        override public OpCodeResult Execute(Environment e)
        {
            string errorMessage = "";

            StackItemValue StV1;
            StackItemValue StV2;

            if (e.Stack.Pop(out StV1) && e.Stack.Pop(out StV2))
            {
                Type t = StV1.Type;
                if (StV1.Type != StV2.Type) errorMessage = "can't " + _name + " two values using different type line :" + (Line + 1);
                else if (t == typeof(Int64))
                {
                    Int64 i1 = Convert.ToInt64(StV1.Value);
                    Int64 i2 = Convert.ToInt64(StV2.Value);
                    e.Stack.Push(t, i1 - i2);
                }
                else if (t == typeof(Int32))
                {
                    Int32 i1 = Convert.ToInt32(StV1.Value);
                    Int32 i2 = Convert.ToInt32(StV2.Value);
                    e.Stack.Push(t, i1 - i2);
                }
                else if (t == typeof(Int16))
                {
                    Int16 i1 = Convert.ToInt16(StV1.Value);
                    Int16 i2 = Convert.ToInt16(StV2.Value);
                    e.Stack.Push(t, i1 - i2);
                }
            }
            else errorMessage = "Can't execute operation " + _name + " empty stack line :" + (_line + 1);
            return new OpCodeResult(errorMessage);
        }
    }

    public class MulOpCode : OpCode
    {

        public MulOpCode(int line)
        {
            _line = line;
            base._name = "mul";
            base._executable = true;
            base._type = "operation";
        }

        override public OpCodeResult Execute(Environment e)
        {
            string errorMessage = "";


            StackItemValue StV1;
            StackItemValue StV2;

            if (e.Stack.Pop(out StV1) && e.Stack.Pop(out StV2))
            {
                Type t = StV1.Type;
                if (StV1.Type != StV2.Type) errorMessage = "can't " + _name + " two values using different type line :" + (Line + 1);
                else if (t == typeof(Int64))
                {
                    Int64 i1 = Convert.ToInt64(StV1.Value);
                    Int64 i2 = Convert.ToInt64(StV2.Value);
                    e.Stack.Push(t, i1 * i2);
                }
                else if (t == typeof(Int32))
                {
                    Int32 i1 = Convert.ToInt32(StV1.Value);
                    Int32 i2 = Convert.ToInt32(StV2.Value);
                    e.Stack.Push(t, i1 * i2);
                }
                else if (t == typeof(Int16))
                {
                    Int16 i1 = Convert.ToInt16(StV1.Value);
                    Int16 i2 = Convert.ToInt16(StV2.Value);
                    e.Stack.Push(t, i1 * i2);
                }
            }
            else errorMessage = "Can't execute operation " + _name + " empty stack line :" + (_line + 1);
            return new OpCodeResult(errorMessage);
        }
    }

    public class DivOpCode : OpCode
    {

        public DivOpCode(int line)
        {
            _line = line;
            base._name = "div";
            base._executable = true;
            base._type = "operation";
        }

        override public OpCodeResult Execute(Environment e)
        {
            string errorMessage = "";
            StackItemValue StV1;
            StackItemValue StV2;

            if (e.Stack.Pop(out StV1) && e.Stack.Pop(out StV2))
            {
                Type t = StV1.Type;
                if (StV1.Type != StV2.Type) errorMessage = "can't " + _name + " two values using different type line :" + (Line + 1);
                else if (t == typeof(Int64))
                {
                    Int64 i1 = Convert.ToInt64(StV1.Value);
                    Int64 i2 = Convert.ToInt64(StV2.Value);
                    e.Stack.Push(t, i1 / i2);
                }
                else if (t == typeof(Int32))
                {
                    Int32 i1 = Convert.ToInt32(StV1.Value);
                    Int32 i2 = Convert.ToInt32(StV2.Value);
                    e.Stack.Push(t, i1 / i2);
                }
                else if (t == typeof(Int16))
                {
                    Int16 i1 = Convert.ToInt16(StV1.Value);
                    Int16 i2 = Convert.ToInt16(StV2.Value);
                    e.Stack.Push(t, i1 / i2);
                }
            }
            else errorMessage = "Can't execute operation " + _name + " empty stack line :" + (_line + 1);
            return new OpCodeResult(errorMessage);
        }
    }

    public class RemOpCode : OpCode
    {

        public RemOpCode(int line)
        {
            _line = line;
            base._name = "rem";
            base._executable = true;
            base._type = "operation";
        }

        override public OpCodeResult Execute(Environment e)
        {
            string errorMessage = "";

            StackItemValue StV1;
            StackItemValue StV2;

            if (e.Stack.Pop(out StV1) && e.Stack.Pop(out StV2))
            {
                Type t = StV1.Type;
                if (StV1.Type != StV2.Type) errorMessage = "can't " + _name + " two values using different type line :" + (Line + 1);
                else if (t == typeof(Int64))
                {
                    Int64 i1 = Convert.ToInt64(StV1.Value);
                    Int64 i2 = Convert.ToInt64(StV2.Value);
                    e.Stack.Push(t, i1 % i2);
                }
                else if (t == typeof(Int32))
                {
                    Int32 i1 = Convert.ToInt32(StV1.Value);
                    Int32 i2 = Convert.ToInt32(StV2.Value);
                    e.Stack.Push(t, i1 % i2);
                }
                else if (t == typeof(Int16))
                {
                    Int16 i1 = Convert.ToInt16(StV1.Value);
                    Int16 i2 = Convert.ToInt16(StV2.Value);
                    e.Stack.Push(t, i1 % i2);
                }
            }
            else errorMessage = "Can't execute operation " + _name + " empty stack line :" + (_line + 1);
            return new OpCodeResult(errorMessage);
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

        override public OpCodeResult Execute(Environment e)
        {
            string errorMessage = "";
            e.Stack.Push(_t, _value);
            return new OpCodeResult(errorMessage);
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
        List<StackItemValue> _siv = new List<StackItemValue>();


        public LocalsInitOpCode(List<string> locals, int line)
        {
            _line = line;
            base._name = "localsInit";
            base._type = "directive";
            _locals = locals;
            base._executable = true;
        }

        override public OpCodeResult Execute(Environment e)
        {
            string errorMessage = "";
            for (int i = 0; i < _locals.Count(); i++)
            {
                if (_locals[i] == "int16") _siv.Add(new StackItemValue(typeof(Int16), 0));
                else if (_locals[i] == "int32") _siv.Add(new StackItemValue(typeof(Int32), 0));
                else if (_locals[i] == "int64") _siv.Add(new StackItemValue(typeof(Int64), 0));
                else if (_locals[i] == "bool") _siv.Add(new StackItemValue(typeof(bool), 0));
                else errorMessage = "error line :" + (_line + 1);

                StackItemFrame s = e.Stack.CurentStackItemFrame();
                s.VarLocals = _siv;
            }
            return new OpCodeResult(errorMessage);
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

        override public OpCodeResult Execute(Environment e)
        {
            string errorMessage = "";
           StackItemValue s;
           if (e.Stack.Pop(out s))
           {
               e.Stack.Push(s.Type, s.Value);
               e.Stack.Push(s.Type, s.Value);
           }
           else errorMessage = "stack is empty can't execute the operation 'dup' in line :" + (_line + 1);
           return new OpCodeResult(errorMessage);
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

        override public OpCodeResult Execute(Environment e)
        {
            string errorMessage = "";
            StackItemValue siv;
            if (e.Stack.Pop(out siv))
            {
                StackItemFrame sif = e.Stack.CurentStackItemFrame();
                if (sif.VarLocals.Count <= _localidx) errorMessage = "local variable " + _localidx + " does not exist in function " + sif.FrameName + " line : " + (_line + 1);
                else sif.VarLocals[_localidx] = siv;
            }
            else errorMessage = "stack is empty can't execute the operation 'stloc' line :" + (_line + 1);
            return new OpCodeResult(errorMessage);
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

        override public OpCodeResult Execute(Environment e)
        {
            string errorMessage = "";
            StackItemFrame sif = e.Stack.CurentStackItemFrame();
            if (_localidx < sif.VarLocals.Count)
            {
                e.Stack.Push(sif.VarLocals[_localidx].Type, sif.VarLocals[_localidx].Value);
            }
            else errorMessage = "local variable " + _localidx + " does not exist in function " + sif.FrameName + " line : " + (_line + 1);
            return new OpCodeResult(errorMessage);
        }

    }

    public class PrototypeOpCode : OpCode
    {
        Type _typeFrame;

        public PrototypeOpCode(string name, Type type, List<StackItemValue> args, int line)
        {
            _line = line;
            base._type = "directive";
            base._executable = true;
            _name = "prototype";
            _nameFrame = name;
            _typeFrame = type;
            _args = args;
        }

        override public OpCodeResult Execute(Environment e)
        {
            string errorMessage = "";
            e.Stack.CurentStackItemFrame().RetType = _typeFrame;
            e.Stack.CurentStackItemFrame().FrameName = _nameFrame;
            return new OpCodeResult(errorMessage);
        }

    }

    public class CallOpCode : OpCode
    {
        string _target;
        public CallOpCode(string name, int line)
        {
            _line = line;
            base._name = "prototype";
            base._type = "operation";
            base._executable = true;
            _target = name;
        }

        override public OpCodeResult Execute(Environment e)
        {
            _args = new List<StackItemValue>();
            string errorMessage = "";
            e.Stack.CurentStackItemFrame().Line = _line;
            StackItemValue stv;

            foreach (OpCode o in e.CompiledCode.Code)
            {
                if (o != null && o.NameFrame == _target)
                {
                    e.Pc = o.Line - 1;
                    for (int i = o.Args.Count - 1; i >= 0; i--)
                    {
                        if (!e.Stack.Pop(out stv)) errorMessage = "stack is empty can't execute the operation 'call' line :" + (_line + 1);
                        else if (stv.Type != o.Args[i].Type) errorMessage = "Function " + _target + " excepted argument type of " + o.Args[i].Type.ToString() + " but given " + stv.Type.ToString() + " type line : " + (_line + 1);
                        else _args.Add(new StackItemValue(stv.Type, stv.Value));
                    }
                }
            }

            e.Stack.PushFrame(_args, new List<StackItemValue>(), null, _target);
            return new OpCodeResult(errorMessage);
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

        public override OpCodeResult Execute(Environment e)
        {
            string errorMessage = "";
            StackItemValue s;
            if (e.Stack.CurentStackItemFrame().FrameName == "main") e.Pc = e.CompiledCode.Count;
            else
            {
                if (e.Stack.CurentStackItemFrame().RetType != typeof(void))
                {
                    if (!e.Stack.Pop(out s)) errorMessage = "Function " + e.Stack.CurentStackItemFrame().FrameName + " excepted return type of " + e.Stack.CurentStackItemFrame().RetType.ToString().Split('.')[1] + " but given void type line : " + (_line + 1);
                    else if (s.Type != e.Stack.CurentStackItemFrame().RetType) errorMessage = "Function " + e.Stack.CurentStackItemFrame().FrameName + " excepted return type of " + e.Stack.CurentStackItemFrame().RetType.ToString().Split('.')[1] + " but given " + s.Type.ToString().Split('.')[1] + " type line : " + (_line + 1);
                    else if (!e.Stack.PopFrame()) errorMessage = "stack is not empty can't execute the operation 'ret' line :" + (_line + 1);
                    else
                    {
                        e.Stack.Push(s.Type, s.Value);
                        e.Pc = e.Stack.CurentStackItemFrame().Line;
                    }
                }
                else
                {
                    if (!e.Stack.PopFrame()) errorMessage = "stack is not empty can't execute the operation 'ret' line :" + (_line + 1);
                    e.Pc = e.Stack.CurentStackItemFrame().Line;
                }
                
            }
            return new OpCodeResult(errorMessage);
        }
    }

    public class stargOpCode : OpCode
    {
        internal int _argidx;

        public stargOpCode(int i, int line)
        {
            _line = line;
            base._name = "starg";
            base._type = "operation";
            base._executable = true;
            _argidx = i;
        }

        override public OpCodeResult Execute(Environment e)
        {
            string errorMessage = "";
            StackItemValue siv;
            if (e.Stack.Pop(out siv))
            {
                StackItemFrame sif = e.Stack.CurentStackItemFrame();
                if (sif.Args.Count <= _argidx) errorMessage = "Argument " + _argidx + " does not exist in function " + sif.FrameName + " line : " + (_line + 1);
                else sif.Args[_argidx] = siv;
            }
            else errorMessage = "stack is empty can't execute the operation 'starg' line :" + (_line + 1);
            return new OpCodeResult(errorMessage);
        }

    }

    public class ldargOpCode : OpCode
    {
        internal int _argidx;

        public ldargOpCode(int i, int line)
        {
            _line = line;
            base._name = "ldarg";
            base._type = "operation";
            base._executable = true;
            _argidx = i;
        }

        override public OpCodeResult Execute(Environment e)
        {
            string errorMessage = "";
            StackItemFrame sif = e.Stack.CurentStackItemFrame();
            if (_argidx < sif.Args.Count)
            {
                e.Stack.Push(sif.Args[_argidx].Type, sif.Args[_argidx].Value);
            }
            else errorMessage = "Argument " + _argidx + " does not exist in function " + sif.FrameName + " line : " + (_line + 1);
            return new OpCodeResult(errorMessage);
        }

    }
}
