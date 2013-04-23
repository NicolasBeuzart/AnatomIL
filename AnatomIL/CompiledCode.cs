using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnatomIL
{
    public class CompiledCode
    {
        public IReadOnlyList<OpCode> Code { get; private set; }

        public bool IsExecutable(int i)
        {
            return (Code[i].IsExecutable);
        }

        public CompiledCode(List<OpCode> code)
        {
            Code = code;
        }

        public int Count
        {
            get { return Code.Count; }
        }

        public bool IsNull(int i)
        {
            return (Code[i] == null);
        }

        public int IndexLabel(string label)
        {
            int result = 0;

            for (result = 0; (result < Code.Count()) && (Code[result]._name != ":" + label); result++) ;

            return (result);
        }
    }

    public class CompilerResult
    {

        public bool IsSuccess { get { return ErrorMessages.Count == 0; } }

        public IReadOnlyList<string> ErrorMessages { get; internal set; }


        /// <summary>
        /// Null if at least one error exists in <see cref="ErrorMessages"/>.
        /// </summary>
        public CompiledCode Code;


        internal CompilerResult( List<string> errormessages)
        {
            ErrorMessages = errormessages;
        }

        internal CompilerResult(CompiledCode code)
        {
            Code = code;
            ErrorMessages = new List<string>();
        }

    }
}
