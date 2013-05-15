using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnatomIL
{

    public class Tokeniser
    {
        Library _libDirective;
        Library _libInstructions;
        string _curentToken;
        int _idxToken;
        int _idxCode;
        int _curentligne;
        string[] _code;
        char[] _delimiter = { ' ', '.', ':', ')', '(', '{', '}', ',' };
        string[] _types = { "int", "int16", "int32", "int64", "char", "bool" };
        int _braket;

        public int CurentLigne { get { return _curentligne; } }

        public Tokeniser(string[] code)
        {
            _libDirective = new Library();
            _libInstructions = new Library();
            _libDirective.LoadDirectiveLib();
            _libInstructions.LoadInstructionLib();
            _code = code;

            int i = 0;

            foreach (string s in _code)
            {
                _code[i] = s.Trim();
                i++;
            }

            _idxCode = -1;
            _idxToken = 0;
            _curentligne = -1;
            _curentToken = "";
        }

        public bool MatchNextToken()
        {
            if (_idxCode < _code.Count() - 1)
            {
                _idxCode++;
                _idxToken = 0;
                _curentToken = _code[_idxCode];
                _curentligne++;
                return (true);
            }
            else return (false);
        }

        public bool HasElement { get { return (_idxCode < _code.Length); } }
        public bool IsEnd { get { return (_idxToken >= _curentToken.Length); } }
        public bool SquareBraket { get { return _braket == 0; } }


        public bool MatchSpace()
        {

            if (!IsEnd && _curentToken[_idxToken] == ' ')
            {
                do _idxToken++;
                while (!IsEnd && _curentToken[_idxToken] == ' ');
                return (true);
            }
            else return (false);
        }

        public bool MatchDot()
        {
            if (!IsEnd && _curentToken[_idxToken] == '.')
            {
                _idxToken++;
                return (true);
            }
            else return (false);
        }

        public bool MatchComma()
        {
            if (!IsEnd && _curentToken[_idxToken] == ',')
            {
                _idxToken++;
                return (true);
            }
            else return (false);
        }

        public bool MatchOpenPar()
        {
            if (!IsEnd && _curentToken[_idxToken] == '(')
            {
                _idxToken++;
                return (true);
            }
            else return (false);
        }

        public bool MatchClosePar()
        {
            if (!IsEnd && _curentToken[_idxToken] == ')')
            {
                _idxToken++;
                return (true);
            }
            else return (false);
        }

        public bool MatchColon()
        {
            if (!IsEnd && _curentToken[_idxToken] == ':')
            {
                _idxToken++;
                return (true);
            }
            else return (false);
        }

        public bool MatchOpenBraket()
        {
            if (!IsEnd && _curentToken[_idxToken] == '{')
            {
                _idxToken++;
                _braket++;
                return (true);
            }
            else return (false);
        }

        public bool MatchcloseBraket()
        {
            if (!IsEnd && _curentToken[_idxToken] == '}')
            {
                _idxToken++;
                _braket--;
                return (true);
            }
            else return (false);
        }

        public bool IsString(out string s)
        {
            s = "";

            while (!IsEnd && !_delimiter.Contains(_curentToken[_idxToken]))
            {
                s += _curentToken[_idxToken];
                _idxToken++;
            }

            if (s != "") return (true);
            else return (false);
        }

        public bool IsDirective(out OpCodeRoot result)
        {
            string directive = "";
            result = null;

            if (MatchDot())
            {
                IsString(out directive);
            }

            if (_libDirective.LibIsCodeOpRootExiste(directive))
            {
                result = _libDirective.LibFindOpCodeRoot(directive);
                return (true);
            }
            else return (false);
        }

        public bool IsInstruction(out OpCodeRoot result)
        {
            string instruction = "";
            result = null;

            IsString(out instruction);

            if (_libInstructions.LibIsCodeOpRootExiste(instruction))
            {
                result = _libInstructions.LibFindOpCodeRoot(instruction);
                return (true);
            }
            else return (false);
        }

        public bool IsLabel(out OpCodeRoot result)
        {
            result = null;

            MatchSpace();
            if (MatchColon())
            {
                result = new LabelOpCodeRoot();
                return (true);
            }
            else return (false);
        }

        public bool IsType(out string type)
        {
            type = "";

            if (IsString(out type) && _types.Contains(type)) return (true);
            else return (false);
        }

        public bool IsOptions(out List<string> options)
        {
            options = new List<string>();
            string s;

            while (MatchDot())
            {
                if (IsString(out s)) options.Add(s);
                else return (false);
            }

            if (options.Count() > 0) return (true);
            else return (false);
        }

        public bool IsOption(out string option)
        {
            option = null;
            string s;

            if (MatchDot())
            {
                IsString(out s);
                option = s;
                return (true);
            }
            else return (false);
        }

        public bool IsArguments(out List<string> args)
        {
            args = new List<string>();
            string s;

            while (MatchSpace())
            {
                if (IsString(out s)) args.Add(s);
            }

            if (args.Count() > 0) return (true);
            else return (false);
        }

        public bool IsArgument(out string arg)
        {
            arg = null;
            string s;
            MatchSpace();
            if (IsString(out s))
            {
                 arg =s;
            }

            if (arg != null) return (true);
            else return (false);
        }
    }
}
