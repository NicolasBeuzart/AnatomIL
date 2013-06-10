using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnatomIL
{
    public class EnumManager
    {
        readonly Dictionary<string, int> _values;

        public EnumManager()
        {
            _values = new Dictionary<string, int>();
        }

        public void Register(Type typeEnum, string enumName)
        {
            if (!typeEnum.IsEnum) throw new ArgumentException("Must be an enum!", "typeEnum");
            foreach (var val in Enum.GetValues(typeEnum))
            {
                string myName = enumName + '.' + val.ToString();
                _values.Add(myName, (int)val);
            }
        }

        public bool IsEnumValue(Tokeniser t, out int value, out string errorMessage)
        {
            errorMessage = "";
            string potentialEnumName;

            if (t.IsRegex(@"^\p{L}\w*\.[a-zA-Z]\w*", out potentialEnumName))
            {
                if (_values.TryGetValue(potentialEnumName, out value)) return true;
                errorMessage = String.Format("At line {0}: Unknow enum value ", t.CurentLigne + 1);
            }
            value = -1;
            return false;
        }

    }
}
