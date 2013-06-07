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
            string arg1, arg2;
            Int32 tmp;

            if (!(t.MatchOpenPar() && t.IsArgument(out arg1) && t.MatchComma() && t.IsArgument(out arg2) && t.MatchClosePar() && t.IsEnd))
                errorMessage = "Bad utilisation of Operation" + base._name + "in line : " + t.CurentLigne;
            else
            {
                if (!Int32.TryParse(arg1, out tmp))
                    errorMessage = "Argument x isn't Int32 in Operation" + base._name + "in line : " + t.CurentLigne;
                else
                    x = Convert.ToInt32(arg1);

                if (!Int32.TryParse(arg2, out tmp))
                    errorMessage = "Argument y isn't Int32 in Operation" + base._name + "in line : " + t.CurentLigne;
                else
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
            string color = null;

            string arg1, arg2, argc;

            Int32 tmp;

            if (!(t.MatchOpenPar() && t.IsArgument(out arg1) && t.MatchComma() && t.IsArgument(out arg2) && t.MatchComma() && t.IsArgument(out argc) && t.MatchClosePar() && t.IsEnd))
                errorMessage = "Bad utilisation of Operation " + base._name + " in line : " + t.CurentLigne;
            else
            {
                if (!Int32.TryParse(arg1, out tmp))
                    errorMessage = "Argument x isn't Int32 in Operation " + base._name + " in line : " + t.CurentLigne;
                else
                    x = Convert.ToInt32(arg1);

                if (!Int32.TryParse(arg2, out tmp))
                    errorMessage = "Argument y isn't Int32 in Operation " + base._name + " in line : " + t.CurentLigne;
                else
                    y = Convert.ToInt32(arg2);

                if (!System.Drawing.Color.FromName(argc).IsKnownColor)
                    errorMessage = "Argument color isn't a valid color in Operation " + base._name + " in line : " + t.CurentLigne;
                else
                    color = argc;
            }
            return (new OpCodeRootResult(errorMessage, new LineToOpCode(x, y, color, t.CurentLigne)));
        }

    }

    public class EllipseToOpCodeRoot : OpCodeRoot
    {

        public EllipseToOpCodeRoot()
        {
            base._name = "ellipseto";
            base._type = "draw";
        }

        override public OpCodeRootResult Parse(Tokeniser t)
        {
            string errorMessage = "";

            int x = 0;
            int y = 0;
            string color = null;

            string arg1, arg2, argc;

            Int32 tmp;

            if (!(t.MatchOpenPar() && t.IsArgument(out arg1) && t.MatchComma() && t.IsArgument(out arg2) && t.MatchComma() && t.IsArgument(out argc) && t.MatchClosePar() && t.IsEnd))
                errorMessage = "Bad utilisation of Operation " + base._name + " in line : " + t.CurentLigne;
            else
            {
                if (!Int32.TryParse(arg1, out tmp))
                    errorMessage = "Argument x isn't Int32 in Operation " + base._name + " in line : " + t.CurentLigne;
                else
                    x = Convert.ToInt32(arg1);

                if (!Int32.TryParse(arg2, out tmp))
                    errorMessage = "Argument y isn't Int32 in Operation " + base._name + " in line : " + t.CurentLigne;
                else
                    y = Convert.ToInt32(arg2);

                if (!System.Drawing.Color.FromName(argc).IsKnownColor)
                    errorMessage = "Argument color isn't a valid color in Operation " + base._name + " in line : " + t.CurentLigne;
                else
                    color = argc;
            }
            return (new OpCodeRootResult(errorMessage, new EllipseToOpCode(x, y, color, t.CurentLigne)));
        }

    }

}
