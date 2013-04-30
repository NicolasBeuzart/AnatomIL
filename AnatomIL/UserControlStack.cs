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

        public void ShowStack(object sender, EventArgs e)
        {
            listboxStack.Items.Clear();
            string[] s = new string[ButtonsBar.CurrentComputer.Stack.Count];
            int i = 0;
            foreach (StackItem StIt in ButtonsBar.CurrentComputer.Stack.CurrentStack)
            {
                s[ButtonsBar.CurrentComputer.Stack.CurrentStack.Count - i - 1] = StIt.Type.ToString().Split('.')[StIt.Type.ToString().Split('.').Count() - 1] + " : " + StIt.Value.ToString();
                i++;
            }
            listboxStack.Items.AddRange(s);
        }

    }
}
