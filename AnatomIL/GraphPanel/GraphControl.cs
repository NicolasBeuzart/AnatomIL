using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnatomIL.GraphPanel
{
    public class GraphControl : Control
    {
        public UserControlButtons ButtonsBar { get; set; }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            ButtonsBar.CurrentComputer.Graph.Draw(e.Graphics);
          
        }
    }
}
