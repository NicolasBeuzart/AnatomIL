using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnatomIL
{
    public partial class UserControlCodeZone : UserControl
    {
        public UserControlCodeZone()
        {
            InitializeComponent();
        }

        private void listBoxInstructions_SelectedIndexChanged(object sender, EventArgs e)
        {
            BreakPointList.TopIndex = listBoxInstructions.TopIndex;
        }

        private void BreakPointList_EnabledChanged(object sender, EventArgs e)
        {
            BreakPointList.Items.Clear();
            int NbrLines = textBoxCode.Lines.Length;
            int i;
            for (i = 0; i < NbrLines; i++)
            {
                BreakPointList.Items.Add(i + 1);
            }
        }

    }
}
