﻿using System;
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
    public partial class Anatomil : Form
    {
        Controleur c;

        public Anatomil()
        {
            InitializeComponent();
            listBoxInstructions.Visible = false;
            panTopOfStack.Height = panMarginLeftStack.Height - (listboxStack.ItemHeight * (listboxStack.Items.Count + 1));
        }

        private void btExecuteOneStep_Click(object sender, EventArgs e)
        {
            try
            {
                c.ExecuteNextInstruction();
            }
            catch (Exception exception)
            {
                textBoxError.Text = exception.Message;
                textBoxError.Visible = true;
            }
            if (c._pc < listBoxInstructions.Items.Count)
            {
                listBoxInstructions.SelectedIndex = c._pc;
            }
            else
            {
                btStart.Visible = true;
                btExecuteOneStep.Visible = false;
                listBoxInstructions.Visible = false;
                tbCodeZone.Visible = true;
            }
            listboxStack.Items.Clear();
            string[] s = new string[c.s.Count];
            int i = 0;
            foreach (StackItem StIt in c.s.CurrentStack)
            {
                s[c.s.CurrentStack.Count - i - 1] = StIt.Type.ToString().Split('.')[StIt.Type.ToString().Split('.').Count() - 1] + " : " + StIt.Value.ToString();
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
            c = new Controleur();
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
            try
            {
                c.compile(s2);
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
            listBoxInstructions.SelectedIndex = c._pc;
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

        
    }
}