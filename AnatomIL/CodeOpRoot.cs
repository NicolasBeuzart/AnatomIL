using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnatomIL
{
    public class CodeOpRoot // classe "père" de toute les OpCodeRoot
    {
        internal string _name;

        public CodeOpRoot()
        {
            _name = "none";
        }

        public string Name
        {
            get { return _name; }
        }

        virtual public CodeOp Parse(string args, Stack s) { return null; } // methode de parse des opérations qui retourne un CodeOp pres a être Executer correctement
    }
    
    public class AddCodeOpRoot : CodeOpRoot
    {

        public AddCodeOpRoot()
        {
            base._name = "add";
        }

        override public CodeOp Parse(string args, Stack s)
        {
            Type t;

            t = s.CurrentStack[s.Count - 1].Type;

            if (t != s.CurrentStack[s.Count - 2].Type)
            {
                throw new InvalidOperationException("can't add two values using different type");
            }

            return new AddCodeOp(t);
        }
    }

    public class SubCodeOpRoot : CodeOpRoot
    {

        public SubCodeOpRoot()
        {
            base._name = "sub";
        }

        override public CodeOp Parse(string args, Stack s)
        {
            Type t;

            t = s.CurrentStack[s.Count - 1].Type;

            if (t != s.CurrentStack[s.Count - 2].Type)
            {
                throw new InvalidOperationException("can't sub two values using different type");
            }

            return new SubCodeOp(t);
        }
    }

    public class MulCodeOpRoot : CodeOpRoot
    {

        public MulCodeOpRoot()
        {
            base._name = "mul";
        }

        override public CodeOp Parse(string args, Stack s)
        {
            Type t;

            t = s.CurrentStack[s.Count - 1].Type;

            if (t != s.CurrentStack[s.Count - 2].Type)
            {
                throw new InvalidOperationException("can't mul two values using different type");
            }

            return new MulCodeOp(t);
        }
    }

    public class DivCodeOpRoot : CodeOpRoot
    {

        public DivCodeOpRoot()
        {
            base._name = "div";
        }

        override public CodeOp Parse(string args, Stack s)
        {
            Type t;

            t = s.CurrentStack[s.Count - 1].Type;

            if (t != s.CurrentStack[s.Count - 2].Type)
            {
                throw new InvalidOperationException("can't div two values using different type");
            }

            return new DivCodeOp(t);
        }
    }

    public class RemCodeOpRoot : CodeOpRoot
    {

        public RemCodeOpRoot()
        {
            base._name = "rem";
        }

        override public CodeOp Parse(string args, Stack s)
        {
            Type t;

            t = s.CurrentStack[s.Count - 1].Type;

            if (t != s.CurrentStack[s.Count - 2].Type)
            {
                throw new InvalidOperationException("can't rem two values using different type");
            }

            return new RemCodeOp(t);
        }
    }

    public class LdcCodeOpRoot : CodeOpRoot
    {

        public LdcCodeOpRoot()
        {
            base._name = "ldc";
        }

        override public CodeOp Parse(string args, Stack s)
        {
            string[] instruction = args.Split('.');
            Type t;
            object Value;

            if (instruction[1].Equals("i8"))
            {
                t = typeof(Int64);
                Value = Convert.ToInt64(instruction[2]);
            }
            else if (instruction[1].Equals("i4"))
            {
                t = typeof(Int32);
                Value = Convert.ToInt32(instruction[2]);
            }
            else if (instruction[1].Equals("i2"))
            {
                t = typeof(Int16);
                Value = Convert.ToInt16(instruction[2]);
            }
            else
            {
                throw new Exception("lcd operation can't have first argument : " + instruction[1]);
            }

            return (new LdcCodeOp(t, Value));
        }
    }


}
