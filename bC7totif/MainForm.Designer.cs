namespace bulkTexConverter
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.tbToolPath = new System.Windows.Forms.TextBox();
            this.btnSelToolPath = new System.Windows.Forms.Button();
            this.lblToolPath1 = new System.Windows.Forms.Label();
            this.lbConsoleOutput = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbOutputDir = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadPresetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBrowseGameDir = new System.Windows.Forms.Button();
            this.btnConvert = new System.Windows.Forms.Button();
            this.lblOutputDir = new System.Windows.Forms.Label();
            this.convertProgress = new System.Windows.Forms.ProgressBar();
            this.lblGameDirectory = new System.Windows.Forms.Label();
            this.tbGameDirectory = new System.Windows.Forms.TextBox();
            this.btnBrowseOut = new System.Windows.Forms.Button();
            this.appFolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.uiUpdate = new System.Windows.Forms.Timer(this.components);
            this.lbfolderList = new System.Windows.Forms.ListBox();
            this.folderlist_text = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbStatus1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbToolPath
            // 
            this.tbToolPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tbToolPath.Location = new System.Drawing.Point(6, 39);
            this.tbToolPath.Name = "tbToolPath";
            this.tbToolPath.Size = new System.Drawing.Size(215, 20);
            this.tbToolPath.TabIndex = 3;
            this.tbToolPath.TextChanged += new System.EventHandler(this.tbToolPath_TextChanged);
            // 
            // btnSelToolPath
            // 
            this.btnSelToolPath.Location = new System.Drawing.Point(227, 36);
            this.btnSelToolPath.Name = "btnSelToolPath";
            this.btnSelToolPath.Size = new System.Drawing.Size(75, 23);
            this.btnSelToolPath.TabIndex = 4;
            this.btnSelToolPath.Text = "Browse...";
            this.btnSelToolPath.UseVisualStyleBackColor = true;
            this.btnSelToolPath.Click += new System.EventHandler(this.btnSelToolPath_Click);
            // 
            // lblToolPath1
            // 
            this.lblToolPath1.AutoSize = true;
            this.lblToolPath1.ForeColor = System.Drawing.Color.Red;
            this.lblToolPath1.Location = new System.Drawing.Point(3, 24);
            this.lblToolPath1.Name = "lblToolPath1";
            this.lblToolPath1.Size = new System.Drawing.Size(53, 13);
            this.lblToolPath1.TabIndex = 6;
            this.lblToolPath1.Text = "Tool Path";
            // 
            // lbConsoleOutput
            // 
            this.lbConsoleOutput.BackColor = System.Drawing.SystemColors.MenuText;
            this.lbConsoleOutput.ForeColor = System.Drawing.Color.Lime;
            this.lbConsoleOutput.FormattingEnabled = true;
            this.lbConsoleOutput.Location = new System.Drawing.Point(6, 283);
            this.lbConsoleOutput.Name = "lbConsoleOutput";
            this.lbConsoleOutput.Size = new System.Drawing.Size(303, 147);
            this.lbConsoleOutput.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Console Output";
            // 
            // tbOutputDir
            // 
            this.tbOutputDir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tbOutputDir.Location = new System.Drawing.Point(6, 78);
            this.tbOutputDir.Name = "tbOutputDir";
            this.tbOutputDir.Size = new System.Drawing.Size(215, 20);
            this.tbOutputDir.TabIndex = 9;
            this.tbOutputDir.TextChanged += new System.EventHandler(this.tbOutputDir_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(317, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadPresetsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadPresetsToolStripMenuItem
            // 
            this.loadPresetsToolStripMenuItem.Name = "loadPresetsToolStripMenuItem";
            this.loadPresetsToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.loadPresetsToolStripMenuItem.Text = "Load Presets";
            this.loadPresetsToolStripMenuItem.Click += new System.EventHandler(this.LoadPresetsToolStripMenuItem_Click);
            // 
            // btnBrowseGameDir
            // 
            this.btnBrowseGameDir.Location = new System.Drawing.Point(227, 117);
            this.btnBrowseGameDir.Name = "btnBrowseGameDir";
            this.btnBrowseGameDir.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseGameDir.TabIndex = 11;
            this.btnBrowseGameDir.Text = "Browse...";
            this.btnBrowseGameDir.UseVisualStyleBackColor = true;
            this.btnBrowseGameDir.Click += new System.EventHandler(this.btnBrowseGameDir_Click);
            // 
            // btnConvert
            // 
            this.btnConvert.Enabled = false;
            this.btnConvert.Location = new System.Drawing.Point(6, 488);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(303, 60);
            this.btnConvert.TabIndex = 12;
            this.btnConvert.Text = "CONVERT";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // lblOutputDir
            // 
            this.lblOutputDir.AutoSize = true;
            this.lblOutputDir.ForeColor = System.Drawing.Color.Red;
            this.lblOutputDir.Location = new System.Drawing.Point(3, 62);
            this.lblOutputDir.Name = "lblOutputDir";
            this.lblOutputDir.Size = new System.Drawing.Size(84, 13);
            this.lblOutputDir.TabIndex = 13;
            this.lblOutputDir.Text = "Output Directory";
            // 
            // convertProgress
            // 
            this.convertProgress.Location = new System.Drawing.Point(6, 436);
            this.convertProgress.Name = "convertProgress";
            this.convertProgress.Size = new System.Drawing.Size(303, 46);
            this.convertProgress.TabIndex = 14;
            // 
            // lblGameDirectory
            // 
            this.lblGameDirectory.AutoSize = true;
            this.lblGameDirectory.ForeColor = System.Drawing.Color.Red;
            this.lblGameDirectory.Location = new System.Drawing.Point(3, 101);
            this.lblGameDirectory.Name = "lblGameDirectory";
            this.lblGameDirectory.Size = new System.Drawing.Size(80, 13);
            this.lblGameDirectory.TabIndex = 15;
            this.lblGameDirectory.Text = "Game Directory";
            // 
            // tbGameDirectory
            // 
            this.tbGameDirectory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tbGameDirectory.Location = new System.Drawing.Point(6, 117);
            this.tbGameDirectory.Name = "tbGameDirectory";
            this.tbGameDirectory.Size = new System.Drawing.Size(215, 20);
            this.tbGameDirectory.TabIndex = 16;
            this.tbGameDirectory.TextChanged += new System.EventHandler(this.tbGameDirectory_TextChanged);
            // 
            // btnBrowseOut
            // 
            this.btnBrowseOut.Location = new System.Drawing.Point(227, 76);
            this.btnBrowseOut.Name = "btnBrowseOut";
            this.btnBrowseOut.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseOut.TabIndex = 17;
            this.btnBrowseOut.Text = "Browse...";
            this.btnBrowseOut.UseVisualStyleBackColor = true;
            this.btnBrowseOut.Click += new System.EventHandler(this.btnBrowseOut_Click);
            // 
            // uiUpdate
            // 
            this.uiUpdate.Enabled = true;
            this.uiUpdate.Interval = 4;
            this.uiUpdate.Tick += new System.EventHandler(this.uiUpdate_Tick);
            // 
            // lbfolderList
            // 
            this.lbfolderList.FormattingEnabled = true;
            this.lbfolderList.Location = new System.Drawing.Point(6, 156);
            this.lbfolderList.Name = "lbfolderList";
            this.lbfolderList.Size = new System.Drawing.Size(215, 108);
            this.lbfolderList.TabIndex = 18;
            // 
            // folderlist_text
            // 
            this.folderlist_text.AutoSize = true;
            this.folderlist_text.Location = new System.Drawing.Point(7, 140);
            this.folderlist_text.Name = "folderlist_text";
            this.folderlist_text.Size = new System.Drawing.Size(92, 13);
            this.folderlist_text.TabIndex = 19;
            this.folderlist_text.Text = "Folders to convert";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(227, 185);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 20;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(227, 156);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 21;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbStatus1
            // 
            this.lbStatus1.AutoSize = true;
            this.lbStatus1.Location = new System.Drawing.Point(6, 555);
            this.lbStatus1.Name = "lbStatus1";
            this.lbStatus1.Size = new System.Drawing.Size(51, 13);
            this.lbStatus1.TabIndex = 22;
            this.lbStatus1.Text = "lbStatus1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 571);
            this.Controls.Add(this.lbStatus1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.folderlist_text);
            this.Controls.Add(this.lbfolderList);
            this.Controls.Add(this.btnBrowseOut);
            this.Controls.Add(this.tbGameDirectory);
            this.Controls.Add(this.lblGameDirectory);
            this.Controls.Add(this.convertProgress);
            this.Controls.Add(this.lblOutputDir);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.btnBrowseGameDir);
            this.Controls.Add(this.tbOutputDir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbConsoleOutput);
            this.Controls.Add(this.lblToolPath1);
            this.Controls.Add(this.btnSelToolPath);
            this.Controls.Add(this.tbToolPath);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Bulk Texture Converter";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbToolPath;
        private System.Windows.Forms.Button btnSelToolPath;
        private System.Windows.Forms.Label lblToolPath1;
        private System.Windows.Forms.ListBox lbConsoleOutput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbOutputDir;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.Button btnBrowseGameDir;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label lblOutputDir;
        private System.Windows.Forms.ProgressBar convertProgress;
        private System.Windows.Forms.Label lblGameDirectory;
        private System.Windows.Forms.TextBox tbGameDirectory;
        private System.Windows.Forms.Button btnBrowseOut;
        private System.Windows.Forms.FolderBrowserDialog appFolderBrowser;
        private System.Windows.Forms.Timer uiUpdate;
        private System.Windows.Forms.ListBox lbfolderList;
        private System.Windows.Forms.Label folderlist_text;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ToolStripMenuItem loadPresetsToolStripMenuItem;
        private System.Windows.Forms.Label lbStatus1;
    }
}

