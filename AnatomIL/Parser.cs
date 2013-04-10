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

        public parser()
        {
            _pc = 0;
            _lib = new Library();
            _code = new code();
            _methode = new Methode();
            _lib.AddMethode(new add());
            _lib.AddMethode(new sub());
            _lib.AddMethode(new mul());
            _lib.AddMethode(new div());
            _lib.AddMethode(new rem());
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
            if (_lib.IsMethodeExiste(instruction))
            {
                _methode = _lib.FindMethode(instruction);
                _lib.FindMethode(instruction).Execute(_code.Instructions);
            }
            _pc++;
        }

    }
}
