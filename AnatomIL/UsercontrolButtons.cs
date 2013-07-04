﻿using System;
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
        int g;

        public UserControlButtons()
        {
            InitializeComponent();

        }

        
        public UserControlCodeZone Code { get; set; }
        public UserControlTextBoxError Error { get; set; }
        public UserControlStack Stack { get; set; }
        public GraphPanel.GraphControl GraphController { get; set; }
        
        IlComputer computer = new IlComputer();

        public IlComputer CurrentComputer { get { return computer; } }

        public System.Windows.Forms.Timer GoTimer = new System.Windows.Forms.Timer();

        private void btGo_Click(object sender, EventArgs e)
        {
            
            btCompile.Visible = false;
            btStop.Visible = true;
            btGo.Visible = false;
            timeBox.Visible = false;
            ShowPc.Visible = false;
            ShowStack.Visible = false;

           // Code.BreakPointList.Enabled = false;

            if (!ShowPc.Checked)
            {
                Code.listBoxInstructions.Visible = false;
                Code.textBoxCode.Visible = true;
            }


            int intervalTime = Convert.ToInt32(timeBox.Text);

            if (intervalTime == 0)
            {

                GoTimer.Interval = 10;
                GoTimer.Tick += new EventHandler(null_timer_execution);
                GoTimer.Start();
            }
            else
            {

                GoTimer.Interval = intervalTime;
                GoTimer.Tick += new EventHandler(btExecuteOneStep_Click);
                GoTimer.Start();
            }
        }

        private void btExecuteOneStep_Click(object sender, EventArgs e)
        {
            if (computer.Pc < Code.listBoxInstructions.Items.Count)
            {
                if (Code.BreakPointList.CheckedItems.Contains(computer.Pc + 1))
                {
                    GoTimer.Stop();
                    bt_continue.Visible = true;
                }
                else
                {
                    computer.ExecuteNextInstruction();

                    if (computer.ErrorMessages.Count > 0)
                    {
                        GoTimer.Stop();
                        btCompile.Visible = true;
                        Error.Visible = true;
                        btGo.Visible = false;
                        timeBox.Visible = false;
                        ShowPc.Visible = false;
                        ShowStack.Visible = false;
                        btExecuteOneStep.Visible = false;
                        btStop.Visible = false;
                        Code.listBoxInstructions.Visible = false;
                        Code.textBoxCode.Visible = true;
                    }
                    else
                    {
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
                            ShowPc.Visible = false;
                            ShowStack.Visible = false;
                            btCompile.Visible = true;
                            btStop.Visible = false;
                        }
                        if (ShowStack.Checked)
                            Stack.ShowStack();


                        if (g != CurrentComputer.Graph.CurrentGraph.Count)
                        {
                            g = CurrentComputer.Graph.CurrentGraph.Count;
                            GraphController.Invalidate();
                        }
                    }
                }
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
            Code.BreakPointList.Visible = false;
            btExecuteOneStep.Visible = false;
            btGo.Visible = false;
            timeBox.Visible = false;
            ShowPc.Visible = false;
            ShowStack.Visible = false;
            btCompile.Visible = true;
            btStop.Visible = false;
            GoTimer.Stop();
        }

        private void btCompile_Click(object sender, EventArgs e)
        {
            g = CurrentComputer.Graph.CurrentGraph.Count;
               Error.Visible = false;
               Stack.listboxStack.Items.Clear();

               btExecuteOneStep.Visible = true;
               btGo.Visible = true;
               timeBox.Visible = true;
               ShowPc.Visible = true;
               ShowStack.Visible = true;
               
               computer.reset();

               GraphController.Refresh();

               Code.listBoxInstructions.Visible = true;
               Code.textBoxCode.Visible = false;

               string s = Code.textBoxCode.Text.Replace("\r", "");
               string[] s2 = s.Split(new char[] { '\n' });

               Code.listBoxInstructions.Items.Clear();
               Code.listBoxInstructions.Items.AddRange(s2);
               
               computer.LoadCode(s2);
              
               computer.compile();

               Code.BreakPointList.Enabled = !Code.BreakPointList.Enabled;
               
               Code.BreakPointList.Visible = true;
               
               if (computer.ErrorMessages.Count > 0)
               {
                   Error.Visible = true;
                   btGo.Visible = false;
                   timeBox.Visible = false;
                   ShowPc.Visible = false;
                   ShowStack.Visible = false;
                   btExecuteOneStep.Visible = false;
                   btStop.Visible = false;
                   Code.listBoxInstructions.Visible = false;
                   Code.textBoxCode.Visible = true;
                   Code.BreakPointList.Enabled = false;
               }
               else
               {
                   computer.Start();
                   Code.listBoxInstructions.SelectedIndex = computer.Pc;
                   Code.BreakPointList.Enabled = true;
               }
        }

        private void bt_restart_Click(object sender, EventArgs e)
        {
            bt_continue.Visible = false;

            computer.ExecuteNextInstruction();

            if (computer.Pc < Code.listBoxInstructions.Items.Count)
            {
                Code.listBoxInstructions.SelectedIndex = computer.Pc;
            }
            else
            {
                Code.listBoxInstructions.Visible = false;
                Code.textBoxCode.Visible = true;
                Code.BreakPointList.Visible = false;
                btExecuteOneStep.Visible = false;
                btGo.Visible = false;
                timeBox.Visible = false;
                ShowPc.Visible = false;
                ShowStack.Visible = false;
                btCompile.Visible = true;
                btStop.Visible = false;
            }
            if (ShowStack.Checked)
                Stack.ShowStack();

            btGo_Click(this, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            computer.Graph.ClearScreen();
            GraphController.Refresh();
        }

        private void bt_help_Click(object sender, EventArgs e)
        {
            Help fenetre = new Help();
            fenetre.ShowDialog(this);
        }

        private void null_timer_execution(object sender, EventArgs e)
        {
            int i;

            for(i=0; i<100;i++)
            {
                if (computer.Pc < Code.listBoxInstructions.Items.Count)
                {
                    if (Code.BreakPointList.CheckedItems.Contains(computer.Pc + 1))
                    {
                        GoTimer.Stop();
                        bt_continue.Visible = true;
                    }
                    else
                    {
                        computer.ExecuteNextInstruction();

                        if (computer.ErrorMessages.Count > 0)
                        {
                            // GoTimer.Stop();
                            btCompile.Visible = true;
                            Error.Visible = true;
                            btGo.Visible = false;
                            timeBox.Visible = false;
                            ShowPc.Visible = false;
                            ShowStack.Visible = false;
                            btExecuteOneStep.Visible = false;
                            btStop.Visible = false;
                            Code.listBoxInstructions.Visible = false;
                            Code.textBoxCode.Visible = true;
                        }
                        else
                        {
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
                                ShowPc.Visible = false;
                                ShowStack.Visible = false;
                                btCompile.Visible = true;
                                btStop.Visible = false;
                            }
                        }
                    }
                }
                else
                {
                    if (ShowStack.Checked)
                        Stack.ShowStack();
                    GraphController.Invalidate();
                    btStop_Click(this, e);
                }
            }

            if (ShowStack.Checked)
                Stack.ShowStack();

            GraphController.Invalidate();
        }

    }
}
