using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AnatomIL
{
    public class MoveToOpCode :OpCode
    {

        public MoveToOpCode(int line)
        {
            _line = line;
            base._name = "moveto";
            base._type = "draw";
            base._executable = true;
        }

        override public OpCodeResult Execute(Environment e)
        {
            string errorMessage = "";

            StackItemValue StV1;
            StackItemValue StV2;

            if (e.Stack.Pop(out StV1) && e.Stack.Pop(out StV2))
            {

                if (StV1.Type != typeof(Int32)) errorMessage = "x value is not type int32 for operation" + _name + " line :" + _line;

                else if (StV2.Type != typeof(Int32)) errorMessage = "y value is not type int32 for operation" + _name + " line :" + _line;

                else
                {
                    Int32 x = Convert.ToInt32(StV1.Value);
                    Int32 y = Convert.ToInt32(StV2.Value);
                    e.Graph.MoveTo(x, y);
                }
            }
            else errorMessage = "Can't execute operation " + _name + " empty stack line :" + (_line + 1);


            return new OpCodeResult(errorMessage);
        }
    }

    public class LineToOpCode : OpCode
    {

        public LineToOpCode(int line)
        {
            _line = line;
            base._name = "lineto";
            base._type = "draw";
            base._executable = true;
        }

        override public OpCodeResult Execute(Environment e)
        {
            string errorMessage = "";

            StackItemValue StV1;
            StackItemValue StV2;
            StackItemValue StV3;

            if (e.Stack.Pop(out StV1) && e.Stack.Pop(out StV2) && e.Stack.Pop(out StV3))
            {

                if (StV1.Type != typeof(Int32)) errorMessage = "x value is not type int32 for operation" + _name + " line :" + _line;

                else if (StV2.Type != typeof(Int32)) errorMessage = "y value is not type int32 for operation" + _name + " line :" + _line;

                else if (StV3.Type != typeof(Int32)) errorMessage = "color value is not type int32 for operation" + _name + " line :" + _line;

                else
                {
                    Int32 x = Convert.ToInt32(StV1.Value);
                    Int32 y = Convert.ToInt32(StV2.Value);

                    Color c = Color.FromKnownColor((KnownColor)StV3.Value);
                    e.Graph.LineTo(x, y, c);
                }
            }
            else errorMessage = "Can't execute operation " + _name + " empty stack line :" + (_line + 1);

            return new OpCodeResult(errorMessage);
        }
    }

    public class EllipseToOpCode : OpCode
    {

        public EllipseToOpCode(int line)
        {
            _line = line;
            base._name = "ellipseto";
            base._type = "draw";
            base._executable = true;
        }

        override public OpCodeResult Execute(Environment e)
        {
            string errorMessage = "";

            StackItemValue StV1;
            StackItemValue StV2;
            StackItemValue StV3;

            if (e.Stack.Pop(out StV1) && e.Stack.Pop(out StV2) && e.Stack.Pop(out StV3))
            {

                if (StV1.Type != typeof(Int32)) errorMessage = "x value is not type int32 for operation" + _name + " line :" + _line;

                else if (StV2.Type != typeof(Int32)) errorMessage = "y value is not type int32 for operation" + _name + " line :" + _line;

                else if (StV3.Type != typeof(Int32)) errorMessage = "color value is not type int32 for operation" + _name + " line :" + _line;

                else
                {
                    Int32 x = Convert.ToInt32(StV1.Value);
                    Int32 y = Convert.ToInt32(StV2.Value);

                     Color c = Color.FromKnownColor((KnownColor)StV3.Value);
                     e.Graph.EllipseTo(x, y, c);

                 }
            }
            else errorMessage = "Can't execute operation " + _name + " empty stack line :" + (_line + 1);
           
            return new OpCodeResult(errorMessage);
        }
    }

    public class RectangleToOpCode : OpCode
    {

        public RectangleToOpCode(int line)
        {
            _line = line;
            base._name = "rectangleto";
            base._type = "draw";
            base._executable = true;
        }

        override public OpCodeResult Execute(Environment e)
        {
            string errorMessage = "";

            StackItemValue StV1;
            StackItemValue StV2;
            StackItemValue StV3;

            if (e.Stack.Pop(out StV1) && e.Stack.Pop(out StV2) && e.Stack.Pop(out StV3))
            {

                if (StV1.Type != typeof(Int32)) errorMessage = "x value is not type int32 for operation" + _name + " line :" + _line;

                else if (StV2.Type != typeof(Int32)) errorMessage = "y value is not type int32 for operation" + _name + " line :" + _line;

                else if (StV3.Type != typeof(Int32)) errorMessage = "color value is not type int32 for operation" + _name + " line :" + _line;

                else
                {
                    Int32 x = Convert.ToInt32(StV1.Value);
                    Int32 y = Convert.ToInt32(StV2.Value);

                    Color c = Color.FromKnownColor((KnownColor)StV3.Value);
                    e.Graph.RectangleTo(x, y, c);

                }
            }
            else errorMessage = "Can't execute operation " + _name + " empty stack line :" + (_line + 1);

            return new OpCodeResult(errorMessage);
        }
    }

    public class LinesToOpCode : OpCode
    {
        
        public LinesToOpCode(int line)
        {
            _line = line;
            base._name = "linesto";
            base._type = "draw";
            base._executable = true;
        }

        override public OpCodeResult Execute(Environment e)
        {
            string errorMessage = "";

            StackItemValue StV1;
            StackItemValue StV2;

            List<int> x = new List<int>();
            List<int> y = new List<int>();


            if (e.Stack.FirstElement(out StV1))
            {


                while (e.Stack.Pop(out StV1) && e.Stack.Pop(out StV2))
                {
                    if (StV1.Type != typeof(Int32)) errorMessage = "x value is not type int32 for operation" + _name + " line :" + _line;

                    else if (StV2.Type != typeof(Int32)) errorMessage = "y value is not type int32 for operation" + _name + " line :" + _line;

                    else
                    {
                        Int32 tmpx = Convert.ToInt32(StV1.Value);
                        Int32 tmpy = Convert.ToInt32(StV2.Value);

                        x.Add(tmpx);
                        y.Add(tmpy);
                    }
                }

                if (StV1 == null)
                    errorMessage = "Missing color argument for operation" + _name + " line :" + _line;
                else
                {
                    if (StV1.Type != typeof(Int32)) errorMessage = "color value is not type int32 for operation" + _name + " line :" + _line;
                    else
                    {
                        Color c = Color.FromKnownColor((KnownColor)StV1.Value);
                        e.Graph.LinesTo(x, y, c);
                    }

                }
            }
            else errorMessage = "Can't execute operation " + _name + " empty stack line :" + (_line + 1);

            

            return new OpCodeResult(errorMessage);
        }
    }

}
