namespace AnatomIL
{
    partial class Anatomil
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
            this.panInstructions = new System.Windows.Forms.Panel();
            this.listBoxInstructions = new System.Windows.Forms.ListBox();
            this.panMarginLeftInstructions = new System.Windows.Forms.Panel();
            this.panToolbar = new System.Windows.Forms.Panel();
            this.btStop = new System.Windows.Forms.Button();
            this.btStart = new System.Windows.Forms.Button();
            this.splitPanelLeft = new System.Windows.Forms.Splitter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listboxStack = new System.Windows.Forms.ListBox();
            this.panMarginLeftStack = new System.Windows.Forms.Panel();
            this.panLeftStack = new System.Windows.Forms.Panel();
            this.textBoxError = new System.Windows.Forms.TextBox();
            this.panTopOfStack = new System.Windows.Forms.Panel();
            this.labStack = new System.Windows.Forms.Label();
            this.panStack = new System.Windows.Forms.Panel();
            this.panLeft.SuspendLayout();
            this.panInstructions.SuspendLayout();
            this.panToolbar.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panMarginLeftStack.SuspendLayout();
            this.panStack.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbCodeZone
            // 
            this.tbCodeZone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCodeZone.Location = new System.Drawing.Point(19, 13);
            this.tbCodeZone.Multiline = true;
            this.tbCodeZone.Name = "tbCodeZone";
            this.tbCodeZone.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
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
            this.btExecuteOneStep.Visible = false;
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
            // panInstructions
            // 
            this.panInstructions.Controls.Add(this.tbCodeZone);
            this.panInstructions.Controls.Add(this.listBoxInstructions);
            this.panInstructions.Controls.Add(this.lbInstructions);
            this.panInstructions.Controls.Add(this.panMarginLeftInstructions);
            this.panInstructions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panInstructions.Location = new System.Drawing.Point(0, 32);
            this.panInstructions.Name = "panInstructions";
            this.panInstructions.Size = new System.Drawing.Size(358, 456);
            this.panInstructions.TabIndex = 4;
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
            this.listBoxInstructions.ScrollAlwaysVisible = true;
            this.listBoxInstructions.Size = new System.Drawing.Size(339, 443);
            this.listBoxInstructions.TabIndex = 6;
            // 
            // panMarginLeftInstructions
            // 
            this.panMarginLeftInstructions.Dock = System.Windows.Forms.DockStyle.Left;
            this.panMarginLeftInstructions.Location = new System.Drawing.Point(0, 0);
            this.panMarginLeftInstructions.Name = "panMarginLeftInstructions";
            this.panMarginLeftInstructions.Size = new System.Drawing.Size(19, 456);
            this.panMarginLeftInstructions.TabIndex = 6;
            // 
            // panToolbar
            // 
            this.panToolbar.Controls.Add(this.btStop);
            this.panToolbar.Controls.Add(this.btStart);
            this.panToolbar.Controls.Add(this.btExecuteOneStep);
            this.panToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panToolbar.Location = new System.Drawing.Point(0, 0);
            this.panToolbar.Name = "panToolbar";
            this.panToolbar.Size = new System.Drawing.Size(358, 32);
            this.panToolbar.TabIndex = 3;
            // 
            // btStop
            // 
            this.btStop.Dock = System.Windows.Forms.DockStyle.Left;
            this.btStop.Location = new System.Drawing.Point(142, 0);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(75, 32);
            this.btStop.TabIndex = 4;
            this.btStop.Text = "Stop";
            this.btStop.UseVisualStyleBackColor = true;
            this.btStop.Click += new System.EventHandler(this.btStop_Click);
            // 
            // btStart
            // 
            this.btStart.Dock = System.Windows.Forms.DockStyle.Left;
            this.btStart.Location = new System.Drawing.Point(67, 0);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(75, 32);
            this.btStart.TabIndex = 3;
            this.btStart.Text = "Start";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // splitPanelLeft
            // 
            this.splitPanelLeft.BackColor = System.Drawing.SystemColors.Control;
            this.splitPanelLeft.Location = new System.Drawing.Point(358, 24);
            this.splitPanelLeft.Name = "splitPanelLeft";
            this.splitPanelLeft.Size = new System.Drawing.Size(3, 488);
            this.splitPanelLeft.TabIndex = 4;
            this.splitPanelLeft.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.AppWorkspace;
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
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.saveToolStripMenuItem.Text = "save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.loadToolStripMenuItem.Text = "load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // listboxStack
            // 
            this.listboxStack.Dock = System.Windows.Forms.DockStyle.Right;
            this.listboxStack.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listboxStack.FormattingEnabled = true;
            this.listboxStack.ItemHeight = 25;
            this.listboxStack.Location = new System.Drawing.Point(-1, 13);
            this.listboxStack.Name = "listboxStack";
            this.listboxStack.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listboxStack.Size = new System.Drawing.Size(135, 458);
            this.listboxStack.TabIndex = 0;
            // 
            // panMarginLeftStack
            // 
            this.panMarginLeftStack.Controls.Add(this.panLeftStack);
            this.panMarginLeftStack.Controls.Add(this.textBoxError);
            this.panMarginLeftStack.Dock = System.Windows.Forms.DockStyle.Left;
            this.panMarginLeftStack.Location = new System.Drawing.Point(361, 24);
            this.panMarginLeftStack.Name = "panMarginLeftStack";
            this.panMarginLeftStack.Size = new System.Drawing.Size(296, 488);
            this.panMarginLeftStack.TabIndex = 7;
            // 
            // panLeftStack
            // 
            this.panLeftStack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panLeftStack.Location = new System.Drawing.Point(0, 105);
            this.panLeftStack.Name = "panLeftStack";
            this.panLeftStack.Size = new System.Drawing.Size(296, 383);
            this.panLeftStack.TabIndex = 1;
            // 
            // textBoxError
            // 
            this.textBoxError.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBoxError.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxError.ForeColor = System.Drawing.Color.Red;
            this.textBoxError.Location = new System.Drawing.Point(0, 0);
            this.textBoxError.Multiline = true;
            this.textBoxError.Name = "textBoxError";
            this.textBoxError.Size = new System.Drawing.Size(296, 105);
            this.textBoxError.TabIndex = 0;
            this.textBoxError.Visible = false;
            // 
            // panTopOfStack
            // 
            this.panTopOfStack.Dock = System.Windows.Forms.DockStyle.Top;
            this.panTopOfStack.Location = new System.Drawing.Point(657, 24);
            this.panTopOfStack.Name = "panTopOfStack";
            this.panTopOfStack.Size = new System.Drawing.Size(134, 17);
            this.panTopOfStack.TabIndex = 8;
            // 
            // labStack
            // 
            this.labStack.AutoSize = true;
            this.labStack.Dock = System.Windows.Forms.DockStyle.Top;
            this.labStack.Location = new System.Drawing.Point(0, 0);
            this.labStack.Name = "labStack";
            this.labStack.Size = new System.Drawing.Size(41, 13);
            this.labStack.TabIndex = 9;
            this.labStack.Text = "Stack :";
            // 
            // panStack
            // 
            this.panStack.Controls.Add(this.listboxStack);
            this.panStack.Controls.Add(this.labStack);
            this.panStack.Dock = System.Windows.Forms.DockStyle.Right;
            this.panStack.Location = new System.Drawing.Point(657, 41);
            this.panStack.Name = "panStack";
            this.panStack.Size = new System.Drawing.Size(134, 471);
            this.panStack.TabIndex = 9;
            // 
            // Anatomil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 512);
            this.Controls.Add(this.panStack);
            this.Controls.Add(this.panTopOfStack);
            this.Controls.Add(this.panMarginLeftStack);
            this.Controls.Add(this.splitPanelLeft);
            this.Controls.Add(this.panLeft);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Anatomil";
            this.Text = "AnatomIL";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.panLeft.ResumeLayout(false);
            this.panInstructions.ResumeLayout(false);
            this.panInstructions.PerformLayout();
            this.panToolbar.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panMarginLeftStack.ResumeLayout(false);
            this.panMarginLeftStack.PerformLayout();
            this.panStack.ResumeLayout(false);
            this.panStack.PerformLayout();
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
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Splitter splitPanelLeft;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.Panel panMarginLeftInstructions;
        private System.Windows.Forms.ListBox listBoxInstructions;
        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.ListBox listboxStack;
        private System.Windows.Forms.Panel panMarginLeftStack;
        private System.Windows.Forms.Panel panTopOfStack;
        private System.Windows.Forms.Label labStack;
        private System.Windows.Forms.TextBox textBoxError;
        private System.Windows.Forms.Panel panLeftStack;
        private System.Windows.Forms.Panel panStack;
    }
}

