using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnatomIL
{
    public class Compiler
    {
        Library _lib;

        public Compiler()
        {
            _lib = new Library();
            _lib.LibAddCodeOpRoot(new AddOpCodeRoot());
            _lib.LibAddCodeOpRoot(new SubCodeOpRoot());
            _lib.LibAddCodeOpRoot(new MulCodeOpRoot());
            _lib.LibAddCodeOpRoot(new DivCodeOpRoot());
            _lib.LibAddCodeOpRoot(new RemCodeOpRoot());
            _lib.LibAddCodeOpRoot(new LdcCodeOpRoot());
            _lib.LibAddCodeOpRoot(new BrCodeOpRoot());
            _lib.LibAddCodeOpRoot(new LabelOpCodeRoot());
        }

        public CompilerResult Compile(string[] instructions)
        {
            List<OpCode> code = new List<OpCode>();
            List<string> errorMessages = new List<string>();
            OpCodeRootResult result;

            for (int i = 0; i < instructions.Count(); i++ )
            {
                // retire les espace et . en trop
                string instruction = instructions[i];
                instruction.Replace(' ', '.');
                while (instruction.Contains(".."))
                {
                    instruction.Replace("..", ".");
                }

                if (instruction != "")
                {
                    // on recupére le nom de la méthode et les arguments
                    string operation = instruction.Split('.', ' ')[0];
                    if (_lib.LibIsCodeOpRootExiste(operation))
                    {
                        result = _lib.LibFindOpCodeRoot(operation).Parse(instruction);

                        if (result.IsSuccess) code.Add(result.OpCode);
                        else errorMessages.Add("Error line " + i.ToString() + " : " + result.ErrorMessage);
                    }
                    else
                    {
                        errorMessages.Add("Compilation error : line " + (i + 1).ToString() + ", instruction : \"" + operation + "\" can't be found in library");
                    }
                }
                else
                {
                    code.Add(null);
                }
            }

            if (errorMessages.Count == 0)
            {
                return new CompilerResult(new CompiledCode(code));
            }
            else
            {
                return new CompilerResult(errorMessages);
            }
        }
    }
}
