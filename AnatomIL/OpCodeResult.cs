using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnatomIL
{
    public class OpCodeResult
    {
        public string ErrorMessage;

        public OpCodeResult(string errorMessage)
        {
            ErrorMessage = errorMessage;
        }
    }
}
