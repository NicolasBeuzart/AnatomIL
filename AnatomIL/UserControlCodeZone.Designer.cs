namespace AnatomIL
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
            this.panInstruction.SuspendLayout();
            this.SuspendLayout();
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
            this.lbInstructions.Size = new System.Drawing.Size(67, 13);
            this.lbInstructions.TabIndex = 0;
            this.lbInstructions.Text = "Instructions :";
            // 
            // textBoxCode
            // 
            this.textBoxCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCode.Location = new System.Drawing.Point(0, 23);
            this.textBoxCode.Multiline = true;
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.Size = new System.Drawing.Size(307, 304);
            this.textBoxCode.TabIndex = 2;
            // 
            // listBoxInstructions
            // 
            this.listBoxInstructions.Enabled = false;
            this.listBoxInstructions.FormattingEnabled = true;
            this.listBoxInstructions.Location = new System.Drawing.Point(0, 23);
            this.listBoxInstructions.Name = "listBoxInstructions";
            this.listBoxInstructions.Size = new System.Drawing.Size(304, 303);
            this.listBoxInstructions.TabIndex = 3;
            // 
            // UserControlCodeZone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxCode);
            this.Controls.Add(this.panInstruction);
            this.Controls.Add(this.listBoxInstructions);
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
    }
}
