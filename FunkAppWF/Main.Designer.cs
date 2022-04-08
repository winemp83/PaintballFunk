namespace FunkAppWF
{
    partial class Main
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tSSL = new System.Windows.Forms.ToolStripStatusLabel();
            this.dGV = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suchenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cTSSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cTSS38ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pMR466ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nachNummerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nachFrequenzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gB = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rTBPAn = new System.Windows.Forms.RichTextBox();
            this.tBCTon = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tBCID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tBC38 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tBPFreq = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tBPID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.gB.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tSSL});
            this.statusStrip1.Location = new System.Drawing.Point(0, 420);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(629, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(132, 17);
            this.toolStripStatusLabel1.Text = "Angezeigte Datensätze :";
            // 
            // tSSL
            // 
            this.tSSL.Name = "tSSL";
            this.tSSL.Size = new System.Drawing.Size(118, 17);
            this.tSSL.Text = "toolStripStatusLabel2";
            // 
            // dGV
            // 
            this.dGV.AllowUserToAddRows = false;
            this.dGV.AllowUserToDeleteRows = false;
            this.dGV.AllowUserToResizeColumns = false;
            this.dGV.AllowUserToResizeRows = false;
            this.dGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dGV.Location = new System.Drawing.Point(13, 27);
            this.dGV.MultiSelect = false;
            this.dGV.Name = "dGV";
            this.dGV.ReadOnly = true;
            this.dGV.Size = new System.Drawing.Size(200, 398);
            this.dGV.TabIndex = 1;
            this.dGV.SelectionChanged += new System.EventHandler(this.dGV_SelectionChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainToolStripMenuItem,
            this.suchenToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(629, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mainToolStripMenuItem
            // 
            this.mainToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.beendenToolStripMenuItem});
            this.mainToolStripMenuItem.Name = "mainToolStripMenuItem";
            this.mainToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.mainToolStripMenuItem.Text = "Main";
            // 
            // beendenToolStripMenuItem
            // 
            this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            this.beendenToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.beendenToolStripMenuItem.Text = "Beenden";
            this.beendenToolStripMenuItem.Click += new System.EventHandler(this.beendenToolStripMenuItem_Click);
            // 
            // suchenToolStripMenuItem
            // 
            this.suchenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cTSSToolStripMenuItem,
            this.cTSS38ToolStripMenuItem,
            this.pMR466ToolStripMenuItem});
            this.suchenToolStripMenuItem.Name = "suchenToolStripMenuItem";
            this.suchenToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.suchenToolStripMenuItem.Text = "Suchen";
            // 
            // cTSSToolStripMenuItem
            // 
            this.cTSSToolStripMenuItem.Name = "cTSSToolStripMenuItem";
            this.cTSSToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cTSSToolStripMenuItem.Text = "CTSS";
            this.cTSSToolStripMenuItem.Click += new System.EventHandler(this.cTSSToolStripMenuItem_Click);
            // 
            // cTSS38ToolStripMenuItem
            // 
            this.cTSS38ToolStripMenuItem.Name = "cTSS38ToolStripMenuItem";
            this.cTSS38ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cTSS38ToolStripMenuItem.Text = "CTSS38";
            this.cTSS38ToolStripMenuItem.Click += new System.EventHandler(this.cTSS38ToolStripMenuItem_Click);
            // 
            // pMR466ToolStripMenuItem
            // 
            this.pMR466ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nachNummerToolStripMenuItem,
            this.nachFrequenzToolStripMenuItem});
            this.pMR466ToolStripMenuItem.Name = "pMR466ToolStripMenuItem";
            this.pMR466ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pMR466ToolStripMenuItem.Text = "PMR466";
            // 
            // nachNummerToolStripMenuItem
            // 
            this.nachNummerToolStripMenuItem.Name = "nachNummerToolStripMenuItem";
            this.nachNummerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nachNummerToolStripMenuItem.Text = "Nach Nummer";
            this.nachNummerToolStripMenuItem.Click += new System.EventHandler(this.nachNummerToolStripMenuItem_Click);
            // 
            // nachFrequenzToolStripMenuItem
            // 
            this.nachFrequenzToolStripMenuItem.Name = "nachFrequenzToolStripMenuItem";
            this.nachFrequenzToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nachFrequenzToolStripMenuItem.Text = "Nach Frequenz";
            this.nachFrequenzToolStripMenuItem.Click += new System.EventHandler(this.nachFrequenzToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.infoToolStripMenuItem.Text = "Info";
            // 
            // gB
            // 
            this.gB.Controls.Add(this.label6);
            this.gB.Controls.Add(this.rTBPAn);
            this.gB.Controls.Add(this.tBCTon);
            this.gB.Controls.Add(this.label5);
            this.gB.Controls.Add(this.tBCID);
            this.gB.Controls.Add(this.label4);
            this.gB.Controls.Add(this.tBC38);
            this.gB.Controls.Add(this.label3);
            this.gB.Controls.Add(this.tBPFreq);
            this.gB.Controls.Add(this.label2);
            this.gB.Controls.Add(this.tBPID);
            this.gB.Controls.Add(this.label1);
            this.gB.Location = new System.Drawing.Point(219, 27);
            this.gB.Name = "gB";
            this.gB.Size = new System.Drawing.Size(400, 397);
            this.gB.TabIndex = 4;
            this.gB.TabStop = false;
            this.gB.Text = "Informationen";
            this.gB.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Anmerkungen : ";
            // 
            // rTBPAn
            // 
            this.rTBPAn.Location = new System.Drawing.Point(110, 144);
            this.rTBPAn.Name = "rTBPAn";
            this.rTBPAn.Size = new System.Drawing.Size(284, 96);
            this.rTBPAn.TabIndex = 26;
            this.rTBPAn.Text = "";
            // 
            // tBCTon
            // 
            this.tBCTon.Location = new System.Drawing.Point(110, 117);
            this.tBCTon.Name = "tBCTon";
            this.tBCTon.Size = new System.Drawing.Size(284, 20);
            this.tBCTon.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "CTSS38 Channel : ";
            // 
            // tBCID
            // 
            this.tBCID.Location = new System.Drawing.Point(110, 65);
            this.tBCID.Name = "tBCID";
            this.tBCID.Size = new System.Drawing.Size(284, 20);
            this.tBCID.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "CTSS Channel : ";
            // 
            // tBC38
            // 
            this.tBC38.Location = new System.Drawing.Point(110, 91);
            this.tBC38.Name = "tBC38";
            this.tBC38.Size = new System.Drawing.Size(284, 20);
            this.tBC38.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "CTSS Ton : ";
            // 
            // tBPFreq
            // 
            this.tBPFreq.Location = new System.Drawing.Point(110, 39);
            this.tBPFreq.Name = "tBPFreq";
            this.tBPFreq.Size = new System.Drawing.Size(284, 20);
            this.tBPFreq.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Frequenz : ";
            // 
            // tBPID
            // 
            this.tBPID.Location = new System.Drawing.Point(110, 13);
            this.tBPID.Name = "tBPID";
            this.tBPID.Size = new System.Drawing.Size(284, 20);
            this.tBPID.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Channel : ";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 442);
            this.ControlBox = false;
            this.Controls.Add(this.gB);
            this.Controls.Add(this.dGV);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FunkApp";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gB.ResumeLayout(false);
            this.gB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tSSL;
        private System.Windows.Forms.DataGridView dGV;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suchenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cTSSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cTSS38ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pMR466ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.GroupBox gB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox rTBPAn;
        private System.Windows.Forms.TextBox tBCTon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tBCID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tBC38;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tBPFreq;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBPID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem nachNummerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nachFrequenzToolStripMenuItem;
    }
}

