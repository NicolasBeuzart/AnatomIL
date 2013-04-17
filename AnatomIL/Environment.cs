using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnatomIL
{
    public class Environment
    {
        public Stack Stack;
        public Registre Pc;
        public Tas Tas;
        public string[] Code;
        public List<CodeOpRoot> _operations;

        public Environment()
        {
            Stack = new Stack();
            Pc.Pc = -1;
        }

        public void reset()
        {
            Stack = new Stack();
            Pc.Pc = -1;
        }

        public int GoToNextInst()
        {
           Pc.Pc++;

            while (Pc.Pc < _operations.Count && _operations[Pc.Pc] == null)
            {
                Pc.Pc++;
            }

            return Pc.Pc;
        }

        public void compile(Compilator c)
        {
            _operations = c.compile(Code, Stack);
            Pc.Pc = GoToNextInst();
        }
    }
}
