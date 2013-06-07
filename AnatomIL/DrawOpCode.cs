using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnatomIL
{
    public class MoveToOpCode :OpCode
    {
        int _x;
        int _y;


        public MoveToOpCode(int x, int y, int line)
        {
            _x = x;
            _y = y;
            _line = line;
            base._name = "moveto";
            base._type = "draw";
            base._executable = true;
        }

        override public OpCodeResult Execute(Environment e)
        {
            string errorMessage = "";

            e.Graph.MoveTo(_x, _y);
            
            return new OpCodeResult(errorMessage);
        }
    }

    public class LineToOpCode : OpCode
    {
        int _x;
        int _y;
        string _color;

        public LineToOpCode(int x, int y, string color, int line)
        {
            _x = x;
            _y = y;
            _color = color;
            _line = line;
            base._name = "lineto";
            base._type = "draw";
            base._executable = true;
        }

        override public OpCodeResult Execute(Environment e)
        {
            string errorMessage = "";

            e.Graph.LineTo(_x, _y, _color);

            return new OpCodeResult(errorMessage);
        }
    }

    public class EllipseToOpCode : OpCode
    {
        int _x;
        int _y;
        string _color;

        public EllipseToOpCode(int x, int y, string color, int line)
        {
            _x = x;
            _y = y;
            _color = color;
            _line = line;
            base._name = "ellipseto";
            base._type = "draw";
            base._executable = true;
        }

        override public OpCodeResult Execute(Environment e)
        {
            string errorMessage = "";

            e.Graph.EllipseTo(_x, _y, _color);

            return new OpCodeResult(errorMessage);
        }
    }
}
