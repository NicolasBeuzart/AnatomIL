using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnatomIL
{
    public class parser
    {
        int _pc;
        Library _lib;
        Methode _methode;
        code _code;
        Stack _s;
        public parser()
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
            _methode = _lib.FindMethode(instruction);
            _methode.GetType();
            _methode.Execute(_code.Instructions, _s);
            if (_lib.IsMethodeExiste(instruction))
            {
                if (instruction == "add")
                {
                    add tmp = (add)_lib.FindMethode(instruction);
                    tmp.Execute(_code.Instructions, _s);
                }
                else if (instruction == "sub")
                {
                    sub tmp = (sub)_lib.FindMethode(instruction);
                    tmp.Execute(_code.Instructions, _s);
                }
                else if (instruction == "mul")
                {
                    mul tmp = (mul)_lib.FindMethode(instruction);
                    tmp.Execute(_code.Instructions, _s);
                }
                else if (instruction == "div")
                {
                    div tmp = (div)_lib.FindMethode(instruction);
                    tmp.Execute(_code.Instructions, _s);
                }
                else if (instruction == "rem")
                {
                    rem tmp = (rem)_lib.FindMethode(instruction);
                    tmp.Execute(_code.Instructions, _s);
                }
              //  _lib.FindMethode(instruction).Execute(_code.Instructions, _s);
            }
            _pc++;
        }

    }
}
