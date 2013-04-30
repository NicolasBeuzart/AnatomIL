﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnatomIL
{
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

    public class BeqOpCode : OpCode
    {
        string _label;

        public BeqOpCode(string label)
        {
            base._name = "beq";
            _label = label;
            base._executable = true;
        }

        public override void Execute(Environment e)
        {
            StackItem s1 = e.Stack.Pop();
            StackItem s2 = e.Stack.Pop();
            if (s1.Type == s2.Type && s1.Value.Equals(s2.Value))
            {
                e.Pc = e.CompiledCode.IndexLabel(_label);
            }
        }
    }

    public class BgeOpCode : OpCode
    {
        string _label;
        bool _unsigned;

        public BgeOpCode(string label, bool unsigned)
        {
            base._name = "bge";
            _label = label;
            base._executable = true;
            _unsigned = unsigned;
        }

        public override void Execute(Environment e)
        {
            StackItem s1 = e.Stack.Pop();
            StackItem s2 = e.Stack.Pop();
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

    public class BgtOpCode : OpCode
    {
        string _label;
        bool _unsigned;

        public BgtOpCode(string label, bool unsigned)
        {
            base._name = "bgt";
            _label = label;
            base._executable = true;
            _unsigned = unsigned;
        }

        public override void Execute(Environment e)
        {
            StackItem s1 = e.Stack.Pop();
            StackItem s2 = e.Stack.Pop();
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

    public class BleOpCode : OpCode
    {
        string _label;
        bool _unsigned;

        public BleOpCode(string label, bool unsigned)
        {
            base._name = "ble";
            _label = label;
            base._executable = true;
            _unsigned = unsigned;
        }

        public override void Execute(Environment e)
        {
            StackItem s1 = e.Stack.Pop();
            StackItem s2 = e.Stack.Pop();
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

    public class BltOpCode : OpCode
    {
        string _label;
        bool _unsigned;

        public BltOpCode(string label, bool unsigned)
        {
            base._name = "blt";
            _label = label;
            base._executable = true;
            _unsigned = unsigned;
        }

        public override void Execute(Environment e)
        {
            StackItem s1 = e.Stack.Pop();
            StackItem s2 = e.Stack.Pop();
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

    public class BneOpCode : OpCode
    {
        string _label;
        bool _unsigned;

        public BneOpCode(string label, bool unsigned)
        {
            base._name = "beq";
            _label = label;
            base._executable = true;
            _unsigned = unsigned;
        }

        public override void Execute(Environment e)
        {
            StackItem s1 = e.Stack.Pop();
            StackItem s2 = e.Stack.Pop();
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

    public class BrfalseOpCode : OpCode
    {
        string _label;

        public BrfalseOpCode(string label)
        {
            base._name = "brfalse";
            _label = label;
            base._executable = true;
        }

        public override void Execute(Environment e)
        {
            StackItem s1 = e.Stack.Pop();

            if (s1.Type == typeof(bool) && s1.Value.Equals(false))
            {
                e.Pc = e.CompiledCode.IndexLabel(_label);
            }
        }
    }

    public class BrtrueOpCode : OpCode
    {
        string _label;

        public BrtrueOpCode(string label)
        {
            base._name = "brtrue";
            _label = label;
            base._executable = true;
        }

        public override void Execute(Environment e)
        {
            StackItem s1 = e.Stack.Pop();

            if (s1.Type == typeof(bool) && s1.Value.Equals(true))
            {
                e.Pc = e.CompiledCode.IndexLabel(_label);
            }
        }
    }

    public class BrzeroOpCode : OpCode
    {
        string _label;

        public BrzeroOpCode(string label)
        {
            base._name = "brzero";
            _label = label;
            base._executable = true;
        }

        public override void Execute(Environment e)
        {
            StackItem s1 = e.Stack.Pop();
            Int64 i64 = 0;
            Int16 i16 = 0;

            if (s1.Value.Equals(0) || s1.Value.Equals(i64) || s1.Value.Equals(i16))
            {
                e.Pc = e.CompiledCode.IndexLabel(_label);
            }
        }
    }

    public class BrnullOpCode : OpCode
    {
        string _label;

        public BrnullOpCode(string label)
        {
            base._name = "brnull";
            _label = label;
            base._executable = true;
        }

        public override void Execute(Environment e)
        {
            StackItem s1 = e.Stack.Pop();

            if (s1.Value.Equals(null))
            {
                e.Pc = e.CompiledCode.IndexLabel(_label);
            }
        }
    }

    public class BrinstOpCode : OpCode
    {
        string _label;

        public BrinstOpCode(string label)
        {
            base._name = "brinst";
            _label = label;
            base._executable = true;
        }

        public override void Execute(Environment e)
        {
            StackItem s1 = e.Stack.Pop();

            if (!s1.Value.Equals(null))
            {
                e.Pc = e.CompiledCode.IndexLabel(_label);
            }
        }
    }
}
