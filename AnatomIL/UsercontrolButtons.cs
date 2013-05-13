using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
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

        public System.Windows.Forms.Timer GoTimer;

        private void btGo_Click(object sender, EventArgs e)
        {
            btCompile.Visible = false;
            btStop.Visible = true;
            btGo.Visible = false;
            timeBox.Visible = false;

            int intervalTime = Convert.ToInt32(timeBox.Text);
            GoTimer = new System.Windows.Forms.Timer();

            GoTimer.Interval = intervalTime;
            GoTimer.Tick += new EventHandler(btExecuteOneStep_Click);
            GoTimer.Start();
        }

        private void btExecuteOneStep_Click(object sender, EventArgs e)
        {
            if (computer.Pc < Code.listBoxInstructions.Items.Count)
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
                    timeBox.Visible = false;
                    btCompile.Visible = true;
                    btStop.Visible = false;
                }

                Stack.ShowStack();
            }
            else
            {
                btStop_Click(this, e);
            }
        }

        private void btStop_Click(object sender, EventArgs e)
        {
            Code.listBoxInstructions.Visible = false;
            Code.textBoxCode.Visible = true;
            btExecuteOneStep.Visible = false;
            btGo.Visible = false;
            timeBox.Visible = false;
            btCompile.Visible = true;
            btStop.Visible = false;
            GoTimer.Stop();
        }

        private void btCompile_Click(object sender, EventArgs e)
        {

               Error.Visible = false;
               Stack.listboxStack.Items.Clear();

               btExecuteOneStep.Visible = true;
               btGo.Visible = true;
               timeBox.Visible = true;


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
                   timeBox.Visible = false;
                   btExecuteOneStep.Visible = false;
                   btStop.Visible = false;
                   Code.listBoxInstructions.Visible = false;
                   Code.textBoxCode.Visible = true;
               }

               computer.Start();
               Code.listBoxInstructions.SelectedIndex = computer.Pc;
        }


    }
}
