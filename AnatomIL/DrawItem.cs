using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnatomIL
{
    public class DrawItem
    {
        public string _instruc;
        public System.Drawing.Color _color;
        public int _x;
        public int _y;


        public DrawItem(string Instruc, System.Drawing.Color Color, int x, int y)
        {
            _instruc = Instruc;
            _color = Color;
            _x = x;
            _y = y;
        }

        public DrawItem(string Instruc, int x, int y)
        {
            _instruc = Instruc;
            _color = System.Drawing.Color.Black;
            _x = x;
            _y = y;
        }
    }
}
