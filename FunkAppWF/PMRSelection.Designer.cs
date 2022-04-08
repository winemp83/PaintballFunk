namespace FunkAppWF
{
    partial class PMRSelection
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
            this.CmdOk = new System.Windows.Forms.Button();
            this.CmdCancel = new System.Windows.Forms.Button();
            this.LQuestion = new System.Windows.Forms.Label();
            this.LBSelection = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // CmdOk
            // 
            this.CmdOk.Location = new System.Drawing.Point(13, 126);
            this.CmdOk.Name = "CmdOk";
            this.CmdOk.Size = new System.Drawing.Size(75, 23);
            this.CmdOk.TabIndex = 0;
            this.CmdOk.Text = "OK";
            this.CmdOk.UseVisualStyleBackColor = true;
            this.CmdOk.Click += new System.EventHandler(this.CmdOk_Click);
            // 
            // CmdCancel
            // 
            this.CmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CmdCancel.Location = new System.Drawing.Point(197, 126);
            this.CmdCancel.Name = "CmdCancel";
            this.CmdCancel.Size = new System.Drawing.Size(75, 23);
            this.CmdCancel.TabIndex = 1;
            this.CmdCancel.Text = "Abbrechen";
            this.CmdCancel.UseVisualStyleBackColor = true;
            this.CmdCancel.Click += new System.EventHandler(this.CmdCancel_Click);
            // 
            // LQuestion
            // 
            this.LQuestion.AutoSize = true;
            this.LQuestion.Location = new System.Drawing.Point(12, 22);
            this.LQuestion.Name = "LQuestion";
            this.LQuestion.Size = new System.Drawing.Size(35, 13);
            this.LQuestion.TabIndex = 2;
            this.LQuestion.Text = "label1";
            // 
            // LBSelection
            // 
            this.LBSelection.FormattingEnabled = true;
            this.LBSelection.Location = new System.Drawing.Point(15, 55);
            this.LBSelection.Name = "LBSelection";
            this.LBSelection.Size = new System.Drawing.Size(257, 17);
            this.LBSelection.TabIndex = 3;
            this.LBSelection.SelectedIndexChanged += new System.EventHandler(this.LBSelection_SelectedIndexChanged);
            // 
            // PMRSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 157);
            this.ControlBox = false;
            this.Controls.Add(this.LBSelection);
            this.Controls.Add(this.LQuestion);
            this.Controls.Add(this.CmdCancel);
            this.Controls.Add(this.CmdOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PMRSelection";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PMRSelection";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdOk;
        private System.Windows.Forms.Button CmdCancel;
        private System.Windows.Forms.Label LQuestion;
        private System.Windows.Forms.ListBox LBSelection;
    }
}