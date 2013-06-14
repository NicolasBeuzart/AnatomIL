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

            if (!(t.MatchOpenPar() && t.MatchClosePar() && t.IsEnd))
                errorMessage = "Bad utilisation of Operation" + base._name + "in line : " + t.CurentLigne;

            return (new OpCodeRootResult(errorMessage, new MoveToOpCode(t.CurentLigne)));
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


            if (!(t.MatchOpenPar() && t.MatchClosePar() && t.IsEnd))
                errorMessage = "Bad utilisation of Operation " + base._name + " in line : " + t.CurentLigne;

            return (new OpCodeRootResult(errorMessage, new LineToOpCode(t.CurentLigne)));
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

            if (!(t.MatchOpenPar() && t.MatchClosePar() && t.IsEnd))
                errorMessage = "Bad utilisation of Operation " + base._name + " in line : " + t.CurentLigne;

            return (new OpCodeRootResult(errorMessage, new EllipseToOpCode(t.CurentLigne)));
        }
    }

    public class RectangleToOpCodeRoot : OpCodeRoot
    {

        public RectangleToOpCodeRoot()
        {
            base._name = "rectangleto";
            base._type = "draw";
        }

        override public OpCodeRootResult Parse(Tokeniser t)
        {
            string errorMessage = "";

            if (!(t.MatchOpenPar() && t.MatchClosePar() && t.IsEnd))
                errorMessage = "Bad utilisation of Operation " + base._name + " in line : " + t.CurentLigne;

            return (new OpCodeRootResult(errorMessage, new RectangleToOpCode(t.CurentLigne)));
        }
    }

    public class LinesToOpCodeRoot : OpCodeRoot
    {

        public LinesToOpCodeRoot()
        {
            base._name = "linesto";
            base._type = "draw";
        }

        override public OpCodeRootResult Parse(Tokeniser t)
        {
            string errorMessage = "";


            if (!(t.MatchOpenPar() && t.MatchClosePar() && t.IsEnd))
                errorMessage = "Bad utilisation of Operation " + base._name + " in line : " + t.CurentLigne;

            return (new OpCodeRootResult(errorMessage, new LinesToOpCode(t.CurentLigne)));
        }

    }

    public class ClearScreenOpCodeRoot : OpCodeRoot
    {

        public ClearScreenOpCodeRoot()
        {
            base._name = "clearscreen";
            base._type = "draw";
        }

        override public OpCodeRootResult Parse(Tokeniser t)
        {
            string errorMessage = "";


            if (!(t.MatchOpenPar() && t.MatchClosePar() && t.IsEnd))
                errorMessage = "Bad utilisation of Operation " + base._name + " in line : " + t.CurentLigne;

            return (new OpCodeRootResult(errorMessage, new ClearScreenOpCode(t.CurentLigne)));
        }

    }
}

