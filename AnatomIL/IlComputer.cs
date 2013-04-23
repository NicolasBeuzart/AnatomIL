using System;
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

        public void LoadCode(string[] Sourcecode)
        {
            _Sourcecode = Sourcecode;
        }

        public void compile()
        {
            CompilerResult compilerResult = _compiler.Compile(_Sourcecode);
            if (compilerResult.IsSuccess)
            {
                _compiledCode = compilerResult.Code;
            }
            else
            {
                ErrorMessages.AddRange(compilerResult.ErrorMessages);
            }
        }

        public void Start()
        {
            Pc = FirstInstruction();
        }

        public int GoToNextInst(int pc)
        {
            int result = pc + 1;
            while (result < _compiledCode.Count && _compiledCode.IsNull(result) && !_compiledCode.IsExecutable(result))
            {
                result++;
            }
            return result;
        }

        public void ExecuteNextInstruction()
        {
            _compiledCode.Code[Pc].Execute(_env);

            //on passe à l'instruction suivante
            Pc = GoToNextInst(Pc);
        }


        public int FirstInstruction()
        {
            return GoToNextInst(-1);
        }

        public void reset()
        {
            _env.Reset();
            ErrorMessages = new List<string>();
        }
    }
}
