﻿namespace AnatomIL
{
    partial class UserControlCodeZone
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
            this.textBoxCode = new System.Windows.Forms.TextBox();
            this.panInstruction = new System.Windows.Forms.Panel();
            this.lbInstructions = new System.Windows.Forms.Label();
            this.panInstruction.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxCode
            // 
            this.textBoxCode.Location = new System.Drawing.Point(3, 17);
            this.textBoxCode.Multiline = true;
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.Size = new System.Drawing.Size(301, 307);
            this.textBoxCode.TabIndex = 0;
            // 
            // panInstruction
            // 
            this.panInstruction.Controls.Add(this.lbInstructions);
            this.panInstruction.Location = new System.Drawing.Point(3, 3);
            this.panInstruction.Name = "panInstruction";
            this.panInstruction.Size = new System.Drawing.Size(301, 17);
            this.panInstruction.TabIndex = 1;
            // 
            // lbInstructions
            // 
            this.lbInstructions.AutoSize = true;
            this.lbInstructions.Location = new System.Drawing.Point(3, 4);
            this.lbInstructions.Name = "lbInstructions";
            this.lbInstructions.Size = new System.Drawing.Size(61, 13);
            this.lbInstructions.TabIndex = 0;
            this.lbInstructions.Text = "Instructions";
            // 
            // UserControlCodeZone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panInstruction);
            this.Controls.Add(this.textBoxCode);
            this.Name = "UserControlCodeZone";
            this.Size = new System.Drawing.Size(307, 327);
            this.Load += new System.EventHandler(this.UserControlCodeZone_Load);
            this.panInstruction.ResumeLayout(false);
            this.panInstruction.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCode;
        private System.Windows.Forms.Panel panInstruction;
        private System.Windows.Forms.Label lbInstructions;
    }
}
