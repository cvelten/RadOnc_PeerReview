namespace PeerReview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("General Services");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Special Services");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Cornwall");
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.sendEMailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendEMailToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.textOutputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pageSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.navigateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startupDirectorypwdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.montefioreorgRADPRODFAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eMailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripLabelCurrentNode = new System.Windows.Forms.ToolStripStatusLabel();
            this.buttonDirBrowse = new System.Windows.Forms.Button();
            this.labelTextBoxDir = new System.Windows.Forms.Label();
            this.textBoxPWD = new System.Windows.Forms.TextBox();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.treeViewDirs = new System.Windows.Forms.TreeView();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.pageSetupDialog = new System.Windows.Forms.PageSetupDialog();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageList = new System.Windows.Forms.TabPage();
            this.tabPageRun = new System.Windows.Forms.TabPage();
            this.buttonRunSelectAll = new System.Windows.Forms.Button();
            this.labelRunAs = new System.Windows.Forms.Label();
            this.buttonRunPDF = new System.Windows.Forms.Button();
            this.buttonRunRadialogica = new System.Windows.Forms.Button();
            this.dataGridViewRun = new System.Windows.Forms.DataGridView();
            this.tabPageLog = new System.Windows.Forms.TabPage();
            this.buttonLogCopy = new System.Windows.Forms.Button();
            this.buttonLogClear = new System.Windows.Forms.Button();
            this.RTFBoxLog = new System.Windows.Forms.RichTextBox();
            this.saveFileDialogExcel = new System.Windows.Forms.SaveFileDialog();
            this.cmsDGVRun = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radialogicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerProcesses = new System.Windows.Forms.Timer(this.components);
            this.menuStrip.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPageList.SuspendLayout();
            this.tabPageRun.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRun)).BeginInit();
            this.tabPageLog.SuspendLayout();
            this.cmsDGVRun.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1,
            this.navigateToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.testToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip.Size = new System.Drawing.Size(784, 24);
            this.menuStrip.TabIndex = 1;
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripSeparator3,
            this.sendEMailToolStripMenuItem,
            this.sendEMailToToolStripMenuItem,
            this.toolStripSeparator5,
            this.textOutputToolStripMenuItem,
            this.toExcelToolStripMenuItem,
            this.toolStripSeparator2,
            this.printToolStripMenuItem1,
            this.pageSetupToolStripMenuItem,
            this.printPreviewToolStripMenuItem1,
            this.toolStripSeparator4,
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem1.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.ButtonDirBrowse_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(158, 6);
            // 
            // sendEMailToolStripMenuItem
            // 
            this.sendEMailToolStripMenuItem.Name = "sendEMailToolStripMenuItem";
            this.sendEMailToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.sendEMailToolStripMenuItem.Text = "Send &E-Mail";
            this.sendEMailToolStripMenuItem.Click += new System.EventHandler(this.SendEMailToolStripMenuItem_Click);
            // 
            // sendEMailToToolStripMenuItem
            // 
            this.sendEMailToToolStripMenuItem.Name = "sendEMailToToolStripMenuItem";
            this.sendEMailToToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.sendEMailToToolStripMenuItem.Text = "Send E-Mail To...";
            this.sendEMailToToolStripMenuItem.Click += new System.EventHandler(this.SendEMailToToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(158, 6);
            // 
            // textOutputToolStripMenuItem
            // 
            this.textOutputToolStripMenuItem.Name = "textOutputToolStripMenuItem";
            this.textOutputToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.textOutputToolStripMenuItem.Text = "To &Text";
            this.textOutputToolStripMenuItem.Click += new System.EventHandler(this.TextOutputToolStripMenuItem_Click);
            // 
            // toExcelToolStripMenuItem
            // 
            this.toExcelToolStripMenuItem.Name = "toExcelToolStripMenuItem";
            this.toExcelToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.toExcelToolStripMenuItem.Text = "To Excel";
            this.toExcelToolStripMenuItem.Click += new System.EventHandler(this.ToExcelToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(158, 6);
            // 
            // printToolStripMenuItem1
            // 
            this.printToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem1.Image")));
            this.printToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripMenuItem1.Name = "printToolStripMenuItem1";
            this.printToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem1.Size = new System.Drawing.Size(161, 22);
            this.printToolStripMenuItem1.Text = "&Print";
            this.printToolStripMenuItem1.Click += new System.EventHandler(this.PrintToolStripMenuItem_Click);
            // 
            // pageSetupToolStripMenuItem
            // 
            this.pageSetupToolStripMenuItem.Name = "pageSetupToolStripMenuItem";
            this.pageSetupToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.pageSetupToolStripMenuItem.Text = "Page Setup";
            this.pageSetupToolStripMenuItem.Click += new System.EventHandler(this.PrintSetupToolStripMenuItem_Click);
            // 
            // printPreviewToolStripMenuItem1
            // 
            this.printPreviewToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("printPreviewToolStripMenuItem1.Image")));
            this.printPreviewToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printPreviewToolStripMenuItem1.Name = "printPreviewToolStripMenuItem1";
            this.printPreviewToolStripMenuItem1.Size = new System.Drawing.Size(161, 22);
            this.printPreviewToolStripMenuItem1.Text = "Print Pre&view";
            this.printPreviewToolStripMenuItem1.Click += new System.EventHandler(this.PrintPreviewToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(158, 6);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(161, 22);
            this.exitToolStripMenuItem1.Text = "E&xit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // navigateToolStripMenuItem
            // 
            this.navigateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startupDirectorypwdToolStripMenuItem,
            this.toolStripSeparator1,
            this.montefioreorgRADPRODFAToolStripMenuItem});
            this.navigateToolStripMenuItem.Name = "navigateToolStripMenuItem";
            this.navigateToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.navigateToolStripMenuItem.Text = "&Navigate";
            // 
            // startupDirectorypwdToolStripMenuItem
            // 
            this.startupDirectorypwdToolStripMenuItem.Name = "startupDirectorypwdToolStripMenuItem";
            this.startupDirectorypwdToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.startupDirectorypwdToolStripMenuItem.Text = "Startup Directory (pwd)";
            this.startupDirectorypwdToolStripMenuItem.Click += new System.EventHandler(this.NavigateToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(233, 6);
            // 
            // montefioreorgRADPRODFAToolStripMenuItem
            // 
            this.montefioreorgRADPRODFAToolStripMenuItem.Name = "montefioreorgRADPRODFAToolStripMenuItem";
            this.montefioreorgRADPRODFAToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.montefioreorgRADPRODFAToolStripMenuItem.Text = "\\\\montefiore.org\\RADPRODFA";
            this.montefioreorgRADPRODFAToolStripMenuItem.Click += new System.EventHandler(this.NavigateToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textToolStripMenuItem,
            this.excelToolStripMenuItem,
            this.eMailToolStripMenuItem});
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // textToolStripMenuItem
            // 
            this.textToolStripMenuItem.Name = "textToolStripMenuItem";
            this.textToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.textToolStripMenuItem.Text = "Text";
            this.textToolStripMenuItem.Click += new System.EventHandler(this.TextOutputToolStripMenuItem_Click);
            // 
            // excelToolStripMenuItem
            // 
            this.excelToolStripMenuItem.Name = "excelToolStripMenuItem";
            this.excelToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.excelToolStripMenuItem.Text = "Excel";
            this.excelToolStripMenuItem.Click += new System.EventHandler(this.ToExcelToolStripMenuItem_Click);
            // 
            // eMailToolStripMenuItem
            // 
            this.eMailToolStripMenuItem.Name = "eMailToolStripMenuItem";
            this.eMailToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.eMailToolStripMenuItem.Text = "E-Mail";
            this.eMailToolStripMenuItem.Click += new System.EventHandler(this.SendEMailToToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.HelpToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelTime,
            this.toolStripStatusLabel1,
            this.toolStripLabelCurrentNode});
            this.statusStrip1.Location = new System.Drawing.Point(0, 540);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(784, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelTime
            // 
            this.toolStripStatusLabelTime.Name = "toolStripStatusLabelTime";
            this.toolStripStatusLabelTime.Size = new System.Drawing.Size(49, 17);
            this.toolStripStatusLabelTime.Text = "00:00:00";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 2);
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(10, 17);
            this.toolStripStatusLabel1.Text = "|";
            // 
            // toolStripLabelCurrentNode
            // 
            this.toolStripLabelCurrentNode.Name = "toolStripLabelCurrentNode";
            this.toolStripLabelCurrentNode.Size = new System.Drawing.Size(0, 17);
            // 
            // buttonDirBrowse
            // 
            this.buttonDirBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDirBrowse.Location = new System.Drawing.Point(697, 27);
            this.buttonDirBrowse.Name = "buttonDirBrowse";
            this.buttonDirBrowse.Size = new System.Drawing.Size(75, 32);
            this.buttonDirBrowse.TabIndex = 2;
            this.buttonDirBrowse.Text = "&Browse...";
            this.buttonDirBrowse.UseVisualStyleBackColor = true;
            this.buttonDirBrowse.Click += new System.EventHandler(this.ButtonDirBrowse_Click);
            // 
            // labelTextBoxDir
            // 
            this.labelTextBoxDir.AutoSize = true;
            this.labelTextBoxDir.Location = new System.Drawing.Point(12, 37);
            this.labelTextBoxDir.Name = "labelTextBoxDir";
            this.labelTextBoxDir.Size = new System.Drawing.Size(52, 13);
            this.labelTextBoxDir.TabIndex = 2;
            this.labelTextBoxDir.Text = "Directory:";
            this.labelTextBoxDir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxPWD
            // 
            this.textBoxPWD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPWD.Location = new System.Drawing.Point(70, 34);
            this.textBoxPWD.Name = "textBoxPWD";
            this.textBoxPWD.Size = new System.Drawing.Size(621, 20);
            this.textBoxPWD.TabIndex = 1;
            this.textBoxPWD.DoubleClick += new System.EventHandler(this.ButtonDirBrowse_Click);
            this.textBoxPWD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxPWD_KeyPress);
            this.textBoxPWD.Leave += new System.EventHandler(this.UpdatePath);
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(3, 3);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.treeViewDirs);
            this.splitContainer.Panel1MinSize = 250;
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.dataGridView);
            this.splitContainer.Panel2MinSize = 250;
            this.splitContainer.Size = new System.Drawing.Size(770, 447);
            this.splitContainer.SplitterDistance = 250;
            this.splitContainer.TabIndex = 0;
            // 
            // treeViewDirs
            // 
            this.treeViewDirs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewDirs.Location = new System.Drawing.Point(0, 0);
            this.treeViewDirs.Name = "treeViewDirs";
            treeNode1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            treeNode1.Name = "nodeGeneral";
            treeNode1.Text = "General Services";
            treeNode2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            treeNode2.Name = "nodeSpecial";
            treeNode2.Text = "Special Services";
            treeNode3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            treeNode3.Name = "nodeCornwall";
            treeNode3.Text = "Cornwall";
            this.treeViewDirs.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            this.treeViewDirs.Size = new System.Drawing.Size(250, 447);
            this.treeViewDirs.TabIndex = 0;
            this.treeViewDirs.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeViewDirs_AfterSelect);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(516, 447);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellContextMenuStripNeeded += new System.Windows.Forms.DataGridViewCellContextMenuStripNeededEventHandler(this.DataGridView_CellContextMenuStripNeeded);
            this.dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellDoubleClick);
            // 
            // timerTime
            // 
            this.timerTime.Enabled = true;
            this.timerTime.Interval = 1000;
            this.timerTime.Tick += new System.EventHandler(this.TimerTime_Tick);
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Document = this.printDocument1;
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog";
            this.printPreviewDialog.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument1_PrintPage);
            // 
            // printDialog
            // 
            this.printDialog.Document = this.printDocument1;
            this.printDialog.UseEXDialog = true;
            // 
            // pageSetupDialog
            // 
            this.pageSetupDialog.Document = this.printDocument1;
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPageList);
            this.tabControl.Controls.Add(this.tabPageRun);
            this.tabControl.Controls.Add(this.tabPageLog);
            this.tabControl.Location = new System.Drawing.Point(0, 60);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(784, 479);
            this.tabControl.TabIndex = 3;
            // 
            // tabPageList
            // 
            this.tabPageList.Controls.Add(this.splitContainer);
            this.tabPageList.Location = new System.Drawing.Point(4, 22);
            this.tabPageList.Name = "tabPageList";
            this.tabPageList.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageList.Size = new System.Drawing.Size(776, 453);
            this.tabPageList.TabIndex = 0;
            this.tabPageList.Text = "Review List";
            this.tabPageList.UseVisualStyleBackColor = true;
            // 
            // tabPageRun
            // 
            this.tabPageRun.Controls.Add(this.buttonRunSelectAll);
            this.tabPageRun.Controls.Add(this.labelRunAs);
            this.tabPageRun.Controls.Add(this.buttonRunPDF);
            this.tabPageRun.Controls.Add(this.buttonRunRadialogica);
            this.tabPageRun.Controls.Add(this.dataGridViewRun);
            this.tabPageRun.Location = new System.Drawing.Point(4, 22);
            this.tabPageRun.Name = "tabPageRun";
            this.tabPageRun.Size = new System.Drawing.Size(776, 453);
            this.tabPageRun.TabIndex = 3;
            this.tabPageRun.Text = "Run Review";
            this.tabPageRun.UseVisualStyleBackColor = true;
            // 
            // buttonRunSelectAll
            // 
            this.buttonRunSelectAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonRunSelectAll.Enabled = false;
            this.buttonRunSelectAll.Location = new System.Drawing.Point(3, 427);
            this.buttonRunSelectAll.Name = "buttonRunSelectAll";
            this.buttonRunSelectAll.Size = new System.Drawing.Size(75, 23);
            this.buttonRunSelectAll.TabIndex = 7;
            this.buttonRunSelectAll.Text = "Select All";
            this.buttonRunSelectAll.UseVisualStyleBackColor = true;
            this.buttonRunSelectAll.Click += new System.EventHandler(this.ButtonRun_Click);
            // 
            // labelRunAs
            // 
            this.labelRunAs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRunAs.AutoSize = true;
            this.labelRunAs.Location = new System.Drawing.Point(495, 432);
            this.labelRunAs.Name = "labelRunAs";
            this.labelRunAs.Size = new System.Drawing.Size(81, 13);
            this.labelRunAs.TabIndex = 4;
            this.labelRunAs.Text = "Open Selected:";
            // 
            // buttonRunPDF
            // 
            this.buttonRunPDF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRunPDF.Enabled = false;
            this.buttonRunPDF.Location = new System.Drawing.Point(582, 427);
            this.buttonRunPDF.Name = "buttonRunPDF";
            this.buttonRunPDF.Size = new System.Drawing.Size(90, 23);
            this.buttonRunPDF.TabIndex = 3;
            this.buttonRunPDF.Text = "PDF";
            this.buttonRunPDF.UseVisualStyleBackColor = true;
            this.buttonRunPDF.Click += new System.EventHandler(this.ButtonRun_Click);
            // 
            // buttonRunRadialogica
            // 
            this.buttonRunRadialogica.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRunRadialogica.Enabled = false;
            this.buttonRunRadialogica.Location = new System.Drawing.Point(678, 427);
            this.buttonRunRadialogica.Name = "buttonRunRadialogica";
            this.buttonRunRadialogica.Size = new System.Drawing.Size(90, 23);
            this.buttonRunRadialogica.TabIndex = 2;
            this.buttonRunRadialogica.Text = "Radialogica";
            this.buttonRunRadialogica.UseVisualStyleBackColor = true;
            this.buttonRunRadialogica.Click += new System.EventHandler(this.ButtonRun_Click);
            // 
            // dataGridViewRun
            // 
            this.dataGridViewRun.AllowUserToAddRows = false;
            this.dataGridViewRun.AllowUserToDeleteRows = false;
            this.dataGridViewRun.AllowUserToOrderColumns = true;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.dataGridViewRun.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewRun.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewRun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewRun.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewRun.Enabled = false;
            this.dataGridViewRun.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewRun.Name = "dataGridViewRun";
            this.dataGridViewRun.Size = new System.Drawing.Size(776, 421);
            this.dataGridViewRun.TabIndex = 1;
            this.dataGridViewRun.CellContextMenuStripNeeded += new System.Windows.Forms.DataGridViewCellContextMenuStripNeededEventHandler(this.DataGridView_CellContextMenuStripNeeded);
            this.dataGridViewRun.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellDoubleClick);
            // 
            // tabPageLog
            // 
            this.tabPageLog.Controls.Add(this.buttonLogCopy);
            this.tabPageLog.Controls.Add(this.buttonLogClear);
            this.tabPageLog.Controls.Add(this.RTFBoxLog);
            this.tabPageLog.Location = new System.Drawing.Point(4, 22);
            this.tabPageLog.Name = "tabPageLog";
            this.tabPageLog.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLog.Size = new System.Drawing.Size(776, 453);
            this.tabPageLog.TabIndex = 1;
            this.tabPageLog.Text = "Log";
            this.tabPageLog.UseVisualStyleBackColor = true;
            // 
            // buttonLogCopy
            // 
            this.buttonLogCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonLogCopy.Location = new System.Drawing.Point(6, 427);
            this.buttonLogCopy.Name = "buttonLogCopy";
            this.buttonLogCopy.Size = new System.Drawing.Size(80, 23);
            this.buttonLogCopy.TabIndex = 3;
            this.buttonLogCopy.Text = "Copy";
            this.buttonLogCopy.UseVisualStyleBackColor = true;
            this.buttonLogCopy.Click += new System.EventHandler(this.ButtonLogCopy_Click);
            // 
            // buttonLogClear
            // 
            this.buttonLogClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLogClear.Location = new System.Drawing.Point(695, 427);
            this.buttonLogClear.Name = "buttonLogClear";
            this.buttonLogClear.Size = new System.Drawing.Size(75, 23);
            this.buttonLogClear.TabIndex = 1;
            this.buttonLogClear.Text = "Clear";
            this.buttonLogClear.UseVisualStyleBackColor = true;
            this.buttonLogClear.Click += new System.EventHandler(this.ButtonLogClear_Click);
            // 
            // RTFBoxLog
            // 
            this.RTFBoxLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RTFBoxLog.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTFBoxLog.Location = new System.Drawing.Point(3, 3);
            this.RTFBoxLog.Name = "RTFBoxLog";
            this.RTFBoxLog.ReadOnly = true;
            this.RTFBoxLog.Size = new System.Drawing.Size(770, 418);
            this.RTFBoxLog.TabIndex = 0;
            this.RTFBoxLog.Text = "";
            // 
            // saveFileDialogExcel
            // 
            this.saveFileDialogExcel.DefaultExt = "xlsx";
            this.saveFileDialogExcel.Filter = "Excel Spreadsheet (*.xlsx)|*.xlsx";
            // 
            // cmsDGVRun
            // 
            this.cmsDGVRun.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pDFToolStripMenuItem,
            this.radialogicaToolStripMenuItem});
            this.cmsDGVRun.Name = "cmsDGVRun";
            this.cmsDGVRun.Size = new System.Drawing.Size(136, 48);
            // 
            // pDFToolStripMenuItem
            // 
            this.pDFToolStripMenuItem.Name = "pDFToolStripMenuItem";
            this.pDFToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.pDFToolStripMenuItem.Text = "PDF";
            this.pDFToolStripMenuItem.Click += new System.EventHandler(this.CMSRunToolStripMenuItem_Click);
            // 
            // radialogicaToolStripMenuItem
            // 
            this.radialogicaToolStripMenuItem.Name = "radialogicaToolStripMenuItem";
            this.radialogicaToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.radialogicaToolStripMenuItem.Text = "Radialogica";
            this.radialogicaToolStripMenuItem.Click += new System.EventHandler(this.CMSRunToolStripMenuItem_Click);
            // 
            // timerProcesses
            // 
            this.timerProcesses.Enabled = true;
            this.timerProcesses.Interval = 1000;
            this.timerProcesses.Tick += new System.EventHandler(this.TimerProcesses_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.buttonDirBrowse);
            this.Controls.Add(this.labelTextBoxDir);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.textBoxPWD);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Peer Review List";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabPageList.ResumeLayout(false);
            this.tabPageRun.ResumeLayout(false);
            this.tabPageRun.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRun)).EndInit();
            this.tabPageLog.ResumeLayout(false);
            this.cmsDGVRun.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.Button buttonDirBrowse;
		private System.Windows.Forms.Label labelTextBoxDir;
		private System.Windows.Forms.TextBox textBoxPWD;
		private System.Windows.Forms.SplitContainer splitContainer;
		private System.Windows.Forms.TreeView treeViewDirs;
		private System.Windows.Forms.ToolStripStatusLabel toolStripLabelCurrentNode;
		private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelTime;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Timer timerTime;
		private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
		private System.Drawing.Printing.PrintDocument printDocument1;
		private System.Windows.Forms.PrintDialog printDialog;
		private System.Windows.Forms.PageSetupDialog pageSetupDialog;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem navigateToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem montefioreorgRADPRODFAToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem pageSetupToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem startupDirectorypwdToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem sendEMailToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.TabPage tabPageList;
		private System.Windows.Forms.TabPage tabPageLog;
		private System.Windows.Forms.Button buttonLogClear;
		private System.Windows.Forms.RichTextBox RTFBoxLog;
		private System.Windows.Forms.Button buttonLogCopy;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
		private System.Windows.Forms.ToolStripMenuItem textOutputToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem sendEMailToToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem textToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem excelToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem eMailToolStripMenuItem;
		private System.Windows.Forms.TabPage tabPageRun;
		private System.Windows.Forms.ToolStripMenuItem toExcelToolStripMenuItem;
		private System.Windows.Forms.SaveFileDialog saveFileDialogExcel;
		private System.Windows.Forms.DataGridView dataGridViewRun;
		private System.Windows.Forms.ContextMenuStrip cmsDGVRun;
		private System.Windows.Forms.ToolStripMenuItem pDFToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem radialogicaToolStripMenuItem;
		private System.Windows.Forms.Button buttonRunPDF;
		private System.Windows.Forms.Button buttonRunRadialogica;
		private System.Windows.Forms.Label labelRunAs;
		private System.Windows.Forms.Timer timerProcesses;
		private System.Windows.Forms.Button buttonRunSelectAll;
	}
}

