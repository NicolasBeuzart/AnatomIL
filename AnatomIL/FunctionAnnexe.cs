using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnatomIL
{
    class FunctionAnnexe
    {
        public bool IsType(string argsName, out Type type)
        {
            type = null;
            if (argsName == "int32") type = typeof(Int32);
            else if (argsName == "int16") type = typeof(Int16);
            else if (argsName == "int64") type = typeof(Int64);
            else if (argsName == "bool") type = typeof(bool);
            else if (argsName == "char") type = typeof(char);
            else if (argsName == "void") type = typeof(void);

            if (type == null) return false;
            else return true;
        }
    }
}
