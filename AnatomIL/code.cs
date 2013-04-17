using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnatomIL
{
    public class Code // base de code rentré par l'utilisateur
    {
        string[] _instructions;

        public string[] Instructions
        {
            get { return _instructions; }

            set
            {
                _instructions = value;
            }
        }

        public string CurentInstruction(int pc)
        {
            return (_instructions[pc]);
        }

    }
}
