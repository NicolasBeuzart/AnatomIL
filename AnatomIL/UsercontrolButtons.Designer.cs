namespace AnatomIL
{
    partial class UserControlButtons
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
            this.timeBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btExecuteOneStep
            // 
            this.btExecuteOneStep.Location = new System.Drawing.Point(3, 14);
            this.btExecuteOneStep.Name = "btExecuteOneStep";
            this.btExecuteOneStep.Size = new System.Drawing.Size(92, 24);
            this.btExecuteOneStep.TabIndex = 0;
            this.btExecuteOneStep.Text = "Pas à pas";
            this.btExecuteOneStep.UseVisualStyleBackColor = true;
            this.btExecuteOneStep.Visible = false;
            this.btExecuteOneStep.Click += new System.EventHandler(this.btExecuteOneStep_Click);
            // 
            // btGo
            // 
            this.btGo.Location = new System.Drawing.Point(101, 14);
            this.btGo.Name = "btGo";
            this.btGo.Size = new System.Drawing.Size(92, 24);
            this.btGo.TabIndex = 1;
            this.btGo.Text = "Go";
            this.btGo.UseVisualStyleBackColor = true;
            this.btGo.Visible = false;
            this.btGo.Click += new System.EventHandler(this.btGo_Click);
            // 
            // btStop
            // 
            this.btStop.Location = new System.Drawing.Point(260, 13);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(92, 24);
            this.btStop.TabIndex = 2;
            this.btStop.Text = "Stop/Break";
            this.btStop.UseVisualStyleBackColor = true;
            this.btStop.Visible = false;
            this.btStop.Click += new System.EventHandler(this.btStop_Click);
            // 
            // btCompile
            // 
            this.btCompile.Location = new System.Drawing.Point(358, 13);
            this.btCompile.Name = "btCompile";
            this.btCompile.Size = new System.Drawing.Size(92, 24);
            this.btCompile.TabIndex = 3;
            this.btCompile.Text = "Compile";
            this.btCompile.UseVisualStyleBackColor = true;
            this.btCompile.Click += new System.EventHandler(this.btCompile_Click);
            // 
            // timeBox
            // 
            this.timeBox.Location = new System.Drawing.Point(199, 17);
            this.timeBox.Name = "timeBox";
            this.timeBox.Size = new System.Drawing.Size(38, 20);
            this.timeBox.TabIndex = 4;
            this.timeBox.Tag = "";
            this.timeBox.Text = "500";
            this.timeBox.Visible = false;
            // 
            // UserControlButtons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.timeBox);
            this.Controls.Add(this.btCompile);
            this.Controls.Add(this.btStop);
            this.Controls.Add(this.btGo);
            this.Controls.Add(this.btExecuteOneStep);
            this.Name = "UserControlButtons";
            this.Size = new System.Drawing.Size(460, 47);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btExecuteOneStep;
        private System.Windows.Forms.Button btGo;
        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.Button btCompile;
        private System.Windows.Forms.TextBox timeBox;
    }
}
