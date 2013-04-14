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
    public partial class Form1 : Form
    {
        controleur p;

        public Form1()
        {
            InitializeComponent();
            listBoxInstructions.Visible = false;
            p = new controleur();
        }

        private void btExecuteOneStep_Click(object sender, EventArgs e)
        {
            string s = tbCodeZone.Text.Replace("\r", "");
            string[] s2 = s.Split(new char[] { '\n' });
            listBoxInstructions.Items.Clear();
            listBoxInstructions.Items.AddRange(s2);
            p.compile(s2);
            p.ExecuteNextInstruction();
            listBoxInstructions.SelectedIndex = p._pc;
            listBoxInstructions.Visible = true;
            tbCodeZone.Visible = false;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            panLeft.Size = new Size(this.Size.Width / 2, panLeft.Size.Height);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btStart_Click(object sender, EventArgs e)
        {
            string s = tbCodeZone.Text.Replace("\r", "");
            string[] s2 = s.Split(new char[] { '\n' });
            listBoxInstructions.Items.Clear();
            listBoxInstructions.Items.AddRange(s2);

            btStart.Visible = false;
            btExecuteOneStep.Visible = true;
            listBoxInstructions.SelectedIndex = p.FirstInstrucion();
            listBoxInstructions.Visible = true;
            tbCodeZone.Visible = false;
        }

        private void btStop_Click(object sender, EventArgs e)
        {
            btStart.Visible = true;
            btExecuteOneStep.Visible = false;
            listBoxInstructions.Visible = false;
            tbCodeZone.Visible = true;
        }

    }
}
