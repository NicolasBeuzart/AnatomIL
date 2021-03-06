﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnatomIL
{
    public class IlComputer
    {
        Compiler _compiler;
        CompiledCode _compiledCode;
        string[] _Sourcecode;
        public List<string> ErrorMessages;
        Environment _env; // Pc, Stack, Tas

        public IlComputer() // initialisation
        {
            _env = new Environment();
            ErrorMessages = new List<string>();
            _compiler = new Compiler();
        }

        public int Pc { get { return _env.Pc; } internal set { _env.Pc = value; } }

        public Stack Stack { get { return _env.Stack; } }

        public Graph Graph { get { return _env.Graph; } }

        public void LoadCode(string[] Sourcecode)
        {
            _Sourcecode = Sourcecode;
        }

        public void compile()
        {
            CompilerResult compilerResult = _compiler.Compile(new Tokeniser(_Sourcecode));
            if (compilerResult.IsSuccess)
            {
                _compiledCode = compilerResult.Code;
                _env.CompiledCode = _compiledCode;
            }
            else
            {
                ErrorMessages.AddRange(compilerResult.ErrorMessages);
            }
        }

        public void Start()
        {
            int i = -1;
            foreach (OpCode o in _compiledCode.Code)
            {
                if (o != null && o.NameFrame == "main") Pc = i;
                i++;
            }
            _env.Stack.PushFrame(new List<StackItemValue>(), new List<StackItemValue>(), null, null);
            Pc = GoToNextInst(Pc);
        }

        public int GoToNextInst(int pc)
        {
            int result = pc + 1;
            while (result < _compiledCode.Count && (_compiledCode.IsNull(result) || !_compiledCode.IsExecutable(result)))
            {
                result++;
            }

            if (_compiledCode.Count - 1 > result && _compiledCode.IsDirective(result))
            {
                _compiledCode.Code[result].Execute(_env);
                return GoToNextInst(result);
            }
            else return result;
        }

        public void ExecuteNextInstruction()
        {

            OpCodeResult o;

            o = _compiledCode.Code[Pc].Execute(_env);
           
            if (o.ErrorMessage != "") ErrorMessages.Add(o.ErrorMessage);
            //on passe à l'instruction suivante
            Pc = GoToNextInst(Pc);
        }

        public void reset()
        {
            _env.Reset();
            ErrorMessages = new List<string>();
        }

    }
}
