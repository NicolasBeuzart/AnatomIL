using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace AnatomIL
{
    public partial class UserControlMenu : UserControl
    {
        public UserControlMenu()
        {
            InitializeComponent();
        }

        public UserControlCodeZone Code { get; set; }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog loadCode = new OpenFileDialog();
            loadCode.Filter = "Text Files (*.txt)|*.txt";
            loadCode.Title = "Load Code";
            DialogResult dr = loadCode.ShowDialog();
            if (dr == DialogResult.OK)
            {
                Code.textBoxCode.Clear();
                string filePath = loadCode.FileName;
                Code.textBoxCode.Text = System.IO.File.ReadAllText(filePath);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveCode = new SaveFileDialog();

            if (saveCode.ShowDialog() == DialogResult.OK)
            {
                string name = saveCode.FileName + ".txt";
                File.WriteAllText(name, Code.textBoxCode.Text);
            }
        }
    }
}
