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

            return new OpCodeRootResult(errorMessage, new AddOpCode(t.CurentLigne));
        }
    }

    public class SubOpCodeRoot : OpCodeRoot
    {

        public SubOpCodeRoot()
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

            return new OpCodeRootResult(errorMessage, new SubOpCode(t.CurentLigne));
        }
    }

    public class MulOpCodeRoot : OpCodeRoot
    {

        public MulOpCodeRoot()
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

            return new OpCodeRootResult(errorMessage, new MulOpCode(t.CurentLigne));
        }
    }

    public class DivOpCodeRoot : OpCodeRoot
    {

        public DivOpCodeRoot()
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

            return new OpCodeRootResult(errorMessage, new DivOpCode(t.CurentLigne));
        }
    }

    public class RemOpCodeRoot : OpCodeRoot
    {

        public RemOpCodeRoot()
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

            return new OpCodeRootResult(errorMessage, new RemOpCode(t.CurentLigne));
        }
    }

    public class LdcOpCodeRoot : OpCodeRoot
    {
        EnumManager _enumManager;


        public LdcOpCodeRoot(EnumManager enumManager)
        {
            base._name = "ldc";
            base._type = "operation";
            _enumManager = enumManager;
        }

        override public OpCodeRootResult Parse(Tokeniser t)
        {
            string errorMessage = "";
            Type type = null;
            object Value = null;
            string option;
            string argument = "";
            string tmp2 = null;
            int result = -1;

            if (!(t.IsOption(out option) && t.MatchSpace()))
                errorMessage = "Bad utilisation of Operation " + base._name + " in line : " + (t.CurentLigne + 1);
            else if (!(_enumManager.IsEnumValue(t, out result, out errorMessage) || t.IsArgument(out argument)))
            {
                errorMessage = "Bad utilisation of Operation " + base._name + " in line : " + (t.CurentLigne + 1);
            }
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
                if (result > -1)
                {
                    type = typeof(Int32);
                    Value = result;
                }
                else if (!Int32.TryParse(argument, out tmp)) errorMessage = "Argument isn't Int32 in Operation " + base._name;
                else
                {
                    type = typeof(Int32);
                    Value = Convert.ToInt32(argument);
                }
            }
            else if (option.Equals("i2"))
            {

                Int16 tmp;
                if (!Int16.TryParse(argument, out tmp)) errorMessage = "Argument isn't Int16 in Operation" + base._name;
                else
                {
                    type = typeof(Int16);
                    Value = Convert.ToInt16(argument);
                }
            }
            else
            {
                errorMessage = "lcd operation can't have option : " + option;
            }

            return (new OpCodeRootResult(errorMessage, new LdcOpCode(type, Value, t.CurentLigne)));
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
            return new OpCodeRootResult(errorMessage, new LabelOpCode(label, t.CurentLigne));
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
            if (!t.MatchOpenPar()) errorMessage = "missing '(' in line : " + (t.CurentLigne + 1);

            do
            {
                t.MatchSpace();
                if (t.IsType(out type)) locals.Add(type);
                else errorMessage = "Bad declaration of local variable, \"" + type + "\" is not a type in line : " + t.CurentLigne;
                t.MatchSpace();
                t.IsString(out s);
            } while (t.MatchComma());

            if (!t.MatchClosePar()) errorMessage = "miss ')' in locals declaration line : " + t.CurentLigne;

            return new OpCodeRootResult(errorMessage, new LocalsInitOpCode(locals, t.CurentLigne));
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

            return new OpCodeRootResult(errorMessage, new DupOpCode(t.CurentLigne));
        }
    }

    public class stlocOpCodeRoot : OpCodeRoot
    {
        public stlocOpCodeRoot()
        {
            base._name = "stloc";
            base._type = "operation";
        }

        public override OpCodeRootResult Parse(Tokeniser t)
        {
            string errorMessage = "";
            string arg;
            Int32 tmp = 0;

            if (!(t.IsArgument(out arg) && t.IsEnd && Int32.TryParse(arg, out tmp)))
            {
                errorMessage = "error line " + t.CurentLigne;
            }

            return (new OpCodeRootResult(errorMessage,new stlocOpCode(tmp, t.CurentLigne)));
        }
    }

    public class ldlocOpCodeRoot : OpCodeRoot
    {
        public ldlocOpCodeRoot()
        {
            base._name = "ldloc";
            base._type = "operation";
        }

        public override OpCodeRootResult Parse(Tokeniser t)
        {
            string errorMessage = "";
            string arg;
            Int32 tmp = 0;

            if (!(t.IsArgument(out arg) && t.IsEnd && Int32.TryParse(arg, out tmp)))
            {
                errorMessage = "error line " + t.CurentLigne;
            }

            return (new OpCodeRootResult(errorMessage, new ldlocOpCode(tmp, t.CurentLigne)));
        }
    }

    public class PrototypeOpCodeRoot : OpCodeRoot
    {
        public PrototypeOpCodeRoot()
        {
            base._name = "prototype";
            base._type = "directive";
        }

        public override OpCodeRootResult Parse(Tokeniser t)
        {
            FunctionAnnexe f = new FunctionAnnexe();
            string errorMessage = "";
            string name = "";
            Type type = null;
            List<StackItemValue> args = new List<StackItemValue>();
            Type argsType;
            string argsName;

            if (t.IsEnd) return (new OpCodeRootResult(errorMessage, null));

            if (t.IsString(out argsName) && t.MatchSpace() && t.IsString(out name) && t.MatchOpenPar())
            {
                if (!f.IsType(argsName, out type)) errorMessage = "type " + argsName + " not existing line :" + t.CurentLigne;
                do
                {
                    t.MatchSpace();
                    if (t.IsString(out argsName))
                    {

                        if (!f.IsType(argsName, out argsType)) errorMessage = "type " + argsName + " not existing line :" + t.CurentLigne;
                        t.MatchSpace();
                        t.IsString(out argsName);
                        args.Add(new StackItemValue(argsType, ""));

                        t.MatchSpace();
                    }
                } while (t.MatchComma());

                if (!t.MatchClosePar()) errorMessage = "syntaxe error in declaration of function " + name;
            }
            else errorMessage = "syntaxe error line :" + t.CurentLigne;

            return (new OpCodeRootResult(errorMessage, new PrototypeOpCode(name, type, args, t.CurentLigne)));
        }
    }

    public class CallOpCodeRoot : OpCodeRoot
    {
        public CallOpCodeRoot()
        {
            base._name = "call";
            base._type = "operation";
        }

        public override OpCodeRootResult Parse(Tokeniser t)
        {
            FunctionAnnexe f = new FunctionAnnexe();
            string errorMessage = "";
            string name = "";

            if (!(t.MatchSpace() && t.IsString(out name))) errorMessage = "syntaxe error line :" + t.CurentLigne;

            return (new OpCodeRootResult(errorMessage,new CallOpCode(name, t.CurentLigne)));
        }
    }

    public class stargOpCodeRoot : OpCodeRoot
    {
        public stargOpCodeRoot()
        {
            base._name = "starg";
            base._type = "operation";
        }

        public override OpCodeRootResult Parse(Tokeniser t)
        {
            string errorMessage = "";
            string arg;
            Int32 tmp = 0;

            if (!(t.IsArgument(out arg) && t.IsEnd && Int32.TryParse(arg, out tmp)))
            {
                errorMessage = "error line " + t.CurentLigne;
            }

            return (new OpCodeRootResult(errorMessage, new stargOpCode(tmp, t.CurentLigne)));
        }
    }

    public class ldargOpCodeRoot : OpCodeRoot
    {
        public ldargOpCodeRoot()
        {
            base._name = "ldarg";
            base._type = "operation";
        }

        public override OpCodeRootResult Parse(Tokeniser t)
        {
            string errorMessage = "";
            string arg;
            Int32 tmp = 0;

            if (!(t.IsArgument(out arg) && t.IsEnd && Int32.TryParse(arg, out tmp)))
            {
                errorMessage = "error line " + t.CurentLigne;
            }

            return (new OpCodeRootResult(errorMessage, new ldargOpCode(tmp, t.CurentLigne)));
        }
    }
}
