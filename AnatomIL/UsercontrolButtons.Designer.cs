namespace AnatomIL
{
    partial class UsercontrolButtons
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
            this.btExecuteOneStep = new System.Windows.Forms.Button();
            this.btGo = new System.Windows.Forms.Button();
            this.btStop = new System.Windows.Forms.Button();
            this.btCompile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btExecuteOneStep
            // 
            this.btExecuteOneStep.Location = new System.Drawing.Point(3, 14);
            this.btExecuteOneStep.Name = "btExecuteOneStep";
            this.btExecuteOneStep.Size = new System.Drawing.Size(92, 47);
            this.btExecuteOneStep.TabIndex = 0;
            this.btExecuteOneStep.Text = "Pas à pas";
            this.btExecuteOneStep.UseVisualStyleBackColor = true;
            this.btExecuteOneStep.Click += new System.EventHandler(this.btExecuteOneStep_Click);
            // 
            // btGo
            // 
            this.btGo.Location = new System.Drawing.Point(101, 14);
            this.btGo.Name = "btGo";
            this.btGo.Size = new System.Drawing.Size(92, 47);
            this.btGo.TabIndex = 1;
            this.btGo.Text = "Go";
            this.btGo.UseVisualStyleBackColor = true;
            this.btGo.Click += new System.EventHandler(this.btGo_Click);
            // 
            // btStop
            // 
            this.btStop.Location = new System.Drawing.Point(199, 14);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(92, 47);
            this.btStop.TabIndex = 2;
            this.btStop.Text = "Stop";
            this.btStop.UseVisualStyleBackColor = true;
            this.btStop.Click += new System.EventHandler(this.btStop_Click);
            // 
            // btCompile
            // 
            this.btCompile.Location = new System.Drawing.Point(297, 14);
            this.btCompile.Name = "btCompile";
            this.btCompile.Size = new System.Drawing.Size(92, 47);
            this.btCompile.TabIndex = 3;
            this.btCompile.Text = "Compile";
            this.btCompile.UseVisualStyleBackColor = true;
            this.btCompile.Click += new System.EventHandler(this.btCompile_Click);
            // 
            // UsercontrolButtons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btCompile);
            this.Controls.Add(this.btStop);
            this.Controls.Add(this.btGo);
            this.Controls.Add(this.btExecuteOneStep);
            this.Name = "UsercontrolButtons";
            this.Size = new System.Drawing.Size(395, 72);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btExecuteOneStep;
        private System.Windows.Forms.Button btGo;
        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.Button btCompile;
    }
}
