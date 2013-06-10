using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnatomIL
{
    public class DrwContext
    {
        public int CurrentX { get; set; }
        public int CurrentY { get; set; }
    }

    public abstract class DrwItem
    {
        public abstract void Draw(DrwContext ctx, Graphics g);
    }

    public class MoveToItem : DrwItem
    {
        readonly int _x;
        readonly int _y;

        public MoveToItem(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public override void Draw(DrwContext ctx, Graphics g)
        {
            ctx.CurrentX = _x;
            ctx.CurrentY = _y;
        }
    }

    public class LineToItem : DrwItem
    {
        readonly int _x;
        readonly int _y;
        readonly Color _color;

        public LineToItem(int x, int y, Color color)
        {
            _x = x;
            _y = y;
            _color = color;
        }

        public override void Draw(DrwContext ctx, Graphics g)
        {
            Pen UserPen = new Pen(_color);

            g.DrawLine(UserPen, ctx.CurrentX, ctx.CurrentY, _x, _y);

            ctx.CurrentX = _x;
            ctx.CurrentY = _y;
        }
    }

    public class EllipseToItem : DrwItem
    {
        readonly int _x;
        readonly int _y;
        readonly Color _color;

        public EllipseToItem(int x, int y, Color color)
        {
            _x = x;
            _y = y;
            _color = color;
        }

        public override void Draw(DrwContext ctx, Graphics g)
        {
            Pen UserPen = new Pen(_color);

            g.DrawEllipse(UserPen, ctx.CurrentX, ctx.CurrentY, _x, _y);

            ctx.CurrentX = _x;
            ctx.CurrentY = _y;
        }
    }

    public class CurveToItem : DrwItem
    {
        readonly int[] _x;
        readonly int[] _y;
        readonly Color _color;

        public CurveToItem(int []x, int []y, Color color)
        {
            _x = x;
            _y = y;
            _color = color;
        }

        public override void Draw(DrwContext ctx, Graphics g)
        {
            Pen UserPen = new Pen(_color);
            Point[] AllPoints = new Point[_x.Length + 1];
            int i;

            AllPoints[0].X = ctx.CurrentX;
            AllPoints[0].Y = ctx.CurrentY;

            for (i = 1; i < _x.Length + 1; i++)
            {
                AllPoints[i].X = _x[i-1];
                AllPoints[i].Y = _y[i-1];
            }

            g.DrawCurve(UserPen, AllPoints);
            g.DrawLines(UserPen, AllPoints);


            ctx.CurrentX = AllPoints[i].X;
            ctx.CurrentY = AllPoints[i].Y;
        }
    }

    public class Graph
    {
        List<DrwItem> _instructions;

        public Graph()
        {
            _instructions = new List<DrwItem>();
        }
        public void MoveTo(int x, int y)
        {
            _instructions.Add(new MoveToItem(x, y));
        }

        public void LineTo(int x, int y, Color color)
        {
            _instructions.Add(new LineToItem(x, y, color));
        }

        public void EllipseTo(int x, int y, Color color)
        {
            _instructions.Add(new EllipseToItem(x, y, color));
        }

        public void CurveTo(int []x, int []y, Color color)
        {
            _instructions.Add(new CurveToItem(x, y, color));
        }

        public void ClearScreen()
        {
            _instructions.Clear();
        }

        public void Draw(Graphics g)
        {
            DrwContext ctx = new DrwContext();
            foreach (var i in _instructions) i.Draw(ctx, g);
        }

    }

}
