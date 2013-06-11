namespace AnatomIL
{
    partial class Help
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Help));
            this.Helpbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Helpbox
            // 
            this.Helpbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Helpbox.Location = new System.Drawing.Point(0, 0);
            this.Helpbox.Multiline = true;
            this.Helpbox.Name = "Helpbox";
            this.Helpbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Helpbox.Size = new System.Drawing.Size(773, 567);
            this.Helpbox.TabIndex = 0;
            this.Helpbox.Text = resources.GetString("Helpbox.Text");
            // 
            // Help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 567);
            this.Controls.Add(this.Helpbox);
            this.Name = "Help";
            this.Text = "Help";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Helpbox;
    }
}