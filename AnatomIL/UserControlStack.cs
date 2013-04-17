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

        private void UserControlStack_ParentChanged(object sender, EventArgs e)
        {
            //listboxStack.
        }
    }
}
