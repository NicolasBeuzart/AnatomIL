namespace AnatomIL
{
    partial class UserControlStack
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.listboxStack = new System.Windows.Forms.ListBox();
            this.labStack = new System.Windows.Forms.Label();
            this.panelTopOfStack = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // listboxStack
            // 
            this.listboxStack.Dock = System.Windows.Forms.DockStyle.Right;
            this.listboxStack.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listboxStack.FormattingEnabled = true;
            this.listboxStack.ItemHeight = 25;
            this.listboxStack.Location = new System.Drawing.Point(1, 44);
            this.listboxStack.Name = "listboxStack";
            this.listboxStack.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listboxStack.Size = new System.Drawing.Size(135, 189);
            this.listboxStack.TabIndex = 1;
            // 
            // labStack
            // 
            this.labStack.AutoSize = true;
            this.labStack.Dock = System.Windows.Forms.DockStyle.Top;
            this.labStack.Location = new System.Drawing.Point(0, 31);
            this.labStack.Name = "labStack";
            this.labStack.Size = new System.Drawing.Size(41, 13);
            this.labStack.TabIndex = 10;
            this.labStack.Text = "Stack :";
            // 
            // panelTopOfStack
            // 
            this.panelTopOfStack.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopOfStack.Location = new System.Drawing.Point(0, 0);
            this.panelTopOfStack.Name = "panelTopOfStack";
            this.panelTopOfStack.Size = new System.Drawing.Size(136, 31);
            this.panelTopOfStack.TabIndex = 11;
            // 
            // UserControlStack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listboxStack);
            this.Controls.Add(this.labStack);
            this.Controls.Add(this.panelTopOfStack);
            this.Name = "UserControlStack";
            this.Size = new System.Drawing.Size(136, 233);
            this.ParentChanged += new System.EventHandler(this.UserControlStack_ParentChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listboxStack;
        private System.Windows.Forms.Label labStack;
        private System.Windows.Forms.Panel panelTopOfStack;
    }
}
