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

        override public OpCodeRootResult Parse(List<string> options, List<string> args)
        {
            string errorMessage = "";

            if (options.Count() != 0 && (args.Count() < 1 || (args.Count() > 1 && args[1] != "")))
            {
                errorMessage = "Bad arguments in Operation" + base._name;
            }

            return new OpCodeRootResult(errorMessage, new BrOpCode(args[0]));
        }
    }

    public class BeqOpCodeRoot : OpCodeRoot
    {
        public BeqOpCodeRoot()
        {
            base._name = "beq";
        }

        override public OpCodeRootResult Parse(List<string> options, List<string> args)
        {
            string errorMessage = "";

            if (options.Count() != 0 && (args.Count() < 1 || (args.Count() > 1 && args[1] != "")))
            {
                errorMessage = "Bad arguments in Operation" + base._name;
            }

            return new OpCodeRootResult(errorMessage, new BeqOpCode(args[0]));
        }
    }

    public class BgeOpCodeRoot : OpCodeRoot
    {
        public BgeOpCodeRoot()
        {
            base._name = "bge";
        }

        override public OpCodeRootResult Parse(List<string> options, List<string> args)
        {
            string errorMessage = "";

            if (options.Count() != 0 && (options.Count() != 1 || options[0] != "un") ||
                (args.Count() < 1 || (args.Count() > 1 && args[1] != "")))
            {
                errorMessage = "Bad arguments in Operation" + base._name;
            }
            return new OpCodeRootResult(errorMessage, new BgeOpCode(args[0], options.Count() == 1 && options[0] == "un"));
        }
    }

    public class BgtOpCodeRoot : OpCodeRoot
    {
        public BgtOpCodeRoot()
        {
            base._name = "bgt";
        }

        override public OpCodeRootResult Parse(List<string> options, List<string> args)
        {
            string errorMessage = "";

            if (options.Count() != 0 && (options.Count() != 1 || options[0] != "un") ||
               (args.Count() < 1 || (args.Count() > 1 && args[1] != "")))
            {
                errorMessage = "Bad arguments in Operation" + base._name;
            }
            return new OpCodeRootResult(errorMessage, new BgtOpCode(args[0], options.Count() == 1 && options[0] == "un"));
        }
    }

    public class BleOpCodeRoot : OpCodeRoot
    {
        public BleOpCodeRoot()
        {
            base._name = "ble";
        }

        override public OpCodeRootResult Parse(List<string> options, List<string> args)
        {
            string errorMessage = "";

            if (options.Count() != 0 && (options.Count() != 1 || options[0] != "un") ||
               (args.Count() < 1 || (args.Count() > 1 && args[1] != "")))
            {
                errorMessage = "Bad arguments in Operation" + base._name;
            }
            return new OpCodeRootResult(errorMessage, new BleOpCode(args[0], options.Count() == 1 && options[0] == "un"));
        }
    }

    public class BltOpCodeRoot : OpCodeRoot
    {
        public BltOpCodeRoot()
        {
            base._name = "blt";
        }

        override public OpCodeRootResult Parse(List<string> options, List<string> args)
        {
            string errorMessage = "";

            if (options.Count() != 0 && (options.Count() != 1 || options[0] != "un") ||
               (args.Count() < 1 || (args.Count() > 1 && args[1] != "")))
            {
                errorMessage = "Bad arguments in Operation" + base._name;
            }
            return new OpCodeRootResult(errorMessage, new BltOpCode(args[0], options.Count() == 1 && options[0] == "un"));
        }
    }

    public class BneOpCodeRoot : OpCodeRoot
    {
        public BneOpCodeRoot()
        {
            base._name = "blt";
        }

        override public OpCodeRootResult Parse(List<string> options, List<string> args)
        {
            string errorMessage = "";

            if (options.Count() != 0 && (options.Count() != 1 || options[0] != "un") ||
               (args.Count() < 1 || (args.Count() > 1 && args[1] != "")))
            {
                errorMessage = "Bad arguments in Operation" + base._name;
            }
            return new OpCodeRootResult(errorMessage, new BneOpCode(args[0], options.Count() == 1 && options[0] == "un"));
        }
    }

    public class BrfalseOpCodeRoot : OpCodeRoot
    {
        public BrfalseOpCodeRoot()
        {
            base._name = "brfalse";
        }

        override public OpCodeRootResult Parse(List<string> options, List<string> args)
        {
            string errorMessage = "";

            if (options.Count() != 0 && (args.Count() < 1 || (args.Count() > 1 && args[1] != "")))
            {
                errorMessage = "Bad arguments in Operation" + base._name;
            }

            return new OpCodeRootResult(errorMessage, new BrfalseOpCode(args[0]));
        }
    }

    public class BrtrueOpCodeRoot : OpCodeRoot
    {
        public BrtrueOpCodeRoot()
        {
            base._name = "brtrue";
        }

        override public OpCodeRootResult Parse(List<string> options, List<string> args)
        {
            string errorMessage = "";

            if (options.Count() != 0 && (args.Count() < 1 || (args.Count() > 1 && args[1] != "")))
            {
                errorMessage = "Bad arguments in Operation" + base._name;
            }

            return new OpCodeRootResult(errorMessage, new BrtrueOpCode(args[0]));
        }
    }

    public class BrzeroOpCodeRoot : OpCodeRoot
    {
        public BrzeroOpCodeRoot()
        {
            base._name = "brzero";
        }

        override public OpCodeRootResult Parse(List<string> options, List<string> args)
        {
            string errorMessage = "";

            if (options.Count() != 0 && (args.Count() < 1 || (args.Count() > 1 && args[1] != "")))
            {
                errorMessage = "Bad arguments in Operation" + base._name;
            }

            return new OpCodeRootResult(errorMessage, new BrzeroOpCode(args[0]));
        }
    }

    public class BrnullOpCodeRoot : OpCodeRoot
    {
        public BrnullOpCodeRoot()
        {
            base._name = "brnull";
        }

        override public OpCodeRootResult Parse(List<string> options, List<string> args)
        {
            string errorMessage = "";

            if (options.Count() != 0 && (args.Count() < 1 || (args.Count() > 1 && args[1] != "")))
            {
                errorMessage = "Bad arguments in Operation" + base._name;
            }

            return new OpCodeRootResult(errorMessage, new BrnullOpCode(args[0]));
        }
    }

    public class BrinstOpCodeRoot : OpCodeRoot
    {
        public BrinstOpCodeRoot()
        {
            base._name = "brinst";
        }

        override public OpCodeRootResult Parse(List<string> options, List<string> args)
        {
            string errorMessage = "";

            if (options.Count() != 0 && (args.Count() < 1 || (args.Count() > 1 && args[1] != "")))
            {
                errorMessage = "Bad arguments in Operation" + base._name;
            }

            return new OpCodeRootResult(errorMessage, new BrinstOpCode(args[0]));
        }
    }
}
