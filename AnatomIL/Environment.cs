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

        public Environment()
        {
            Stack = new Stack();
            Pc = -1;
        }

        public void Reset()
        {
            Stack = new Stack();
            Pc = -1;
        }
    }
}
