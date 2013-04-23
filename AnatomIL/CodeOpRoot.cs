 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnatomIL
{
    public class OpCodeRoot // classe "père" de toute les OpCodeRoot
    {
        internal string _name;

        public OpCodeRoot()
        {
            _name = "none";
        }

        public string Name
        {
            get { return _name; }
        }

        virtual public OpCodeRootResult Parse(string args) { return null; } // methode de parse des opérations qui retourne un CodeOp pres a être Executer correctement
    }

    public class OpCodeRootResult
    {
        public string ErrorMessage { get; internal set; }
        public OpCode OpCode { get; internal set; }

        public bool IsSuccess { get { return ErrorMessage == ""; } }

        public OpCodeRootResult(string errorMessage, OpCode opCode)
        {
            ErrorMessage = errorMessage;
            OpCode = opCode;
        }
    }

    public class AddOpCodeRoot : OpCodeRoot
    {

        public AddOpCodeRoot()
        {
            base._name = "add";
        }

        override public OpCodeRootResult Parse(string args)
        {
            string errorMessage = "";

            string[] instruction = args.Split('.');
            if (instruction.Count() != 1 && (instruction.Count() != 2 || instruction[1] != ""))
            {
                errorMessage = "Bad arguments in Operation" + base._name;
            }

            return new OpCodeRootResult(errorMessage, new AddOpCode());
        }
    }

    public class SubCodeOpRoot : OpCodeRoot
    {

        public SubCodeOpRoot()
        {
            base._name = "sub";
        }

        override public OpCodeRootResult Parse(string args)
        {
            string errorMessage = "";

            string[] instruction = args.Split('.');
            if (instruction.Count() != 1 && (instruction.Count() != 2 || instruction[1] != ""))
            {
                errorMessage = "Bad arguments in Operation" + base._name;
            }

            return new OpCodeRootResult(errorMessage, new SubOpCode());
        }
    }

    public class MulCodeOpRoot : OpCodeRoot
    {

        public MulCodeOpRoot()
        {
            base._name = "mul";
        }

        override public OpCodeRootResult Parse(string args)
        {
            string errorMessage = "";

            string[] instruction = args.Split('.');
            if (instruction.Count() != 1 && (instruction.Count() != 2 || instruction[1] != ""))
            {
                errorMessage = "Bad arguments in Operation" + base._name;
            }

            return new OpCodeRootResult(errorMessage, new MulOpCode());
        }
    }

    public class DivCodeOpRoot : OpCodeRoot
    {

        public DivCodeOpRoot()
        {
            base._name = "div";
        }

        override public OpCodeRootResult Parse(string args)
        {
            string errorMessage = "";

            string[] instruction = args.Split('.');
            if (instruction.Count() != 1 && (instruction.Count() != 2 || instruction[1] != ""))
            {
                errorMessage = "Bad arguments in Operation" + base._name;
            }

            return new OpCodeRootResult(errorMessage, new DivOpCode());
        }
    }

    public class RemCodeOpRoot : OpCodeRoot
    {

        public RemCodeOpRoot()
        {
            base._name = "rem";
        }

        override public OpCodeRootResult Parse(string args)
        {
            string errorMessage = "";

            string[] instruction = args.Split('.');
            if (instruction.Count() != 1 && (instruction.Count() != 2 || instruction[1] != ""))
            {
                errorMessage = "Bad arguments in Operation" + base._name;
            }

            return new OpCodeRootResult(errorMessage, new RemOpCode());
        }
    }

    public class LdcCodeOpRoot : OpCodeRoot
    {

        public LdcCodeOpRoot()
        {
            base._name = "ldc";
        }

        override public OpCodeRootResult Parse(string args)
        {
            string[] instruction = args.Split('.');
            Type t = null;
            object Value = null;
            string errorMessage = "";

            if (instruction.Count() != 3)
            {
                errorMessage = "Bad arguments in Operation" + base._name;
            }

            else if (instruction[1].Equals("i8"))
            {
                Int64 tmp;
                if (!Int64.TryParse(instruction[2], out tmp)) errorMessage = "2nd argument isn't Int64 in Operation" + base._name;
                else
                {
                    t = typeof(Int64);
                    Value = Convert.ToInt64(instruction[2]);
                }
            }
            else if (instruction[1].Equals("i4"))
            {
                Int32 tmp;
                if (!Int32.TryParse(instruction[2], out tmp)) errorMessage = "2nd argument isn't Int32 in Operation" + base._name;
                t = typeof(Int32);
                Value = Convert.ToInt32(instruction[2]);
            }
            else if (instruction[1].Equals("i2"))
            {
                Int16 tmp;
                if (!Int16.TryParse(instruction[2], out tmp)) errorMessage = "2nd argument isn't Int16 in Operation" + base._name;
                t = typeof(Int16);
                Value = Convert.ToInt16(instruction[2]);
            }
            else
            {
                errorMessage = "lcd operation can't have first argument : " + instruction[1];
            }

            return (new OpCodeRootResult(errorMessage, new LdcOpCode(t, Value)));
        }
    }


}
