using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnatomIL
{
    public partial class Inter : Form
    {
        public Inter()
        {
            InitializeComponent();
        }

        public void ShowGraph()
        {
            System.Drawing.Graphics G = splitContainer3.Panel2.CreateGraphics();

            foreach(DrawItem DrIt in userControlButtons1.CurrentComputer.Graph.CurrentGraph)
            {
                if (DrIt._instruc == "lineto")
                {
                    System.Drawing.Pen myPen = new System.Drawing.Pen(DrIt._color);
                    G.DrawLine(myPen, userControlButtons1.CurrentComputer.Graph.CurrentCursor.x, userControlButtons1.CurrentComputer.Graph.CurrentCursor.y, DrIt._x, DrIt._y);
                    myPen.Dispose();
                    G.Dispose();
                    userControlButtons1.CurrentComputer.Graph._currentcursor.x = DrIt._x;
                    userControlButtons1.CurrentComputer.Graph._currentcursor.y = DrIt._y;
                }
            }
        }
    }
}
