using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnatomIL
{
    public class BrOpCodeRoot : OpCodeRoot
    {

        public BrOpCodeRoot()
        {
            base._name = "br";
        }

        override public OpCodeRootResult Parse(Tokeniser t)
        {
            string errorMessage = "";
            string label;

            if (!(t.IsArgument(out label) && t.IsEnd))
            {
                errorMessage = "Bad utilisation of Operation" + base._name + "in line : " + t.CurentLigne;
            }

            return new OpCodeRootResult(errorMessage, new BrOpCode(label));
        }
    }

    public class BeqOpCodeRoot : OpCodeRoot
    {
        public BeqOpCodeRoot()
        {
            base._name = "beq";
        }

        override public OpCodeRootResult Parse(Tokeniser t)
        {
            string errorMessage = "";
            string label;

            if (!(t.IsArgument(out label) && t.IsEnd))
            {
                errorMessage = "Bad utilisation of Operation" + base._name + "in line : " + t.CurentLigne;
            }

            return new OpCodeRootResult(errorMessage, new BeqOpCode(label));
        }
    }

    public class BgeOpCodeRoot : OpCodeRoot
    {
        public BgeOpCodeRoot()
        {
            base._name = "bge";
        }

        override public OpCodeRootResult Parse(Tokeniser t)
        {
            string errorMessage = "";
            string option;
            string label;

            if (t.IsOption(out option) && option != "un")
            {
                errorMessage = "option \"" + option + "\" in Operation" + base._name + " don't existe.";
            }

            if (!(t.IsArgument(out label) && t.IsEnd))
            {
                errorMessage = "Bad utilisation of Operation" + base._name + "in line : " + t.CurentLigne;
            }

            return new OpCodeRootResult(errorMessage, new BgeOpCode(label, option == "un"));
        }
    }

    public class BgtOpCodeRoot : OpCodeRoot
    {
        public BgtOpCodeRoot()
        {
            base._name = "bgt";
        }

        override public OpCodeRootResult Parse(Tokeniser t)
        {
            string errorMessage = "";
            string option;
            string label;

            if (t.IsOption(out option) && option != "un")
            {
                errorMessage = "option \"" + option + "\" in Operation" + base._name + " don't existe.";
            }

            if (!(t.IsArgument(out label) && t.IsEnd))
            {
                errorMessage = "Bad utilisation of Operation" + base._name + "in line : " + t.CurentLigne;
            }

            return new OpCodeRootResult(errorMessage, new BgtOpCode(label, option == "un"));
        }
    }

    public class BleOpCodeRoot : OpCodeRoot
    {
        public BleOpCodeRoot()
        {
            base._name = "ble";
        }

        override public OpCodeRootResult Parse(Tokeniser t)
        {
            string errorMessage = "";
            string option;
            string label;

            if (t.IsOption(out option) && option != "un")
            {
                errorMessage = "option \"" + option + "\" in Operation" + base._name + " don't existe.";
            }

            if (!(t.IsArgument(out label) && t.IsEnd))
            {
                errorMessage = "Bad utilisation of Operation" + base._name + "in line : " + t.CurentLigne;
            }

            return new OpCodeRootResult(errorMessage, new BleOpCode(label, option == "un"));
        }
    }

    public class BltOpCodeRoot : OpCodeRoot
    {
        public BltOpCodeRoot()
        {
            base._name = "blt";
        }

        override public OpCodeRootResult Parse(Tokeniser t)
        {
            string errorMessage = "";
            string option;
            string label;

            if (t.IsOption(out option) && option != "un")
            {
                errorMessage = "option \"" + option + "\" in Operation" + base._name + " don't existe.";
            }

            if (!(t.IsArgument(out label) && t.IsEnd))
            {
                errorMessage = "Bad utilisation of Operation" + base._name + "in line : " + t.CurentLigne;
            }

            return new OpCodeRootResult(errorMessage, new BltOpCode(label, option == "un"));
        }
    }

    public class BneOpCodeRoot : OpCodeRoot
    {
        public BneOpCodeRoot()
        {
            base._name = "blt";
        }

        override public OpCodeRootResult Parse(Tokeniser t)
        {
            string errorMessage = "";
            string option;
            string label;

            if (t.IsOption(out option) && option != "un")
            {
                errorMessage = "option \"" + option + "\" in Operation" + base._name + " don't existe.";
            }

            if (!(t.IsArgument(out label) && t.IsEnd))
            {
                errorMessage = "Bad utilisation of Operation" + base._name + "in line : " + t.CurentLigne;
            }

            return new OpCodeRootResult(errorMessage, new BneOpCode(label, option == "un"));
        }
    }

    public class BrfalseOpCodeRoot : OpCodeRoot
    {
        public BrfalseOpCodeRoot()
        {
            base._name = "brfalse";
        }

        override public OpCodeRootResult Parse(Tokeniser t)
        {
            string errorMessage = "";
            string label;

            if (!(t.IsArgument(out label) && t.IsEnd))
            {
                errorMessage = "Bad utilisation of Operation" + base._name + "in line : " + t.CurentLigne;
            }

            return new OpCodeRootResult(errorMessage, new BrfalseOpCode(label));
        }
    }

    public class BrtrueOpCodeRoot : OpCodeRoot
    {
        public BrtrueOpCodeRoot()
        {
            base._name = "brtrue";
        }

        override public OpCodeRootResult Parse(Tokeniser t)
        {
            string errorMessage = "";
            string label;

            if (!(t.IsArgument(out label) && t.IsEnd))
            {
                errorMessage = "Bad utilisation of Operation" + base._name + "in line : " + t.CurentLigne;
            }

            return new OpCodeRootResult(errorMessage, new BrtrueOpCode(label));
        }
    }

    public class BrzeroOpCodeRoot : OpCodeRoot
    {
        public BrzeroOpCodeRoot()
        {
            base._name = "brzero";
        }

        override public OpCodeRootResult Parse(Tokeniser t)
        {
            string errorMessage = "";
            string label;

            if (!(t.IsArgument(out label) && t.IsEnd))
            {
                errorMessage = "Bad utilisation of Operation" + base._name + "in line : " + t.CurentLigne;
            }

            return new OpCodeRootResult(errorMessage, new BrzeroOpCode(label));
        }
    }

    public class BrnullOpCodeRoot : OpCodeRoot
    {
        public BrnullOpCodeRoot()
        {
            base._name = "brnull";
        }

        override public OpCodeRootResult Parse(Tokeniser t)
        {
            string errorMessage = "";
            string label;

            if (!(t.IsArgument(out label) && t.IsEnd))
            {
                errorMessage = "Bad utilisation of Operation" + base._name + "in line : " + t.CurentLigne;
            }

            return new OpCodeRootResult(errorMessage, new BrzeroOpCode(label));
        }
    }

    public class BrinstOpCodeRoot : OpCodeRoot
    {
        public BrinstOpCodeRoot()
        {
            base._name = "brinst";
        }

        override public OpCodeRootResult Parse(Tokeniser t)
        {
            string errorMessage = "";
            string label;

            if (!(t.IsArgument(out label) && t.IsEnd))
            {
                errorMessage = "Bad utilisation of Operation" + base._name + "in line : " + t.CurentLigne;
            }

            return new OpCodeRootResult(errorMessage, new BrinstOpCode(label));
        }
    }
}
