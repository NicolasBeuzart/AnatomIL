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
    public partial class UserControlStack : UserControl
    {
        public UserControlStack()
        {
            InitializeComponent();
        }

        public UserControlButtons ButtonsBar { get; set; }

        public void ShowStack()
        {
            listboxStack.Items.Clear();
            string[] s = new string[ButtonsBar.CurrentComputer.Stack.Count];
            int i = 0;

            foreach (StackItem StIt in ButtonsBar.CurrentComputer.Stack.CurrentStack)
            {
                if (StIt is StackItemValue)
                {
                    s[ButtonsBar.CurrentComputer.Stack.CurrentStack.Count - i - 1] = StIt.Type.ToString().Split('.')[StIt.Type.ToString().Split('.').Count() - 1] + " : " + StIt.Value.ToString();
                    i++;
                }
                else if (StIt is StackItemFrame)
                {
                    
                    string ListArgs = null;
                    string ListLocalsVars = null;
                    int NumberArgs = 0;
                    int NumberLocals = 0;

                    string BaseFrame = StIt.RetType.ToString().Split('.')[StIt.RetType.ToString().Split('.').Count() - 1] + " : " + StIt.FrameName;

                    foreach(StackItemValue args in StIt.Args)
                    {
                        ListArgs += "A" + NumberArgs.ToString() + " --> " + args.Type.ToString() + " : " + args.Value.ToString() + "\r";
                        NumberArgs++;
                    }

                    foreach (StackItemValue locvars in StIt.VarLocals)
                    {
                        ListLocalsVars += "L" + NumberLocals.ToString() + " --> " + locvars.Type.ToString() + " : " + locvars.Value.ToString() + "\r";
                        NumberLocals++;
                    }

                    s[ButtonsBar.CurrentComputer.Stack.CurrentStack.Count - i - 1] = ListLocalsVars + ListArgs + BaseFrame;
                    i++;
                }
            }
            listboxStack.Items.AddRange(s);
        }

    }
}
