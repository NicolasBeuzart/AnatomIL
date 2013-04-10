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
        string[] instructions;

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
          //  "Ldc.i4.33"
          // 0 "ldc"
           // 1 "i4"
            // 2 "33"
            instructions = _code.CurentInstruction(_pc).Split('.');
            _methode = _lib.FindMethode(instructions[0]);
            _methode.GetType();
            _methode.Execute(instructions, _s);
            if (_lib.IsMethodeExiste(instructions[0]))
            {
                if (instructions[0] == "add")
                {
                    add tmp = (add)_lib.FindMethode(instructions[0]);
                    _s = tmp.Execute(instructions, _s);
                }
                else if (instructions[0] == "sub")
                {
                    sub tmp = (sub)_lib.FindMethode(instructions[0]);
                    _s = tmp.Execute(instructions, _s);
                }
                else if (instructions[0] == "mul")
                {
                    mul tmp = (mul)_lib.FindMethode(instructions[0]);
                    _s = tmp.Execute(instructions, _s);
                }
                else if (instructions[0] == "div")
                {
                    div tmp = (div)_lib.FindMethode(instructions[0]);
                    _s = tmp.Execute(instructions, _s);
                }
                else if (instructions[0] == "rem")
                {
                    rem tmp = (rem)_lib.FindMethode(instructions[0]);
                    _s = tmp.Execute(instructions, _s);
                }
                else if (instructions[0] == "ldc")
                {
                    ldc tmp = (ldc)_lib.FindMethode(instructions[0]);
                    tmp.Execute(instructions, _s);
                }
              //  _lib.FindMethode(instruction).Execute(_code.Instructions, _s);
            }
            _pc++;
        }

    }
}
