using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnatomIL
{
    public class parser
    {
        int _pc; // registre
        Library _lib; // library des méthodes
        CodeOpRoot _methode; // méthode courante
        code _code; // code rentré par l'utilisateur
        Stack _s; // pile

        public parser() // initialisation
        {
            _pc = 0;
            _lib = new Library();
            _code = new code();
            _methode = new CodeOpRoot();
            _s = new Stack();
            _lib.LibAddCodeOpRoot(new AddCodeOpRoot());
            _lib.LibAddCodeOpRoot(new SubCodeOpRoot());
            _lib.LibAddCodeOpRoot(new MulCodeOpRoot());
            _lib.LibAddCodeOpRoot(new DivCodeOpRoot());
            _lib.LibAddCodeOpRoot(new RemCodeOpRoot());
            _lib.LibAddCodeOpRoot(new LdcCodeOpRoot());
        }

        public Stack s
        {
            get { return _s; }
        }

        public Library Lib
        {
            get { return _lib; }
        }

        public code Code
        {
            get { return _code; }
            
            set
            {
                _code = value;
            }
        }

        public void ExecuteNextInstruction()
        {
            string instruction = _code.CurentInstruction(_pc);
            
            // retire les espace et . en trop
            instruction = instruction.Replace(' ','.');
            while (instruction.Contains(".."))
            {
                instruction = instruction.Replace("..", ".");
            }

            // on recupére le nom de la méthode et les arguments
            string operation = instruction.Split('.', ' ')[0];

            CodeOp Operation = _lib.LibFindOpCodeRoot(operation).Parse(instruction, _s);

            Operation.Execute(_s);
            //on passe à l'instruction suivante
            _pc++;
        }

    }
}
