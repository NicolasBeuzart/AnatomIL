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
    public partial class UserControlButtons : UserControl
    {
   
        public UserControlButtons()
        {
            InitializeComponent();
        }

        public UserControlCodeZone Code { get; set; }
        public UserControlTextBoxError Error { get; set; }
        public UserControlStack Stack { get; set; }

        IlComputer computer = new IlComputer();
        public IlComputer CurrentComputer { get { return computer; } }

        private void btGo_Click(object sender, EventArgs e)
        {

            while (computer.Pc < Code.listBoxInstructions.Items.Count)
            {

                computer.ExecuteNextInstruction();

                if (computer.Pc < Code.listBoxInstructions.Items.Count)
                {
                    Code.listBoxInstructions.SelectedIndex = computer.Pc;
                }
                else
                {
                    Code.listBoxInstructions.Visible = false;
                    Code.textBoxCode.Visible = true;
                    btExecuteOneStep.Visible = false;
                    btGo.Visible = false;
                }

                Stack.ShowStack();
            }

        }

        private void btExecuteOneStep_Click(object sender, EventArgs e)
        {

            computer.ExecuteNextInstruction();

            if (computer.Pc < Code.listBoxInstructions.Items.Count)
            {
                Code.listBoxInstructions.SelectedIndex = computer.Pc;
            }
            else
            {
                Code.listBoxInstructions.Visible = false;
                Code.textBoxCode.Visible = true;
                btExecuteOneStep.Visible = false;
                btGo.Visible = false;
            }

            Stack.ShowStack();
           
        }

        private void btStop_Click(object sender, EventArgs e)
        {
            Code.listBoxInstructions.Visible = false;
            Code.textBoxCode.Visible = true;
            btExecuteOneStep.Visible = false;
            btGo.Visible = false;
        }

        private void btCompile_Click(object sender, EventArgs e)
        {
               Error.Visible = false;
               Stack.listboxStack.Items.Clear();

               btExecuteOneStep.Visible = true;
               btGo.Visible = true;

               computer.reset();

               Code.listBoxInstructions.Visible = true;
               Code.textBoxCode.Visible = false;

               string s = Code.textBoxCode.Text.Replace("\r", "");
               string[] s2 = s.Split(new char[] { '\n' });

               Code.listBoxInstructions.Items.Clear();
               Code.listBoxInstructions.Items.AddRange(s2);

               computer.LoadCode(s2);
            
               computer.compile();

               if (computer.ErrorMessages.Count > 0)
               {
                   Error.Visible = true;
                   btGo.Visible = false;
                   btExecuteOneStep.Visible = false;
                   Code.listBoxInstructions.Visible = false;
                   Code.textBoxCode.Visible = true;
               }

               computer.Start();
               Code.listBoxInstructions.SelectedIndex = computer.Pc;
        }

    }
}
