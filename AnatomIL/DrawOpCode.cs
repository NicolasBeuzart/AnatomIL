using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnatomIL
{
    public class DrawLineOpCode : OpCode
    {
        int _x1;
        int _y1;
        int _x2;
        int _y2;

        public DrawLineOpCode(string color, int x1, int y1, int x2, int y2, int line)
        {
            _line = line;
            base._name = "drawline";
            base._type = "draw";
            base._executable = true;
            _x1 = x1;
            _y1 = y1;
            _x2 = x2;
            _y2 = y2;
        }

        override public OpCodeResult Execute(Environment e)
        {
            string errorMessage = "";

            return new OpCodeResult(errorMessage);
        }
    }
}
