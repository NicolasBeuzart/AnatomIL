using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnatomIL
{
    public class Compilator
    {
        List<CodeOpRoot> _operations;
        Library _lib;

        public Compilator()
        {
            _operations = new List<CodeOpRoot>();
            _lib = new Library();
            _lib.LibAddCodeOpRoot(new AddCodeOpRoot());
            _lib.LibAddCodeOpRoot(new SubCodeOpRoot());
            _lib.LibAddCodeOpRoot(new MulCodeOpRoot());
            _lib.LibAddCodeOpRoot(new DivCodeOpRoot());
            _lib.LibAddCodeOpRoot(new RemCodeOpRoot());
            _lib.LibAddCodeOpRoot(new LdcCodeOpRoot());
        }

        public List<CodeOpRoot> compile(string[] instructions, Stack s)
        {
            for (int i = 0; i < instructions.Length; i++ )
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
                    if (_lib.LibIsCodeOpRootExiste(operation)) _operations.Add(_lib.LibFindOpCodeRoot(operation));
                    else
                    {
                        throw new Exception("Compilation error : line " + (i + 1).ToString() + ", instruction : \"" + operation + "\" can't be found in library");
                    }
                }
                else
                {
                    _operations.Add(null);
                }
            }
            return _operations;
        }
    }
}
