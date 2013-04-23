namespace AnatomIL
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userControlTextBoxError1 = new AnatomIL.UserControlTextBoxError();
            this.userControlHeap1 = new AnatomIL.UserControlHeap();
            this.userControlStack1 = new AnatomIL.UserControlStack();
            this.userControlCodeZone1 = new AnatomIL.UserControlCodeZone();
            this.usercontrolButtons1 = new AnatomIL.UsercontrolButtons();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(760, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.loadToolStripMenuItem.Text = "Load";
            // 
            // userControlTextBoxError1
            // 
            this.userControlTextBoxError1.Dock = System.Windows.Forms.DockStyle.Right;
            this.userControlTextBoxError1.Location = new System.Drawing.Point(307, 96);
            this.userControlTextBoxError1.Name = "userControlTextBoxError1";
            this.userControlTextBoxError1.Size = new System.Drawing.Size(317, 150);
            this.userControlTextBoxError1.TabIndex = 5;
            // 
            // userControlHeap1
            // 
            this.userControlHeap1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.userControlHeap1.Location = new System.Drawing.Point(307, 246);
            this.userControlHeap1.Name = "userControlHeap1";
            this.userControlHeap1.Size = new System.Drawing.Size(317, 210);
            this.userControlHeap1.TabIndex = 4;
            // 
            // userControlStack1
            // 
            this.userControlStack1.Dock = System.Windows.Forms.DockStyle.Right;
            this.userControlStack1.Location = new System.Drawing.Point(624, 96);
            this.userControlStack1.Name = "userControlStack1";
            this.userControlStack1.Size = new System.Drawing.Size(136, 360);
            this.userControlStack1.TabIndex = 3;
            // 
            // userControlCodeZone1
            // 
            this.userControlCodeZone1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.userControlCodeZone1.Dock = System.Windows.Forms.DockStyle.Left;
            this.userControlCodeZone1.Location = new System.Drawing.Point(0, 96);
            this.userControlCodeZone1.Name = "userControlCodeZone1";
            this.userControlCodeZone1.Size = new System.Drawing.Size(307, 360);
            this.userControlCodeZone1.TabIndex = 2;
            // 
            // usercontrolButtons1
            // 
            this.usercontrolButtons1.Dock = System.Windows.Forms.DockStyle.Top;
            this.usercontrolButtons1.Location = new System.Drawing.Point(0, 24);
            this.usercontrolButtons1.Name = "usercontrolButtons1";
            this.usercontrolButtons1.Size = new System.Drawing.Size(760, 72);
            this.usercontrolButtons1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 456);
            this.Controls.Add(this.userControlTextBoxError1);
            this.Controls.Add(this.userControlHeap1);
            this.Controls.Add(this.userControlStack1);
            this.Controls.Add(this.userControlCodeZone1);
            this.Controls.Add(this.usercontrolButtons1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private UsercontrolButtons usercontrolButtons1;
        private UserControlCodeZone userControlCodeZone1;
        private UserControlStack userControlStack1;
        private UserControlHeap userControlHeap1;
        private UserControlTextBoxError userControlTextBoxError1;


    }
}