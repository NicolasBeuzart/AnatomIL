﻿using System;
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

    public class CurveToOpCode : OpCode
    {

        public CurveToOpCode(int line)
        {
            _line = line;
            base._name = "curveto";
            base._type = "draw";
            base._executable = true;
        }

        override public OpCodeResult Execute(Environment e)
        {
            string errorMessage = "";

            StackItemValue StV1;
            StackItemValue StV2;
            StackItemValue StV3;
            StackItemValue StV4;
            Int32 NbrPts;

            if (e.Stack.Pop(out StV1))
            {
                if (StV1.Type != typeof(Int32)) 
                    errorMessage = "Number of points value is not type int32 for operation" + _name + " line :" + _line;
                else
                { 
                    Int32 i = Convert.ToInt32(StV1.Value); 
                    Int32[] x = new Int32 [i];
                    Int32[] y = new Int32 [i];

                    for(NbrPts = 0; NbrPts < i; NbrPts++)
                    {

                        if (e.Stack.Pop(out StV2) && e.Stack.Pop(out StV3))
                        {

                            if (StV2.Type != typeof(Int32)) errorMessage = "x value is not type int32 for operation" + _name + " line :" + _line;

                            else if (StV3.Type != typeof(Int32)) errorMessage = "y value is not type int32 for operation" + _name + " line :" + _line;

                            else
                            {
                                Int32 tmpx = Convert.ToInt32(StV2.Value);
                                Int32 tmpy = Convert.ToInt32(StV3.Value);

                                x[NbrPts] = tmpx;
                                y[NbrPts] = tmpy;
                            }
                        }
                        else
                        {
                            errorMessage = "Missing arguments for operation" + _name + " line :" + _line;
                        }
                    }

                    if(e.Stack.Pop(out StV4))
                    {
                        if (StV4.Type != typeof(Int32)) errorMessage = "color value is not type int32 for operation" + _name + " line :" + _line;

                        else
                        {
                                Color c = Color.FromKnownColor((KnownColor)StV4.Value);
                                e.Graph.CurveTo(x, y, c);
                        }
                    }
                }
            }
            else errorMessage = "Can't execute operation " + _name + " empty stack line :" + (_line + 1);

            return new OpCodeResult(errorMessage);
        }
    }

}
