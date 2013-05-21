using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnatomIL
{
    public class DrawLineOpCodeRoot : OpCodeRoot
    {
        
        public DrawLineOpCodeRoot()
        {
            base._name = "drawline";
            base._type = "draw";
        }

        override public OpCodeRootResult Parse(Tokeniser t)
        {
            string errorMessage = "";
            string color = null;
            string arg1;
            string arg2;
            string arg3;
            string arg4;
            Int32 tmp;
            int x1 = 0;
            int y1 = 0;
            int x2 = 0;
            int y2 = 0;

            if (!(t.MatchOpenPar() && t.IsString(out color) && t.MatchComma() && t.IsString(out arg1) && t.MatchComma() && t.IsString(out arg2) && t.MatchComma() && t.IsString(out arg3) && t.MatchComma() && t.IsString(out arg4) && t.MatchClosePar() && t.IsEnd))
                errorMessage = "Bad utilisation of Operation" + base._name + "in line : " + t.CurentLigne;

            else if (!(Int32.TryParse(arg1, out tmp) && Int32.TryParse(arg2, out tmp) && Int32.TryParse(arg3, out tmp) && Int32.TryParse(arg4, out tmp)))
                errorMessage = "Some arguments aren't Int32 in Operation" + base._name;

            else
            {
                x1 = Convert.ToInt32(arg1);
                y1 = Convert.ToInt32(arg2);
                x2 = Convert.ToInt32(arg3);
                y2 = Convert.ToInt32(arg4);
            }

            return (new OpCodeRootResult(errorMessage, new DrawLineOpCode(color, x1, y1, x2, y2, t.CurentLigne)));
        }
    }
}
