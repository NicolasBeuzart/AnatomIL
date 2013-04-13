namespace AnatomIL
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbCodeZone = new System.Windows.Forms.TextBox();
            this.lbInstructions = new System.Windows.Forms.Label();
            this.btExecuteOneStep = new System.Windows.Forms.Button();
            this.panLeft = new System.Windows.Forms.Panel();
            this.panToolbar = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panInstructions = new System.Windows.Forms.Panel();
            this.splitPanelLeft = new System.Windows.Forms.Splitter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panMarginLeft = new System.Windows.Forms.Panel();
            this.listBoxInstructions = new System.Windows.Forms.ListBox();
            this.panLeft.SuspendLayout();
            this.panToolbar.SuspendLayout();
            this.panInstructions.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbCodeZone
            // 
            this.tbCodeZone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCodeZone.Location = new System.Drawing.Point(19, 13);
            this.tbCodeZone.Multiline = true;
            this.tbCodeZone.Name = "tbCodeZone";
            this.tbCodeZone.Size = new System.Drawing.Size(339, 443);
            this.tbCodeZone.TabIndex = 0;
            // 
            // lbInstructions
            // 
            this.lbInstructions.AutoSize = true;
            this.lbInstructions.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbInstructions.Location = new System.Drawing.Point(19, 0);
            this.lbInstructions.Name = "lbInstructions";
            this.lbInstructions.Size = new System.Drawing.Size(60, 13);
            this.lbInstructions.TabIndex = 1;
            this.lbInstructions.Text = "instructions";
            // 
            // btExecuteOneStep
            // 
            this.btExecuteOneStep.Dock = System.Windows.Forms.DockStyle.Left;
            this.btExecuteOneStep.Location = new System.Drawing.Point(0, 0);
            this.btExecuteOneStep.Name = "btExecuteOneStep";
            this.btExecuteOneStep.Size = new System.Drawing.Size(67, 32);
            this.btExecuteOneStep.TabIndex = 2;
            this.btExecuteOneStep.Text = "&Pas à pas";
            this.btExecuteOneStep.UseVisualStyleBackColor = true;
            this.btExecuteOneStep.Click += new System.EventHandler(this.btExecuteOneStep_Click);
            // 
            // panLeft
            // 
            this.panLeft.Controls.Add(this.panInstructions);
            this.panLeft.Controls.Add(this.panToolbar);
            this.panLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panLeft.Location = new System.Drawing.Point(0, 24);
            this.panLeft.MinimumSize = new System.Drawing.Size(300, 0);
            this.panLeft.Name = "panLeft";
            this.panLeft.Size = new System.Drawing.Size(358, 488);
            this.panLeft.TabIndex = 3;
            // 
            // panToolbar
            // 
            this.panToolbar.Controls.Add(this.button1);
            this.panToolbar.Controls.Add(this.btExecuteOneStep);
            this.panToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panToolbar.Location = new System.Drawing.Point(0, 0);
            this.panToolbar.Name = "panToolbar";
            this.panToolbar.Size = new System.Drawing.Size(358, 32);
            this.panToolbar.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.Location = new System.Drawing.Point(67, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 32);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panInstructions
            // 
            this.panInstructions.Controls.Add(this.listBoxInstructions);
            this.panInstructions.Controls.Add(this.tbCodeZone);
            this.panInstructions.Controls.Add(this.lbInstructions);
            this.panInstructions.Controls.Add(this.panMarginLeft);
            this.panInstructions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panInstructions.Location = new System.Drawing.Point(0, 32);
            this.panInstructions.Name = "panInstructions";
            this.panInstructions.Size = new System.Drawing.Size(358, 456);
            this.panInstructions.TabIndex = 4;
            // 
            // splitPanelLeft
            // 
            this.splitPanelLeft.BackColor = System.Drawing.SystemColors.Highlight;
            this.splitPanelLeft.Location = new System.Drawing.Point(358, 24);
            this.splitPanelLeft.Name = "splitPanelLeft";
            this.splitPanelLeft.Size = new System.Drawing.Size(3, 488);
            this.splitPanelLeft.TabIndex = 4;
            this.splitPanelLeft.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(791, 24);
            this.menuStrip1.TabIndex = 5;
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
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.loadToolStripMenuItem.Text = "load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // panMarginLeft
            // 
            this.panMarginLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panMarginLeft.Location = new System.Drawing.Point(0, 0);
            this.panMarginLeft.Name = "panMarginLeft";
            this.panMarginLeft.Size = new System.Drawing.Size(19, 456);
            this.panMarginLeft.TabIndex = 6;
            // 
            // listBoxInstructions
            // 
            this.listBoxInstructions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxInstructions.Enabled = false;
            this.listBoxInstructions.FormattingEnabled = true;
            this.listBoxInstructions.Items.AddRange(new object[] {
            "ldc.i4.56"});
            this.listBoxInstructions.Location = new System.Drawing.Point(19, 13);
            this.listBoxInstructions.Name = "listBoxInstructions";
            this.listBoxInstructions.Size = new System.Drawing.Size(339, 443);
            this.listBoxInstructions.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 512);
            this.Controls.Add(this.splitPanelLeft);
            this.Controls.Add(this.panLeft);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.panLeft.ResumeLayout(false);
            this.panToolbar.ResumeLayout(false);
            this.panInstructions.ResumeLayout(false);
            this.panInstructions.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCodeZone;
        private System.Windows.Forms.Label lbInstructions;
        private System.Windows.Forms.Button btExecuteOneStep;
        private System.Windows.Forms.Panel panLeft;
        private System.Windows.Forms.Panel panInstructions;
        private System.Windows.Forms.Panel panToolbar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Splitter splitPanelLeft;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.Panel panMarginLeft;
        private System.Windows.Forms.ListBox listBoxInstructions;
    }
}

