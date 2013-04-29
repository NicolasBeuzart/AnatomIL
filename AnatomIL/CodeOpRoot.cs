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

        virtual public OpCodeRootResult Parse(List<string> options, List<string> args) { return null; } // methode de parse des opérations qui retourne un CodeOp pres a être Executer correctement
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

        override public OpCodeRootResult Parse(List<string> options, List<string> args)
        {
            string errorMessage = "";

            if (options.Count() != 0)
            {
                errorMessage = "Bad options in Operation" + base._name;
            }
            if (args.Count() != 0 && args[0] != "")
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

        override public OpCodeRootResult Parse(List<string> options, List<string> args)
        {
            string errorMessage = "";

            if (options.Count() != 0)
            {
                errorMessage = "Bad options in Operation" + base._name;
            }
            if (args.Count() != 0 && args[0] != "")
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

        override public OpCodeRootResult Parse(List<string> options, List<string> args)
        {
            string errorMessage = "";

            if (options.Count() != 0)
            {
                errorMessage = "Bad options in Operation" + base._name;
            }
            if (args.Count() != 0 && args[0] != "")
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

        override public OpCodeRootResult Parse(List<string> options, List<string> args)
        {
            string errorMessage = "";

            if (options.Count() != 0)
            {
                errorMessage = "Bad options in Operation" + base._name;
            }
            if (args.Count() != 0 && args[0] != "")
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

        override public OpCodeRootResult Parse(List<string> options, List<string> args)
        {
            string errorMessage = "";

            if (options.Count() != 0)
            {
                errorMessage = "Bad options in Operation" + base._name;
            }
            if (args.Count() != 0 && args[0] != "")
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

        override public OpCodeRootResult Parse(List<string> options, List<string> args)
        {
            string errorMessage = "";
            Type t = null;
            object Value = null;

            if (args.Count() < 1 || (args.Count() > 1 && args[1] != ""))
            {
                errorMessage = "Bad options/operations in Operation" + base._name;
            }

            if (options.Count() != 1)
            {
                errorMessage = "Bad options in Operation" + base._name;
            }

            else if (options[0].Equals("i8"))
            {
                Int64 tmp;
                if (!Int64.TryParse(args[0], out tmp)) errorMessage = "argument isn't Int64 in Operation" + base._name;
                else
                {
                    t = typeof(Int64);
                    Value = Convert.ToInt64(args[0]);
                }
            }
            else if (options[0].Equals("i4"))
            {
                Int32 tmp;
                if (!Int32.TryParse(args[0], out tmp)) errorMessage = "argument isn't Int32 in Operation" + base._name;
                t = typeof(Int32);
                Value = Convert.ToInt32(args[0]);
            }
            else if (options[0].Equals("i2"))
            {
                Int16 tmp;
                if (!Int16.TryParse(args[0], out tmp)) errorMessage = "argument isn't Int16 in Operation" + base._name;
                t = typeof(Int16);
                Value = Convert.ToInt16(args[0]);
            }
            else
            {
                errorMessage = "lcd operation can't have first argument : " + args[0];
            }

            return (new OpCodeRootResult(errorMessage, new LdcOpCode(t, Value)));
        }
    }

    public class LabelOpCodeRoot : OpCodeRoot
    {
        public LabelOpCodeRoot()
        {
            base._name = "label";
        }

        override public OpCodeRootResult Parse(List<string> options, List<string> args)
        {
            string errorMessage = "";

            return new OpCodeRootResult(errorMessage, new LabelOpCode(options[0].Replace(":", "")));
        }
    }

    public class LocalsInitOpCodeRoot : OpCodeRoot
    {
        public LocalsInitOpCodeRoot()
        {
            base._name = "localsInit";
        }

        override public OpCodeRootResult Parse(List<string> options, List<string> args)
        {
            string errorMessage = "";
            List<string> locals = new List<string>();

            for (int i = 0; i < options.Count(); i++)
            {
                if (options[i] == "int16" || options[i] == "int32" || options[i] == "int64" || options[i] == "bool")
                {
                    locals.Add(options[i]);
                }
                else
                {
                    errorMessage = "bad declaration of local variable";
                }
            }

            return new OpCodeRootResult(errorMessage, new LocalsInitOpCode(locals));
        }
    }

}
