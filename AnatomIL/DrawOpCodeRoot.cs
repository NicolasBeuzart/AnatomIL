using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnatomIL
{
    public class MoveToOpCodeRoot : OpCodeRoot
    {

        public MoveToOpCodeRoot()
        {
            base._name = "moveto";
            base._type = "draw";
        }

        override public OpCodeRootResult Parse(Tokeniser t)
        {
            string errorMessage = "";
            int x = 0;
            int y = 0;
            string arg1;
            string arg2;
            Int32 tmp;


            if (!(t.MatchOpenPar() && t.IsArgument(out arg1) && t.MatchComma() && t.IsArgument(out arg2) && t.MatchClosePar() && t.IsEnd))
                errorMessage = "Bad utilisation of Operation" + base._name + "in line : " + t.CurentLigne;
            else if (!Int32.TryParse(arg1, out tmp))
            {
                errorMessage = "x argument isn't Int32 in Operation" + base._name;
            }
            else if (!Int32.TryParse(arg2, out tmp))
            {
                errorMessage = "y argument isn't Int32 in Operation" + base._name;
            }
            else
            {
                x = Convert.ToInt32(arg1);
                y = Convert.ToInt32(arg2);
            }

            return (new OpCodeRootResult(errorMessage, new MoveToOpCode(x, y, t.CurentLigne)));
        }
    }

    public class LineToOpCodeRoot : OpCodeRoot
    {

        public LineToOpCodeRoot()
        {
            base._name = "lineto";
            base._type = "draw";
        }

        override public OpCodeRootResult Parse(Tokeniser t)
        {
            string errorMessage = "";
            int x = 0;
            int y = 0;
            System.Drawing.Color color = System.Drawing.Color.Black;
            string arg1;
            string arg2;
            string argcolor;
            Int32 tmp;

            if (!(t.MatchOpenPar() && t.IsArgument(out argcolor) && t.MatchComma() && t.IsArgument(out arg1) && t.MatchComma() && t.IsArgument(out arg2) && t.MatchClosePar() && t.IsEnd))
                errorMessage = "Bad utilisation of Operation" + base._name + "in line : " + t.CurentLigne;
            else if (!Int32.TryParse(arg1, out tmp))
            {
                errorMessage = "x argument isn't Int32 in Operation" + base._name;
            }
            else if (!Int32.TryParse(arg2, out tmp))
            {
                errorMessage = "y argument isn't Int32 in Operation" + base._name;
            }
            else if(!System.Drawing.Color.FromName(argcolor).IsKnownColor)
            {
                errorMessage = "color argument isn't valid color in Operation" + base._name;
            }
            else
            {
                x = Convert.ToInt32(arg1);
                y = Convert.ToInt32(arg2);
                color = System.Drawing.Color.FromName(argcolor);
            }

            return (new OpCodeRootResult(errorMessage, new LineToOpCode(color, x, y, t.CurentLigne)));
        }

    }
}
