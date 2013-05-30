using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnatomIL
{
    public class Graph
    {
        private List<DrawItem> _drawinstructions = new List<DrawItem>();

        public struct Cursor
        {
            public int x;
            public int y;

            public Cursor(int _x, int _y)
            {
                this.x = _x;
                this.y = _y;
            }
        }

        public Cursor _currentcursor = new Cursor(0,0);

        public void MoveTo(int _x, int _y)
        {
            DrawItem drawinstruction = new DrawItem("moveto", _x, _y);
            _drawinstructions.Add(drawinstruction);
        }

        public void LineTo(System.Drawing.Color _color, int _x, int _y)
        {
            DrawItem drawinstruction = new DrawItem("lineto", _color, _x, _y);
            _drawinstructions.Add(drawinstruction);
        }

        public int Count
        {
            get
            {
                return _drawinstructions.Count;
            }
        }

        public List<DrawItem> CurrentGraph
        {
            get { return _drawinstructions; }
        }

        public Cursor CurrentCursor
        {
            get { return _currentcursor; }
        }
    }
}
