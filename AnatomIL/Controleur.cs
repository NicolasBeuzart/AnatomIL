using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnatomIL
{
    public class Controleur
    {
        public int _pc; // registre
        Stack _s; // pile
        Compilator _compilator;
        List<CodeOpRoot> _operations;
        string[] _instructions;

        public Controleur() // initialisation
        {
            _pc = 0;
            _s = new Stack();
            _compilator = new Compilator();
        }

        public Stack s
        {
            get { return _s; }
        }

        public void compile(string[] insts)
        {
            _instructions = insts;
            _operations = _compilator.compile(insts, _s);
            _pc = FirstInstruction();
        }

        public int GoToNextInst(int pc)
        {
            int result = pc + 1;
            while (result < _operations.Count && _operations[result] == null)
            {
                result++;
            }
            return result;
        }

        public void ExecuteNextInstruction()
        {
            _operations[_pc].Parse(_instructions[_pc],_s).Execute(_s);

            //on passe à l'instruction suivante
            _pc = GoToNextInst(_pc);
            //_pc++;
        }


        public int FirstInstruction()
        {
            return GoToNextInst(-1);
        }

        public void reset()
        {
            _pc = 0;
            _s = new Stack();
        }
    }
}
