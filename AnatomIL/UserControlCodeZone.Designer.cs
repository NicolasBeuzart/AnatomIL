﻿namespace AnatomIL
{
    public partial class UserControlCodeZone
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panInstruction = new System.Windows.Forms.Panel();
            this.lbInstructions = new System.Windows.Forms.Label();
            this.textBoxCode = new System.Windows.Forms.TextBox();
            this.listBoxInstructions = new System.Windows.Forms.ListBox();
            this.BreakPointList = new System.Windows.Forms.CheckedListBox();
            this.panInstruction.SuspendLayout();
            this.SuspendLayout();
            // 
            // panInstruction
            // 
            this.panInstruction.Controls.Add(this.lbInstructions);
            this.panInstruction.Dock = System.Windows.Forms.DockStyle.Top;
            this.panInstruction.Location = new System.Drawing.Point(0, 0);
            this.panInstruction.Name = "panInstruction";
            this.panInstruction.Size = new System.Drawing.Size(307, 17);
            this.panInstruction.TabIndex = 1;
            // 
            // lbInstructions
            // 
            this.lbInstructions.AutoSize = true;
            this.lbInstructions.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbInstructions.Location = new System.Drawing.Point(0, 0);
            this.lbInstructions.Name = "lbInstructions";
            this.lbInstructions.Size = new System.Drawing.Size(67, 13);
            this.lbInstructions.TabIndex = 0;
            this.lbInstructions.Text = "Instructions :";
            // 
            // textBoxCode
            // 
            this.textBoxCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCode.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCode.Location = new System.Drawing.Point(68, 17);
            this.textBoxCode.Multiline = true;
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxCode.Size = new System.Drawing.Size(236, 307);
            this.textBoxCode.TabIndex = 2;
            this.textBoxCode.Text = "void main()\r\n{\r\n\r\n\r\n}";
            // 
            // listBoxInstructions
            // 
            this.listBoxInstructions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxInstructions.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxInstructions.FormattingEnabled = true;
            this.listBoxInstructions.ItemHeight = 16;
            this.listBoxInstructions.Location = new System.Drawing.Point(62, 17);
            this.listBoxInstructions.Name = "listBoxInstructions";
            this.listBoxInstructions.ScrollAlwaysVisible = true;
            this.listBoxInstructions.Size = new System.Drawing.Size(245, 310);
            this.listBoxInstructions.TabIndex = 3;
            this.listBoxInstructions.Visible = false;
            this.listBoxInstructions.SelectedIndexChanged += new System.EventHandler(this.listBoxInstructions_SelectedIndexChanged);
            // 
            // BreakPointList
            // 
            this.BreakPointList.Dock = System.Windows.Forms.DockStyle.Left;
            this.BreakPointList.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BreakPointList.Location = new System.Drawing.Point(0, 17);
            this.BreakPointList.MinimumSize = new System.Drawing.Size(50, 4);
            this.BreakPointList.Name = "BreakPointList";
            this.BreakPointList.Size = new System.Drawing.Size(62, 310);
            this.BreakPointList.TabIndex = 4;
            this.BreakPointList.Visible = false;
            this.BreakPointList.EnabledChanged += new System.EventHandler(this.BreakPointList_EnabledChanged);
            // 
            // UserControlCodeZone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listBoxInstructions);
            this.Controls.Add(this.BreakPointList);
            this.Controls.Add(this.panInstruction);
            this.Controls.Add(this.textBoxCode);
            this.Name = "UserControlCodeZone";
            this.Size = new System.Drawing.Size(307, 327);
            this.panInstruction.ResumeLayout(false);
            this.panInstruction.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panInstruction;
        private System.Windows.Forms.Label lbInstructions;
        public System.Windows.Forms.TextBox textBoxCode;
        public System.Windows.Forms.ListBox listBoxInstructions;
        public System.Windows.Forms.CheckedListBox BreakPointList;
    }
}
