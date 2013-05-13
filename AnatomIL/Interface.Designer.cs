namespace AnatomIL
{
    partial class Interface
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.userControlMenu1 = new AnatomIL.UserControlMenu();
            this._code = new AnatomIL.UserControlCodeZone();
            this._buttonBar = new AnatomIL.UserControlButtons();
            this._errors = new AnatomIL.UserControlTextBoxError();
            this._stack = new AnatomIL.UserControlStack();
            this.userControlHeap1 = new AnatomIL.UserControlHeap();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitContainer1.Location = new System.Drawing.Point(0, 119);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this._code);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(803, 374);
            this.splitContainer1.SplitterDistance = 372;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this._stack);
            this.splitContainer2.Size = new System.Drawing.Size(427, 374);
            this.splitContainer2.SplitterDistance = 180;
            this.splitContainer2.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this._errors);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.userControlHeap1);
            this.splitContainer3.Size = new System.Drawing.Size(180, 374);
            this.splitContainer3.SplitterDistance = 172;
            this.splitContainer3.TabIndex = 0;
            // 
            // userControlMenu1
            // 
            this.userControlMenu1.Code = this._code;
            this.userControlMenu1.Location = new System.Drawing.Point(0, 0);
            this.userControlMenu1.Name = "userControlMenu1";
            this.userControlMenu1.Size = new System.Drawing.Size(736, 32);
            this.userControlMenu1.TabIndex = 2;
            // 
            // _code
            // 
            this._code.Dock = System.Windows.Forms.DockStyle.Fill;
            this._code.Location = new System.Drawing.Point(0, 0);
            this._code.Name = "_code";
            this._code.Size = new System.Drawing.Size(372, 374);
            this._code.TabIndex = 0;
            // 
            // _buttonBar
            // 
            this._buttonBar.Code = this._code;
            this._buttonBar.Error = this._errors;
            this._buttonBar.Location = new System.Drawing.Point(0, 25);
            this._buttonBar.Name = "_buttonBar";
            this._buttonBar.Size = new System.Drawing.Size(454, 72);
            this._buttonBar.Stack = this._stack;
            this._buttonBar.TabIndex = 1;
            // 
            // _errors
            // 
            this._errors.ButtonsBar = this._buttonBar;
            this._errors.Dock = System.Windows.Forms.DockStyle.Fill;
            this._errors.Location = new System.Drawing.Point(0, 0);
            this._errors.Name = "_errors";
            this._errors.Size = new System.Drawing.Size(180, 172);
            this._errors.TabIndex = 0;
            this._errors.Visible = false;
            // 
            // _stack
            // 
            this._stack.ButtonsBar = this._buttonBar;
            this._stack.Dock = System.Windows.Forms.DockStyle.Fill;
            this._stack.Location = new System.Drawing.Point(0, 0);
            this._stack.Name = "_stack";
            this._stack.Size = new System.Drawing.Size(243, 374);
            this._stack.TabIndex = 0;
            // 
            // userControlHeap1
            // 
            this.userControlHeap1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlHeap1.Location = new System.Drawing.Point(0, 0);
            this.userControlHeap1.Name = "userControlHeap1";
            this.userControlHeap1.Size = new System.Drawing.Size(180, 198);
            this.userControlHeap1.TabIndex = 0;
            // 
            // Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 493);
            this.Controls.Add(this.userControlMenu1);
            this.Controls.Add(this._buttonBar);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Interface";
            this.Text = "Interface";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private UserControlButtons _buttonBar;
        private UserControlCodeZone _code;
        private UserControlTextBoxError _errors;
        private UserControlHeap userControlHeap1;
        private UserControlStack _stack;
        private UserControlMenu userControlMenu1;

    }
}