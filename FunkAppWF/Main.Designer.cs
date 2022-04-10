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
            this.MainMenueFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenueFileLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.MainMenueFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenueEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenueEditNew = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenueEditEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenueEditDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenueSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenueSearchCTSS = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchMenueCTSSChanel = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchMenueCTSSTon = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenueSearchCTSS38 = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchMenueCTSS38Channel = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchMenueCTSS38Ton = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenueSearchPMR466 = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchPMR466Chanel = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchPMR466Frequenz = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenueSearchSaves = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchSavesName = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenueInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.gBEI = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tBPID = new System.Windows.Forms.TextBox();
            this.rTBPAn = new System.Windows.Forms.RichTextBox();
            this.tBCTon = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tBCID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tBC38 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tBPFreq = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tBID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gBAG = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.rTBAn = new System.Windows.Forms.RichTextBox();
            this.CmdSave = new System.Windows.Forms.Button();
            this.CmdNew = new System.Windows.Forms.Button();
            this.CmdCancel = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.gBEI.SuspendLayout();
            this.gBAG.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tSSL});
            this.statusStrip1.Location = new System.Drawing.Point(0, 466);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(617, 22);
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
            this.dGV.Size = new System.Drawing.Size(200, 444);
            this.dGV.TabIndex = 1;
            this.dGV.SelectionChanged += new System.EventHandler(this.DGV_SelectionChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainMenueFile,
            this.MainMenueEdit,
            this.MainMenueSearch,
            this.MainMenueInfo});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(617, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MainMenueFile
            // 
            this.MainMenueFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainMenueFileLoad,
            this.toolStripSeparator2,
            this.MainMenueFileExit});
            this.MainMenueFile.Name = "MainMenueFile";
            this.MainMenueFile.Size = new System.Drawing.Size(46, 20);
            this.MainMenueFile.Text = "Datei";
            // 
            // MainMenueFileLoad
            // 
            this.MainMenueFileLoad.Name = "MainMenueFileLoad";
            this.MainMenueFileLoad.Size = new System.Drawing.Size(180, 22);
            this.MainMenueFileLoad.Text = "Laden";
            this.MainMenueFileLoad.Click += new System.EventHandler(this.MainMenueFileLoad_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // MainMenueFileExit
            // 
            this.MainMenueFileExit.Name = "MainMenueFileExit";
            this.MainMenueFileExit.Size = new System.Drawing.Size(180, 22);
            this.MainMenueFileExit.Text = "Beenden";
            this.MainMenueFileExit.Click += new System.EventHandler(this.MainMenueFileExit_Click);
            // 
            // MainMenueEdit
            // 
            this.MainMenueEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainMenueEditNew,
            this.MainMenueEditEdit,
            this.MainMenueEditDelete});
            this.MainMenueEdit.Name = "MainMenueEdit";
            this.MainMenueEdit.Size = new System.Drawing.Size(75, 20);
            this.MainMenueEdit.Text = "Bearbeiten";
            // 
            // MainMenueEditNew
            // 
            this.MainMenueEditNew.Name = "MainMenueEditNew";
            this.MainMenueEditNew.Size = new System.Drawing.Size(180, 22);
            this.MainMenueEditNew.Text = "Neu";
            this.MainMenueEditNew.Click += new System.EventHandler(this.MainMenueEditNew_Click);
            // 
            // MainMenueEditEdit
            // 
            this.MainMenueEditEdit.Name = "MainMenueEditEdit";
            this.MainMenueEditEdit.Size = new System.Drawing.Size(180, 22);
            this.MainMenueEditEdit.Text = "Bearbeiten";
            this.MainMenueEditEdit.Click += new System.EventHandler(this.MainMenueEditEdit_Click);
            // 
            // MainMenueEditDelete
            // 
            this.MainMenueEditDelete.Name = "MainMenueEditDelete";
            this.MainMenueEditDelete.Size = new System.Drawing.Size(180, 22);
            this.MainMenueEditDelete.Text = "Löschen";
            this.MainMenueEditDelete.Click += new System.EventHandler(this.MainMenueEditDelete_Click);
            // 
            // MainMenueSearch
            // 
            this.MainMenueSearch.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainMenueSearchCTSS,
            this.MainMenueSearchCTSS38,
            this.MainMenueSearchPMR466,
            this.MainMenueSearchSaves});
            this.MainMenueSearch.Name = "MainMenueSearch";
            this.MainMenueSearch.Size = new System.Drawing.Size(58, 20);
            this.MainMenueSearch.Text = "Suchen";
            // 
            // MainMenueSearchCTSS
            // 
            this.MainMenueSearchCTSS.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SearchMenueCTSSChanel,
            this.SearchMenueCTSSTon});
            this.MainMenueSearchCTSS.Name = "MainMenueSearchCTSS";
            this.MainMenueSearchCTSS.Size = new System.Drawing.Size(216, 22);
            this.MainMenueSearchCTSS.Text = "CTSS";
            // 
            // SearchMenueCTSSChanel
            // 
            this.SearchMenueCTSSChanel.Name = "SearchMenueCTSSChanel";
            this.SearchMenueCTSSChanel.Size = new System.Drawing.Size(180, 22);
            this.SearchMenueCTSSChanel.Text = "Channel Suche";
            this.SearchMenueCTSSChanel.Click += new System.EventHandler(this.SearchMenueCTSSChanel_Click);
            // 
            // SearchMenueCTSSTon
            // 
            this.SearchMenueCTSSTon.Name = "SearchMenueCTSSTon";
            this.SearchMenueCTSSTon.Size = new System.Drawing.Size(180, 22);
            this.SearchMenueCTSSTon.Text = "Ton Frequenz Suche";
            this.SearchMenueCTSSTon.Click += new System.EventHandler(this.SearchMenueCTSSTon_Click);
            // 
            // MainMenueSearchCTSS38
            // 
            this.MainMenueSearchCTSS38.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SearchMenueCTSS38Channel,
            this.SearchMenueCTSS38Ton});
            this.MainMenueSearchCTSS38.Name = "MainMenueSearchCTSS38";
            this.MainMenueSearchCTSS38.Size = new System.Drawing.Size(216, 22);
            this.MainMenueSearchCTSS38.Text = "CTSS38";
            // 
            // SearchMenueCTSS38Channel
            // 
            this.SearchMenueCTSS38Channel.Name = "SearchMenueCTSS38Channel";
            this.SearchMenueCTSS38Channel.Size = new System.Drawing.Size(180, 22);
            this.SearchMenueCTSS38Channel.Text = "Channel Suche";
            this.SearchMenueCTSS38Channel.Click += new System.EventHandler(this.SearchMenueCTSS38Channel_Click);
            // 
            // SearchMenueCTSS38Ton
            // 
            this.SearchMenueCTSS38Ton.Name = "SearchMenueCTSS38Ton";
            this.SearchMenueCTSS38Ton.Size = new System.Drawing.Size(180, 22);
            this.SearchMenueCTSS38Ton.Text = "Ton Frequenz Suche";
            this.SearchMenueCTSS38Ton.Click += new System.EventHandler(this.SearchMenueCTSS38Ton_Click);
            // 
            // MainMenueSearchPMR466
            // 
            this.MainMenueSearchPMR466.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SearchPMR466Chanel,
            this.SearchPMR466Frequenz});
            this.MainMenueSearchPMR466.Name = "MainMenueSearchPMR466";
            this.MainMenueSearchPMR466.Size = new System.Drawing.Size(216, 22);
            this.MainMenueSearchPMR466.Text = "PMR466";
            // 
            // SearchPMR466Chanel
            // 
            this.SearchPMR466Chanel.Name = "SearchPMR466Chanel";
            this.SearchPMR466Chanel.Size = new System.Drawing.Size(180, 22);
            this.SearchPMR466Chanel.Text = "Nach Nummer";
            this.SearchPMR466Chanel.Click += new System.EventHandler(this.SearchPMR466Chanel_Click);
            // 
            // SearchPMR466Frequenz
            // 
            this.SearchPMR466Frequenz.Name = "SearchPMR466Frequenz";
            this.SearchPMR466Frequenz.Size = new System.Drawing.Size(180, 22);
            this.SearchPMR466Frequenz.Text = "Nach Frequenz";
            this.SearchPMR466Frequenz.Click += new System.EventHandler(this.SearchPMR466Frequenz_Click);
            // 
            // MainMenueSearchSaves
            // 
            this.MainMenueSearchSaves.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SearchSavesName});
            this.MainMenueSearchSaves.Name = "MainMenueSearchSaves";
            this.MainMenueSearchSaves.Size = new System.Drawing.Size(216, 22);
            this.MainMenueSearchSaves.Text = "Gespeicherte Einstellungen";
            // 
            // SearchSavesName
            // 
            this.SearchSavesName.Name = "SearchSavesName";
            this.SearchSavesName.Size = new System.Drawing.Size(180, 22);
            this.SearchSavesName.Text = "Nach Name";
            this.SearchSavesName.Click += new System.EventHandler(this.SearchSavesName_Click);
            // 
            // MainMenueInfo
            // 
            this.MainMenueInfo.Name = "MainMenueInfo";
            this.MainMenueInfo.Size = new System.Drawing.Size(40, 20);
            this.MainMenueInfo.Text = "Info";
            this.MainMenueInfo.Click += new System.EventHandler(this.MainMenueInfo_Click);
            // 
            // gBEI
            // 
            this.gBEI.Controls.Add(this.label6);
            this.gBEI.Controls.Add(this.tBPID);
            this.gBEI.Controls.Add(this.rTBPAn);
            this.gBEI.Controls.Add(this.tBCTon);
            this.gBEI.Controls.Add(this.label7);
            this.gBEI.Controls.Add(this.label5);
            this.gBEI.Controls.Add(this.tBCID);
            this.gBEI.Controls.Add(this.label4);
            this.gBEI.Controls.Add(this.tBC38);
            this.gBEI.Controls.Add(this.label3);
            this.gBEI.Controls.Add(this.tBPFreq);
            this.gBEI.Controls.Add(this.label2);
            this.gBEI.Location = new System.Drawing.Point(219, 167);
            this.gBEI.Name = "gBEI";
            this.gBEI.Size = new System.Drawing.Size(400, 275);
            this.gBEI.TabIndex = 4;
            this.gBEI.TabStop = false;
            this.gBEI.Text = "Informationen";
            this.gBEI.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Anmerkungen : ";
            // 
            // tBPID
            // 
            this.tBPID.Location = new System.Drawing.Point(110, 13);
            this.tBPID.Name = "tBPID";
            this.tBPID.ReadOnly = true;
            this.tBPID.Size = new System.Drawing.Size(284, 20);
            this.tBPID.TabIndex = 29;
            // 
            // rTBPAn
            // 
            this.rTBPAn.Location = new System.Drawing.Point(110, 143);
            this.rTBPAn.Name = "rTBPAn";
            this.rTBPAn.ReadOnly = true;
            this.rTBPAn.Size = new System.Drawing.Size(284, 82);
            this.rTBPAn.TabIndex = 26;
            this.rTBPAn.Text = "";
            // 
            // tBCTon
            // 
            this.tBCTon.Location = new System.Drawing.Point(110, 117);
            this.tBCTon.Name = "tBCTon";
            this.tBCTon.ReadOnly = true;
            this.tBCTon.Size = new System.Drawing.Size(284, 20);
            this.tBCTon.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Channel : ";
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
            this.tBCID.ReadOnly = true;
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
            this.tBC38.ReadOnly = true;
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
            this.tBPFreq.ReadOnly = true;
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
            // tBID
            // 
            this.tBID.Location = new System.Drawing.Point(110, 13);
            this.tBID.Name = "tBID";
            this.tBID.Size = new System.Drawing.Size(284, 20);
            this.tBID.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Name : ";
            // 
            // gBAG
            // 
            this.gBAG.Controls.Add(this.label8);
            this.gBAG.Controls.Add(this.rTBAn);
            this.gBAG.Controls.Add(this.tBID);
            this.gBAG.Controls.Add(this.label1);
            this.gBAG.Location = new System.Drawing.Point(219, 28);
            this.gBAG.Name = "gBAG";
            this.gBAG.Size = new System.Drawing.Size(400, 133);
            this.gBAG.TabIndex = 5;
            this.gBAG.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "Anmerkungen : ";
            // 
            // rTBAn
            // 
            this.rTBAn.Location = new System.Drawing.Point(110, 39);
            this.rTBAn.Name = "rTBAn";
            this.rTBAn.Size = new System.Drawing.Size(284, 82);
            this.rTBAn.TabIndex = 28;
            this.rTBAn.Text = "";
            // 
            // CmdSave
            // 
            this.CmdSave.Location = new System.Drawing.Point(413, 448);
            this.CmdSave.Name = "CmdSave";
            this.CmdSave.Size = new System.Drawing.Size(100, 23);
            this.CmdSave.TabIndex = 6;
            this.CmdSave.Text = "Speichern";
            this.CmdSave.UseVisualStyleBackColor = true;
            this.CmdSave.Visible = false;
            this.CmdSave.Click += new System.EventHandler(this.CmdSave_Click);
            // 
            // CmdNew
            // 
            this.CmdNew.Location = new System.Drawing.Point(219, 448);
            this.CmdNew.Name = "CmdNew";
            this.CmdNew.Size = new System.Drawing.Size(100, 23);
            this.CmdNew.TabIndex = 7;
            this.CmdNew.Text = "Neu";
            this.CmdNew.UseVisualStyleBackColor = true;
            this.CmdNew.Click += new System.EventHandler(this.CmdNew_Click);
            // 
            // CmdCancel
            // 
            this.CmdCancel.Location = new System.Drawing.Point(519, 448);
            this.CmdCancel.Name = "CmdCancel";
            this.CmdCancel.Size = new System.Drawing.Size(100, 23);
            this.CmdCancel.TabIndex = 8;
            this.CmdCancel.Text = "Abbrechen";
            this.CmdCancel.UseVisualStyleBackColor = true;
            this.CmdCancel.Visible = false;
            this.CmdCancel.Click += new System.EventHandler(this.CmdCancel_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 488);
            this.ControlBox = false;
            this.Controls.Add(this.CmdCancel);
            this.Controls.Add(this.CmdNew);
            this.Controls.Add(this.CmdSave);
            this.Controls.Add(this.gBAG);
            this.Controls.Add(this.gBEI);
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
            this.gBEI.ResumeLayout(false);
            this.gBEI.PerformLayout();
            this.gBAG.ResumeLayout(false);
            this.gBAG.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tSSL;
        private System.Windows.Forms.DataGridView dGV;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MainMenueFile;
        private System.Windows.Forms.ToolStripMenuItem MainMenueFileExit;
        private System.Windows.Forms.ToolStripMenuItem MainMenueSearch;
        private System.Windows.Forms.ToolStripMenuItem MainMenueSearchCTSS;
        private System.Windows.Forms.ToolStripMenuItem MainMenueSearchCTSS38;
        private System.Windows.Forms.ToolStripMenuItem MainMenueSearchPMR466;
        private System.Windows.Forms.ToolStripMenuItem MainMenueInfo;
        private System.Windows.Forms.GroupBox gBEI;
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
        private System.Windows.Forms.TextBox tBID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem SearchPMR466Chanel;
        private System.Windows.Forms.ToolStripMenuItem SearchPMR466Frequenz;
        private System.Windows.Forms.ToolStripMenuItem SearchMenueCTSSChanel;
        private System.Windows.Forms.ToolStripMenuItem SearchMenueCTSSTon;
        private System.Windows.Forms.ToolStripMenuItem SearchMenueCTSS38Channel;
        private System.Windows.Forms.ToolStripMenuItem SearchMenueCTSS38Ton;
        private System.Windows.Forms.GroupBox gBAG;
        private System.Windows.Forms.TextBox tBPID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button CmdSave;
        private System.Windows.Forms.Button CmdNew;
        private System.Windows.Forms.Button CmdCancel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox rTBAn;
        private System.Windows.Forms.ToolStripMenuItem MainMenueSearchSaves;
        private System.Windows.Forms.ToolStripMenuItem SearchSavesName;
        private System.Windows.Forms.ToolStripMenuItem MainMenueFileLoad;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem MainMenueEdit;
        private System.Windows.Forms.ToolStripMenuItem MainMenueEditNew;
        private System.Windows.Forms.ToolStripMenuItem MainMenueEditEdit;
        private System.Windows.Forms.ToolStripMenuItem MainMenueEditDelete;
    }
}

