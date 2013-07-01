using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace AnatomIL
{
    public class DrwContext
    {
        public int CurrentX { get; set; }
        public int CurrentY { get; set; }
    }

    [Serializable]
    public abstract class DrwItem
    {
        public abstract void Draw(DrwContext ctx, Graphics g);
    }

    [Serializable]
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

    [Serializable]
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

    [Serializable]
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
            int width;
            int lenght;

            width = _x - ctx.CurrentX;
            lenght = _y - ctx.CurrentY;

            //if (width < 0)
            //{
            //    width = ctx.CurrentX;
            //    ctx.CurrentX = _x;
            //}

            //if (lenght < 0)
            //{
            //    lenght = ctx.CurrentY;
            //    ctx.CurrentY = _y;
            //}

            g.DrawEllipse(UserPen, ctx.CurrentX, ctx.CurrentY, width, lenght);

            ctx.CurrentX = _x;
            ctx.CurrentY = _y;
        }
    }

    [Serializable]
    public class RectangleToItem : DrwItem
    {
        readonly int _x;
        readonly int _y;
        readonly Color _color;

        public RectangleToItem(int x, int y, Color color)
        {
            _x = x;
            _y = y;
            _color = color;
        }

        public override void Draw(DrwContext ctx, Graphics g)
        {
            Pen UserPen = new Pen(_color);
            int width;
            int lenght;

            width = _x - ctx.CurrentX;
            lenght = _y - ctx.CurrentY;

            if (width < 0)
            {
                width = ctx.CurrentX;
                ctx.CurrentX = _x;
            }

            if (lenght < 0)
            {
                lenght = ctx.CurrentY;
                ctx.CurrentY = _y;
            }

            g.DrawRectangle(UserPen, ctx.CurrentX, ctx.CurrentY, width, lenght);

            ctx.CurrentX = _x;
            ctx.CurrentY = _y;
        }
    }

    [Serializable]
    public class LinesToItem : DrwItem
    {
        readonly List<int> _x;
        readonly List<int> _y;
        readonly Color _color;

        public LinesToItem(List<int> x, List<int> y, Color color)
        {
            _x = x;
            _y = y;
            _color = color;
        }

        public override void Draw(DrwContext ctx, Graphics g)
        {
            Pen UserPen = new Pen(_color);
            Point[] AllPoints = new Point[_x.Count];



            _x[0] = ctx.CurrentX;
            _y[0] = ctx.CurrentY;


            int i = 0;
            int j = 0;

            foreach (int argx in _x)
            {
                AllPoints[i].X = argx;
                i++;
            }

            foreach (int argy in _y)
            {
                AllPoints[j].Y = argy;
                j++;
            }

            g.DrawLines(UserPen, AllPoints);

            ctx.CurrentX = AllPoints[i-1].X;
            ctx.CurrentY = AllPoints[j-1].Y;
        }
    }


    public class Graph
    {
        readonly List<DrwItem> _instructions;

        public Graph()
        {
            _instructions = new List<DrwItem>();
        }

        public List<DrwItem> CurrentGraph
        {
            get { return _instructions; }
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

        public void RectangleTo(int x, int y, Color color)
        {
            _instructions.Add(new RectangleToItem(x, y, color));
        }

        public void LinesTo(List<int> x, List<int> y, Color color)
        {
            _instructions.Add(new LinesToItem(x, y, color));
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

        public void Save(string path)
        {
            using (FileStream output = File.Create(path))
            {
                BinaryFormatter f = new BinaryFormatter();
                f.Serialize(output, _instructions);
            }
        }

        public void Load(string path)
        {
            using (FileStream input = File.OpenRead(path))
            {
                BinaryFormatter f = new BinaryFormatter();
                var newList = (List<DrwItem>)f.Deserialize(input);
                _instructions.Clear();
                foreach (var i in newList) _instructions.Add(i);
            }
            
        }

    }

}
