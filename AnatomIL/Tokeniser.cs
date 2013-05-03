using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnatomIL
{
    public class Tokeniser
    {
        string _curentToken;
        int _idxToken;
        int _idxCode;
        int _curentligne;
        string[] _code;

        public int CurentLigne { get { return _curentligne; } }

        public Tokeniser(string[] code)
        {
            _code = code;
            _idxCode = -1;
            _idxToken = 0;
            _curentligne = 0;
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
        bool IsEnd { get { return (_idxToken >= _curentToken.Length); } }



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

        public bool IsDirective()
        {
            string directive = "";
            while (!IsEnd && _curentToken[_idxToken] != ' ' && _curentToken[_idxToken] != '.')
            {
                directive += _curentToken[_idxToken];
                _idxToken++;
            }

            if (IsEnd) return (true);
            else return (false);
        }
    }
}
