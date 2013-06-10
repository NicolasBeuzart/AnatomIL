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

        internal EnumManager()
        {
            _values = new Dictionary<string, int>();
        }

        public void Register(Type typeEnum, string enumName)
        {
            if (!typeEnum.IsEnum) throw new ArgumentException("Must be an enum!", "typeEnum");
            foreach (var val in Enum.GetValues(typeEnum))
            {
                int i = 0;
                string myName = enumName + '.' + val.ToString();
                _values.Add(myName, i);
                i++;
            }
        }

        public bool IsEnumValue(Tokeniser t, out int value, out string errorMessage)
        {
            errorMessage = "";
            string potentialEnumName;

            if (t.IsRegex(@"^\p{L}\w*\.[a-zA-Z]\w*", out potentialEnumName))
            {
                if (_values.TryGetValue(potentialEnumName, out value)) return true;
                errorMessage = String.Format("At {0}: Unknow enum value ", t.ToString());
            }
            value = 0;
            return false;
        }

    }
}
