using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnatomIL
{
    public class CompiledCode
    {
        public IReadOnlyList<CodeOpRoot> Code { get; private set; }

        public CompiledCode(List<CodeOpRoot> code)
        {
            Code = code;
        }

        public int Count
        {
            get { return Code.Count; }
        }
    }

    public class CompilerResult
    {

        public bool IsSuccess { get { return ErrorMessages.Count == 0; } }

        public IReadOnlyList<string> ErrorMessages { get; internal set; }

        /// <summary>
        /// Null if at least one error exists in <see cref="ErrorMessages"/>.
        /// </summary>
        private CompiledCode _code { get; private set; }

        internal CompilerResult( List<string> errormessages)
        {
            ErrorMessages = errormessages;
        }

        internal CompilerResult(CompiledCode code)
        {
            _code = code;
            ErrorMessages = new List<string>();
        }

        public int Count
        {
            get { return _code.Count; }
        }
        /// <summary>
        /// Check if the CodeOpRoot of index i is null
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public bool IsNull(int i)
        {
            return (_code.Code[i] == null);
        }
    }
}
