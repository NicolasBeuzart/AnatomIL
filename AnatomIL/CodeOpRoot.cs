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
        internal string _type;

        public OpCodeRoot()
        {
            _name = "none";
        }

        public string Type { get { return _type; } }
        public string Name
        {
            get { return _name; }
        }

        virtual public OpCodeRootResult Parse(Tokeniser t) { return null; } // methode de parse des opérations qui retourne un CodeOp pres a être Executer correctement
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
            base._type = "operation";
        }

        override public OpCodeRootResult Parse(Tokeniser t)
        {
            string errorMessage = "";

            t.MatchSpace();
            if (!t.IsEnd)
            {
                errorMessage = "Bad utilisation of Operation" + base._name + "in line : " + t.CurentLigne;
            }

            return new OpCodeRootResult(errorMessage, new AddOpCode());
        }
    }

    public class SubCodeOpRoot : OpCodeRoot
    {

        public SubCodeOpRoot()
        {
            base._name = "sub";
            base._type = "operation";
        }

        override public OpCodeRootResult Parse(Tokeniser t)
        {
            string errorMessage = "";

            t.MatchSpace();
            if (!t.IsEnd)
            {
                errorMessage = "Bad utilisation of Operation" + base._name + "in line : " + t.CurentLigne;
            }

            return new OpCodeRootResult(errorMessage, new SubOpCode());
        }
    }

    public class MulCodeOpRoot : OpCodeRoot
    {

        public MulCodeOpRoot()
        {
            base._name = "mul";
            base._type = "operation";
        }

        override public OpCodeRootResult Parse(Tokeniser t)
        {
            string errorMessage = "";

            t.MatchSpace();
            if (!t.IsEnd)
            {
                errorMessage = "Bad utilisation of Operation" + base._name + "in line : " + t.CurentLigne;
            }

            return new OpCodeRootResult(errorMessage, new MulOpCode());
        }
    }

    public class DivCodeOpRoot : OpCodeRoot
    {

        public DivCodeOpRoot()
        {
            base._name = "div";
            base._type = "operation";
        }

        override public OpCodeRootResult Parse(Tokeniser t)
        {
            string errorMessage = "";

            t.MatchSpace();
            if (!t.IsEnd)
            {
                errorMessage = "Bad utilisation of Operation" + base._name + "in line : " + t.CurentLigne;
            }

            return new OpCodeRootResult(errorMessage, new DivOpCode());
        }
    }

    public class RemCodeOpRoot : OpCodeRoot
    {

        public RemCodeOpRoot()
        {
            base._name = "rem";
            base._type = "operation";
        }

        override public OpCodeRootResult Parse(Tokeniser t)
        {
            string errorMessage = "";

            t.MatchSpace();
            if (!t.IsEnd)
            {
                errorMessage = "Bad utilisation of Operation" + base._name + "in line : " + t.CurentLigne;
            }

            return new OpCodeRootResult(errorMessage, new RemOpCode());
        }
    }

    public class LdcCodeOpRoot : OpCodeRoot
    {

        public LdcCodeOpRoot()
        {
            base._name = "ldc";
            base._type = "operation";
        }

        override public OpCodeRootResult Parse(Tokeniser t)
        {
            string errorMessage = "";
            Type type = null;
            object Value = null;
            string option;
            string argument;

            if (!(t.IsOption(out option) && t.IsArgument(out argument) && t.IsEnd))
                errorMessage = "Bad utilisation of Operation" + base._name + "in line : " + t.CurentLigne;
            else if (option.Equals("i8"))
            {
                Int64 tmp;
                if (!Int64.TryParse(argument, out tmp)) errorMessage = "Argument isn't Int64 in Operation" + base._name;
                else
                {
                    type = typeof(Int64);
                    Value = Convert.ToInt64(argument);
                }
            }
            else if (option.Equals("i4"))
            {
                Int32 tmp;
                if (!Int32.TryParse(argument, out tmp)) errorMessage = "Argument isn't Int32 in Operation" + base._name;
                type = typeof(Int32);
                Value = Convert.ToInt32(argument);
            }
            else if (option.Equals("i2"))
            {
                Int16 tmp;
                if (!Int16.TryParse(argument, out tmp)) errorMessage = "Argument isn't Int16 in Operation" + base._name;
                type = typeof(Int16);
                Value = Convert.ToInt16(argument);
            }
            else
            {
                errorMessage = "lcd operation can't have option : " + option;
            }

            return (new OpCodeRootResult(errorMessage, new LdcOpCode(type, Value)));
        }
    }

    public class LabelOpCodeRoot : OpCodeRoot
    {
        public LabelOpCodeRoot()
        {
            base._name = "label";
            base._type = "label";
        }

        override public OpCodeRootResult Parse(Tokeniser t)
        {
            string errorMessage = "";
            string label;

            if (!(t.IsString(out label) && t.IsEnd)) errorMessage = "Bad label declaration in line : " + t.CurentLigne;

            return new OpCodeRootResult(errorMessage, new LabelOpCode(label));
        }
    }

    public class LocalsInitOpCodeRoot : OpCodeRoot
    {
        public LocalsInitOpCodeRoot()
        {
            base._name = "locals";
            base._type = "directive";
        }

        override public OpCodeRootResult Parse(Tokeniser t)
        {
            string errorMessage = "";
            List<string> locals = new List<string>();
            string type;
            string s;

            t.MatchSpace();
            t.MatchOpenPar();

            do
            {
                t.MatchSpace();
                if (t.IsType(out type)) locals.Add(type);
                else errorMessage = "Bad declaration of local variable, \"" + type + "\" is not a type in line : " + t.CurentLigne;
                t.MatchSpace();
                t.IsString(out s);
            } while (t.MatchComma());

            if (!t.MatchClosePar()) errorMessage = "miss ')' in locals declaration line : " + t.CurentLigne;

            return new OpCodeRootResult(errorMessage, new LocalsInitOpCode(locals));
        }
    }

    public class DupOpCodeRoot : OpCodeRoot
    {

        public DupOpCodeRoot()
        {
            base._name = "dup";
            base._type = "operation";
        }

        override public OpCodeRootResult Parse(Tokeniser t)
        {
            string errorMessage = "";

            t.MatchSpace();
            if (!t.IsEnd)
            {
                errorMessage = "Bad utilisation of Operation" + base._name + "in line : " + t.CurentLigne;
            }

            return new OpCodeRootResult(errorMessage, new DupOpCode());
        }
    }
}
