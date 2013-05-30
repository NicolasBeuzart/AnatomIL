using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnatomIL
{
    public class MoveToOpCode : OpCode
    {
        int _x;
        int _y;

        public MoveToOpCode(int x, int y, int line)
        {
            _line = line;
            base._name = "moveto";
            base._type = "draw";
            base._executable = true;
            _x = x;
            _y = y;

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
        System.Drawing.Color _color;

        public LineToOpCode(System.Drawing.Color color, int x, int y, int line)
        {
            _line = line;
            base._name = "lineto";
            base._type = "draw";
            base._executable = true;
            _x = x;
            _y = y;
            _color = color;

        }

        override public OpCodeResult Execute(Environment e)
        {
            string errorMessage = "";
            e.Graph.LineTo(_color, _x, _y);
            return new OpCodeResult(errorMessage);
        }


    }
}
