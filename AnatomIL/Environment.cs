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
        public int Pc;
        public Heap Heap;
        public CompiledCode CompiledCode;
        public Dictionary<string, int> _nbLocals= new Dictionary<string, int>();

        public Environment()
        {
            Stack = new Stack();
            _nbLocals.Add("main", 0);
            Pc = -1;
        }

        public void Reset()
        {
            Stack = new Stack();
            Pc = -1;
        }
    }
}
