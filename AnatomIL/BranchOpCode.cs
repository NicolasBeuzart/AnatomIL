using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnatomIL
{
    public class BrOpCode : OpCode
    {
        string _label;

        public BrOpCode(string label, int line)
        {
            _line = line;
            base._name = "br";
            base._type = "operation";
            _label = label;
            base._executable = true;
        }

        public override void Execute(Environment e)
        {
            e.Pc = e.CompiledCode.IndexLabel(_label);
        }
    }

    public class BeqOpCode : OpCode
    {
        string _label;

        public BeqOpCode(string label, int line)
        {
            _line = line;
            base._name = "beq";
            base._type = "operation";
            _label = label;
            base._executable = true;
        }

        public override void Execute(Environment e)
        {
            StackItemValue s1;
            StackItemValue s2;
            if (e.Stack.Pop(out s1))
            {
                if (e.Stack.Pop(out s2))
                {
                    if (s1.Type == s2.Type && s1.Value.Equals(s2.Value))
                    {
                        e.Pc = e.CompiledCode.IndexLabel(_label);
                    }
                }
            }
        }
    }

    public class BgeOpCode : OpCode
    {
        string _label;
        bool _unsigned;

        public BgeOpCode(string label, bool unsigned, int line)
        {
            _line = line;
            base._name = "bge";
            base._type = "operation";
            _label = label;
            base._executable = true;
            _unsigned = unsigned;
        }

        public override void Execute(Environment e)
        {
            StackItemValue s1;
            StackItemValue s2;

            if (e.Stack.Pop(out s1))
            {
                if (e.Stack.Pop(out s2))
                {
                    if (s1.Type == s2.Type && (s1.Type == typeof(Int64) || s1.Type == typeof(Int32) || s1.Type == typeof(Int16)))
                    {
                        Int64 i1 = Convert.ToInt64(s1.Value);
                        Int64 i2 = Convert.ToInt64(s2.Value);

                        if (_unsigned)
                        {
                            if (i1 < 0) i1 = i1 * -1;
                            if (i2 < 0) i2 = i2 * -1;
                        }

                        if (i1 == i2 || i1 > i2)
                        {
                            e.Pc = e.CompiledCode.IndexLabel(_label);
                        }
                    }
                }
            }
        }
    }

    public class BgtOpCode : OpCode
    {
        string _label;
        bool _unsigned;

        public BgtOpCode(string label, bool unsigned, int line)
        {
            _line = line;
            base._name = "bgt";
            base._type = "operation";
            _label = label;
            base._executable = true;
            _unsigned = unsigned;
        }

        public override void Execute(Environment e)
        {
            StackItemValue s1;
            StackItemValue s2;

            if (e.Stack.Pop(out s1))
            {
                if (e.Stack.Pop(out s2))
                {
                    if (s1.Type == s2.Type && (s1.Type == typeof(Int64) || s1.Type == typeof(Int32) || s1.Type == typeof(Int16)))
                    {
                        Int64 i1 = Convert.ToInt64(s1.Value);
                        Int64 i2 = Convert.ToInt64(s2.Value);

                        if (_unsigned)
                        {
                            if (i1 < 0) i1 = i1 * -1;
                            if (i2 < 0) i2 = i2 * -1;
                        }

                        if (i1 > i2)
                        {
                            e.Pc = e.CompiledCode.IndexLabel(_label);
                        }
                    }
                }
            }
        }
    }

    public class BleOpCode : OpCode
    {
        string _label;
        bool _unsigned;

        public BleOpCode(string label, bool unsigned, int line)
        {
            _line = line;
            base._name = "ble";
            base._type = "operation";
            _label = label;
            base._executable = true;
            _unsigned = unsigned;
        }

        public override void Execute(Environment e)
        {
            StackItemValue s1;
            StackItemValue s2;

            if (e.Stack.Pop(out s1))
            {
                if (e.Stack.Pop(out s2))
                {
                    if (s1.Type == s2.Type && (s1.Type == typeof(Int64) || s1.Type == typeof(Int32) || s1.Type == typeof(Int16)))
                    {
                        Int64 i1 = Convert.ToInt64(s1.Value);
                        Int64 i2 = Convert.ToInt64(s2.Value);

                        if (_unsigned)
                        {
                            if (i1 < 0) i1 = i1 * -1;
                            if (i2 < 0) i2 = i2 * -1;
                        }

                        if (i1 == i2 || i1 < i2)
                        {
                            e.Pc = e.CompiledCode.IndexLabel(_label);
                        }
                    }
                }
            }
        }
    }

    public class BltOpCode : OpCode
    {
        string _label;
        bool _unsigned;

        public BltOpCode(string label, bool unsigned, int line)
        {
            _line = line;
            base._name = "blt";
            base._type = "operation";
            _label = label;
            base._executable = true;
            _unsigned = unsigned;
        }

        public override void Execute(Environment e)
        {
            StackItemValue s1;
            StackItemValue s2;

            if (e.Stack.Pop(out s1))
            {
                if (e.Stack.Pop(out s2))
                {
                    if (s1.Type == s2.Type && (s1.Type == typeof(Int64) || s1.Type == typeof(Int32) || s1.Type == typeof(Int16)))
                    {
                        Int64 i1 = Convert.ToInt64(s1.Value);
                        Int64 i2 = Convert.ToInt64(s2.Value);

                        if (_unsigned)
                        {
                            if (i1 < 0) i1 = i1 * -1;
                            if (i2 < 0) i2 = i2 * -1;
                        }

                        if (i1 < i2)
                        {
                            e.Pc = e.CompiledCode.IndexLabel(_label);
                        }
                    }
                }
            }
        }
    }

    public class BneOpCode : OpCode
    {
        string _label;
        bool _unsigned;

        public BneOpCode(string label, bool unsigned, int line)
        {
            _line = line;
            base._name = "beq";
            base._type = "operation";
            _label = label;
            base._executable = true;
            _unsigned = unsigned;
        }

        public override void Execute(Environment e)
        {
            StackItemValue s1;
            StackItemValue s2;

            if (e.Stack.Pop(out s1))
            {
                if (e.Stack.Pop(out s2))
                {
                    if (s1.Type == s2.Type && (s1.Type == typeof(Int64) || s1.Type == typeof(Int32) || s1.Type == typeof(Int16)))
                    {
                        Int64 i1 = Convert.ToInt64(s1.Value);
                        Int64 i2 = Convert.ToInt64(s2.Value);

                        if (_unsigned)
                        {
                            if (i1 < 0) i1 = i1 * -1;
                            if (i2 < 0) i2 = i2 * -1;
                        }

                        if (i1 != i2)
                        {
                            e.Pc = e.CompiledCode.IndexLabel(_label);
                        }
                    }
                }
            }
        }
    }

    public class BrfalseOpCode : OpCode
    {
        string _label;

        public BrfalseOpCode(string label, int line)
        {
            _line = line;
            base._name = "brfalse";
            base._type = "operation";
            _label = label;
            base._executable = true;
        }

        public override void Execute(Environment e)
        {
            StackItemValue s1;

            if (e.Stack.Pop(out s1))
            {
                if (s1.Type == typeof(bool) && s1.Value.Equals(false))
                {
                    e.Pc = e.CompiledCode.IndexLabel(_label);
                }
            }
        }
    }

    public class BrtrueOpCode : OpCode
    {
        string _label;

        public BrtrueOpCode(string label, int line)
        {
            _line = line;
            base._name = "brtrue";
            base._type = "operation";
            _label = label;
            base._executable = true;
        }

        public override void Execute(Environment e)
        {
            StackItemValue s1;

            if (e.Stack.Pop(out s1))
            {
                if (s1.Type == typeof(bool) && s1.Value.Equals(true))
                {
                    e.Pc = e.CompiledCode.IndexLabel(_label);
                }
            }
        }
    }

    public class BrzeroOpCode : OpCode
    {
        string _label;

        public BrzeroOpCode(string label, int line)
        {
            _line = line;
            base._name = "brzero";
            base._type = "operation";
            _label = label;
            base._executable = true;
        }

        public override void Execute(Environment e)
        {
            StackItemValue s1;
            Int64 i64 = 0;
            Int16 i16 = 0;

            if (e.Stack.Pop(out s1))
            {
                if (s1.Value.Equals(0) || s1.Value.Equals(i64) || s1.Value.Equals(i16))
                {
                    e.Pc = e.CompiledCode.IndexLabel(_label);
                }
            }
        }
    }

    public class BrnullOpCode : OpCode
    {
        string _label;

        public BrnullOpCode(string label, int line)
        {
            _line = line;
            base._name = "brnull";
            base._type = "operation";
            _label = label;
            base._executable = true;
        }

        public override void Execute(Environment e)
        {
            StackItemValue s1;

            if (e.Stack.Pop(out s1))
            {
                if (s1.Value.Equals(null))
                {
                    e.Pc = e.CompiledCode.IndexLabel(_label);
                }
            }
        }
    }

    public class BrinstOpCode : OpCode
    {
        string _label;

        public BrinstOpCode(string label, int line)
        {
            _line = line;
            base._name = "brinst";
            base._type = "operation";
            _label = label;
            base._executable = true;
        }

        public override void Execute(Environment e)
        {
            StackItemValue s1;

            if (e.Stack.Pop(out s1))
            {
                if (!s1.Value.Equals(null))
                {
                    e.Pc = e.CompiledCode.IndexLabel(_label);
                }
            }
        }
    }
}
