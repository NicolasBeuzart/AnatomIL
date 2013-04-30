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
    public partial class UserControlTextBoxError : UserControl
    {
        public UserControlTextBoxError()
        {
            InitializeComponent();
        }

        public UserControlButtons ButtonsBar { get; set; }

        private void UserControlTextBoxError_VisibleChanged(object sender, EventArgs e)
        {
            textBoxError.Visible = true;
            textBoxError.Clear();
            foreach(string ErrorMsg in ButtonsBar.CurrentComputer.ErrorMessages)
            {
                textBoxError.Text = textBoxError.Text + ErrorMsg + "\r";
            }
        }

    }
}
