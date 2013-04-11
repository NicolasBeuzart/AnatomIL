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
        Methode _methode; // méthode courante
        code _code; // code rentré par l'utilisateur
        Stack _s; // pile
        string[] instructions; // instruction courante

        public parser() // initialisation
        {
            _pc = 0;
            _lib = new Library();
            _code = new code();
            _methode = new Methode();
            _s = new Stack();
            _lib.AddMethode(new add());
            _lib.AddMethode(new sub());
            _lib.AddMethode(new mul());
            _lib.AddMethode(new div());
            _lib.AddMethode(new rem());
            _lib.AddMethode(new ldc());
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
            string st = _code.CurentInstruction(_pc);
            
            // retire les espace et . en trop
            st = st.Replace(' ','.');
            while (st.Contains(".."))
            {
                st = st.Replace("..", ".");
            }

            // on recupére le nom de la méthode et les arguments
            instructions = st.Split(new char[] {'.',' '});

            _lib.FindMethode(instructions[0]).Execute(instructions, _s); ;
            
            //temporaire
            //if (_lib.IsMethodeExiste(instructions[0]))
            //{
            //    if (instructions[0] == "add")
            //    {
            //        add tmp = (add)_lib.FindMethode(instructions[0]);
            //        tmp.Execute(instructions, _s);
            //    }
            //    else if (instructions[0] == "sub")
            //    {
            //        sub tmp = (sub)_lib.FindMethode(instructions[0]);
            //        tmp.Execute(instructions, _s);
            //    }
            //    else if (instructions[0] == "mul")
            //    {
            //        mul tmp = (mul)_lib.FindMethode(instructions[0]);
            //        tmp.Execute(instructions, _s);
            //    }
            //    else if (instructions[0] == "div")
            //    {
            //        div tmp = (div)_lib.FindMethode(instructions[0]);
            //        tmp.Execute(instructions, _s);
            //    }
            //    else if (instructions[0] == "rem")
            //    {
            //        rem tmp = (rem)_lib.FindMethode(instructions[0]);
            //        tmp.Execute(instructions, _s);
            //    }
            //    else if (instructions[0] == "ldc")
            //    {
            //        ldc tmp = (ldc)_lib.FindMethode(instructions[0]);
            //        tmp.Execute(instructions, _s);
            //    }
            //}

            //on passe à l'instruction suivante
            _pc++;
        }

    }
}
