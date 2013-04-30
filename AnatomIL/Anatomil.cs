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
    public partial class AnatomIL : Form
    {
        IlComputer computer;

        public AnatomIL()
        {
            InitializeComponent();
            listBoxInstructions.Visible = false;
            panTopOfStack.Height = panMarginLeftStack.Height - (listboxStack.ItemHeight * (listboxStack.Items.Count + 1));
        }

        private void btExecuteOneStep_Click(object sender, EventArgs e)
        {
            try
            {
                computer.ExecuteNextInstruction();
            }
            catch (Exception exception)
            {
                textBoxError.Text = exception.Message;
                textBoxError.Visible = true;
            }
            if (computer.Pc < listBoxInstructions.Items.Count)
            {
                listBoxInstructions.SelectedIndex = computer.Pc;
            }
            else
            {
                btStart.Visible = true;
                btExecuteOneStep.Visible = false;
                listBoxInstructions.Visible = false;
                tbCodeZone.Visible = true;
            }
            listboxStack.Items.Clear();
            string[] s = new string[computer.Stack.Count];
            int i = 0;
            foreach (StackItem StIt in computer.Stack.CurrentStack)
            {
                if (StIt.Value != null)
                    s[computer.Stack.CurrentStack.Count - i - 1] = StIt.Type.ToString().Split('.')[StIt.Type.ToString().Split('.').Count() - 1] + " : " + StIt.Value.ToString();
                else
                    s[computer.Stack.CurrentStack.Count - i - 1] = StIt.Type.ToString().Split('.')[StIt.Type.ToString().Split('.').Count() - 1] + " : null";

                if (i < computer.NbLocals["main"])
                {
                    s[computer.Stack.CurrentStack.Count - i - 1] = "loc" + (computer.Stack.CurrentStack.Count - i - 1) + " " + s[computer.Stack.CurrentStack.Count - i - 1];
                }

                i++;
            }

            listboxStack.Items.AddRange(s);
            panTopOfStack.Height = panMarginLeftStack.Height - (listboxStack.ItemHeight * (listboxStack.Items.Count + 1));
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            panLeft.Size = new Size(this.Size.Width / 3, panLeft.Size.Height);
            panTopOfStack.Height = panMarginLeftStack.Height - (listboxStack.ItemHeight * (listboxStack.Items.Count + 1));
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btStart_Click(object sender, EventArgs e)
        {
            textBoxError.Visible = false;
            computer = new IlComputer();
            string s = tbCodeZone.Text.Replace("\r", "");
            string[] s2 = s.Split(new char[] { '\n' });
            listBoxInstructions.Items.Clear();
            listBoxInstructions.Items.AddRange(s2);
            listboxStack.Items.Clear();
            panTopOfStack.Height = panMarginLeftStack.Height - (listboxStack.ItemHeight * (listboxStack.Items.Count + 1));
            btStart.Visible = false;
            btExecuteOneStep.Visible = true;

            listBoxInstructions.Visible = true;
            tbCodeZone.Visible = false;

            computer.LoadCode(s2);
            try
            {
                computer.compile();
            }
            catch (Exception exception)
            {
                textBoxError.Text = exception.Message;
                textBoxError.Visible = true;
                btStart.Visible = true;
                btExecuteOneStep.Visible = false;
                listBoxInstructions.Visible = false;
                tbCodeZone.Visible = true;
            }

            computer.Start();
            listBoxInstructions.SelectedIndex = computer.Pc;
        }

        private void btStop_Click(object sender, EventArgs e)
        {
            btStart.Visible = true;
            btExecuteOneStep.Visible = false;
            listBoxInstructions.Visible = false;
            tbCodeZone.Visible = true;
        }

        private void panMarginLeftInstructions_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tbCodeZone_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbCodeZone_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void userControl1_Load(object sender, EventArgs e)
        {

        }

        private void textBoxError_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
