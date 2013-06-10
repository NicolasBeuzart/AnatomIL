using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AnatomIL
{
    public class Environment
    {
        public Stack Stack;
        public int Pc;
        public Heap Heap;
        public CompiledCode CompiledCode;
        public Graph Graph;

        readonly EnumManager _enumManager;

        public EnumManager EnumManager { get { return _enumManager; } }

        public Environment()
        {
            Stack = new Stack();
            Graph = new Graph();

            _enumManager = new EnumManager();
            EnumManager.Register(typeof(KnownColor), "Color");

            Pc = -1;
        }

        public void Reset()
        {
            Stack = new Stack();
            Graph = new Graph();
            Pc = -1;
        }
    }
}
