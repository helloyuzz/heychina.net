namespace HeyEditor {
    partial class Form_Main {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            menu_ChooseFile = new ToolStripMenuItem();
            btn_Save = new ToolStripMenuItem();
            toolStripMenuItem5 = new ToolStripMenuItem();
            toolStripMenuItem6 = new ToolStripMenuItem();
            toolStripMenuItem7 = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            txtCount = new ToolStripStatusLabel();
            label1 = new Label();
            splitContainer1 = new SplitContainer();
            docTree = new TreeView();
            imageList1 = new ImageList(components);
            splitContainer2 = new SplitContainer();
            tbx_FileContent = new RichTextBox();
            txt_FilePath = new LinkLabel();
            panel2 = new Panel();
            label2 = new Label();
            label3 = new Label();
            cbx_Has_children = new CheckBox();
            label4 = new Label();
            tbx_Has_children = new TextBox();
            label5 = new Label();
            tbx_Nav_order = new TextBox();
            txt_Nav_order = new Label();
            tbx_Level = new TextBox();
            tbx_Layout = new TextBox();
            tbx_Parent = new TextBox();
            tbx_title = new TextBox();
            folderBrowserDialog1 = new FolderBrowserDialog();
            contextMenuStrip1 = new ContextMenuStrip(components);
            menu_ShowTitle = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            menu_CreateFolder = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            menu_Refresh = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            menu_OpenFolder = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            panel2.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, menu_ChooseFile, btn_Save, toolStripMenuItem6, toolStripMenuItem7, toolStripMenuItem5 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(8, 2, 0, 2);
            menuStrip1.Size = new Size(1630, 52);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Alignment = ToolStripItemAlignment.Right;
            toolStripMenuItem1.Image = Properties.Resources.退出;
            toolStripMenuItem1.Margin = new Padding(0, 6, 0, 6);
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(93, 36);
            toolStripMenuItem1.Text = "退出(&X)";
            // 
            // menu_ChooseFile
            // 
            menu_ChooseFile.Alignment = ToolStripItemAlignment.Right;
            menu_ChooseFile.Image = Properties.Resources.打开;
            menu_ChooseFile.Margin = new Padding(0, 6, 0, 6);
            menu_ChooseFile.Name = "menu_ChooseFile";
            menu_ChooseFile.Size = new Size(175, 36);
            menu_ChooseFile.Text = "！未选择文件路径...";
            menu_ChooseFile.Click += menu_ChooseFile_Click;
            // 
            // btn_Save
            // 
            btn_Save.Alignment = ToolStripItemAlignment.Right;
            btn_Save.Image = Properties.Resources.保存;
            btn_Save.Margin = new Padding(0, 6, 16, 6);
            btn_Save.Name = "btn_Save";
            btn_Save.Padding = new Padding(6);
            btn_Save.Size = new Size(93, 36);
            btn_Save.Text = "保存(&L)";
            // 
            // toolStripMenuItem5
            // 
            toolStripMenuItem5.Image = Properties.Resources.refresh;
            toolStripMenuItem5.Margin = new Padding(0, 6, 0, 6);
            toolStripMenuItem5.Name = "toolStripMenuItem5";
            toolStripMenuItem5.Padding = new Padding(6);
            toolStripMenuItem5.Size = new Size(95, 36);
            toolStripMenuItem5.Text = "刷新(&R)";
            // 
            // toolStripMenuItem6
            // 
            toolStripMenuItem6.Image = Properties.Resources.folder;
            toolStripMenuItem6.Margin = new Padding(0, 6, 0, 6);
            toolStripMenuItem6.Name = "toolStripMenuItem6";
            toolStripMenuItem6.Padding = new Padding(6);
            toolStripMenuItem6.Size = new Size(120, 36);
            toolStripMenuItem6.Text = "新建文件夹";
            // 
            // toolStripMenuItem7
            // 
            toolStripMenuItem7.Image = Properties.Resources.file;
            toolStripMenuItem7.Margin = new Padding(0, 6, 0, 6);
            toolStripMenuItem7.Name = "toolStripMenuItem7";
            toolStripMenuItem7.Padding = new Padding(6);
            toolStripMenuItem7.Size = new Size(129, 36);
            toolStripMenuItem7.Text = "新建md文件";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { txtCount });
            statusStrip1.Location = new Point(0, 905);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 18, 0);
            statusStrip1.Size = new Size(1630, 26);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // txtCount
            // 
            txtCount.Name = "txtCount";
            txtCount.Size = new Size(39, 20);
            txtCount.Text = "统计";
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ActiveBorder;
            label1.Dock = DockStyle.Top;
            label1.Location = new Point(0, 52);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(1630, 1);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // splitContainer1
            // 
            splitContainer1.BackColor = SystemColors.ActiveBorder;
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 53);
            splitContainer1.Margin = new Padding(4, 4, 4, 4);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = SystemColors.ControlLight;
            splitContainer1.Panel1.Controls.Add(docTree);
            splitContainer1.Panel1.Padding = new Padding(4, 4, 4, 4);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Size = new Size(1630, 852);
            splitContainer1.SplitterDistance = 542;
            splitContainer1.SplitterWidth = 5;
            splitContainer1.TabIndex = 3;
            // 
            // docTree
            // 
            docTree.Dock = DockStyle.Fill;
            docTree.HideSelection = false;
            docTree.ImageIndex = 0;
            docTree.ImageList = imageList1;
            docTree.Location = new Point(4, 4);
            docTree.Margin = new Padding(4, 4, 4, 4);
            docTree.Name = "docTree";
            docTree.SelectedImageIndex = 0;
            docTree.Size = new Size(534, 844);
            docTree.TabIndex = 0;
            docTree.AfterSelect += docTree_AfterSelect;
            docTree.NodeMouseClick += docTree_NodeMouseClick;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "folder.png");
            imageList1.Images.SetKeyName(1, "file.png");
            // 
            // splitContainer2
            // 
            splitContainer2.BackColor = SystemColors.ControlLight;
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Margin = new Padding(4, 4, 4, 4);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.BackColor = SystemColors.Control;
            splitContainer2.Panel1.Controls.Add(tbx_FileContent);
            splitContainer2.Panel1.Controls.Add(txt_FilePath);
            splitContainer2.Panel1.Padding = new Padding(4, 4, 4, 4);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.BackColor = Color.White;
            splitContainer2.Panel2.Controls.Add(panel2);
            splitContainer2.Size = new Size(1083, 852);
            splitContainer2.SplitterDistance = 319;
            splitContainer2.SplitterWidth = 5;
            splitContainer2.TabIndex = 0;
            // 
            // tbx_FileContent
            // 
            tbx_FileContent.BackColor = Color.White;
            tbx_FileContent.Dock = DockStyle.Fill;
            tbx_FileContent.Location = new Point(4, 4);
            tbx_FileContent.Margin = new Padding(4, 4, 4, 4);
            tbx_FileContent.Name = "tbx_FileContent";
            tbx_FileContent.ReadOnly = true;
            tbx_FileContent.Size = new Size(1075, 291);
            tbx_FileContent.TabIndex = 0;
            tbx_FileContent.Text = "";
            // 
            // txt_FilePath
            // 
            txt_FilePath.Dock = DockStyle.Bottom;
            txt_FilePath.Location = new Point(4, 295);
            txt_FilePath.Margin = new Padding(4, 0, 4, 0);
            txt_FilePath.Name = "txt_FilePath";
            txt_FilePath.Size = new Size(1075, 20);
            txt_FilePath.TabIndex = 15;
            txt_FilePath.TabStop = true;
            txt_FilePath.Text = "d:\\";
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(cbx_Has_children);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(tbx_Has_children);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(tbx_Nav_order);
            panel2.Controls.Add(txt_Nav_order);
            panel2.Controls.Add(tbx_Level);
            panel2.Controls.Add(tbx_Layout);
            panel2.Controls.Add(tbx_Parent);
            panel2.Controls.Add(tbx_title);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(4, 4, 4, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1083, 528);
            panel2.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 20);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 0;
            label2.Text = "layout";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 72);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(38, 20);
            label3.TabIndex = 1;
            label3.Text = "title";
            // 
            // cbx_Has_children
            // 
            cbx_Has_children.AutoSize = true;
            cbx_Has_children.Location = new Point(19, 276);
            cbx_Has_children.Margin = new Padding(4, 4, 4, 4);
            cbx_Has_children.Name = "cbx_Has_children";
            cbx_Has_children.Size = new Size(121, 24);
            cbx_Has_children.TabIndex = 14;
            cbx_Has_children.Text = "has_children";
            cbx_Has_children.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 120);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 2;
            label4.Text = "parent";
            // 
            // tbx_Has_children
            // 
            tbx_Has_children.Location = new Point(153, 275);
            tbx_Has_children.Margin = new Padding(4, 4, 4, 4);
            tbx_Has_children.Name = "tbx_Has_children";
            tbx_Has_children.Size = new Size(256, 27);
            tbx_Has_children.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(44, 179);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(43, 20);
            label5.TabIndex = 3;
            label5.Text = "level";
            // 
            // tbx_Nav_order
            // 
            tbx_Nav_order.Location = new Point(153, 227);
            tbx_Nav_order.Margin = new Padding(4, 4, 4, 4);
            tbx_Nav_order.Name = "tbx_Nav_order";
            tbx_Nav_order.Size = new Size(256, 27);
            tbx_Nav_order.TabIndex = 10;
            // 
            // txt_Nav_order
            // 
            txt_Nav_order.AutoSize = true;
            txt_Nav_order.Location = new Point(44, 231);
            txt_Nav_order.Margin = new Padding(4, 0, 4, 0);
            txt_Nav_order.Name = "txt_Nav_order";
            txt_Nav_order.Size = new Size(82, 20);
            txt_Nav_order.TabIndex = 4;
            txt_Nav_order.Text = "nav_order";
            // 
            // tbx_Level
            // 
            tbx_Level.Location = new Point(153, 175);
            tbx_Level.Margin = new Padding(4, 4, 4, 4);
            tbx_Level.Name = "tbx_Level";
            tbx_Level.Size = new Size(256, 27);
            tbx_Level.TabIndex = 9;
            // 
            // tbx_Layout
            // 
            tbx_Layout.Location = new Point(153, 16);
            tbx_Layout.Margin = new Padding(4, 4, 4, 4);
            tbx_Layout.Name = "tbx_Layout";
            tbx_Layout.Size = new Size(256, 27);
            tbx_Layout.TabIndex = 6;
            // 
            // tbx_Parent
            // 
            tbx_Parent.Location = new Point(153, 116);
            tbx_Parent.Margin = new Padding(4, 4, 4, 4);
            tbx_Parent.Name = "tbx_Parent";
            tbx_Parent.Size = new Size(449, 27);
            tbx_Parent.TabIndex = 8;
            // 
            // tbx_title
            // 
            tbx_title.Location = new Point(153, 68);
            tbx_title.Margin = new Padding(4, 4, 4, 4);
            tbx_title.Name = "tbx_title";
            tbx_title.Size = new Size(414, 27);
            tbx_title.TabIndex = 7;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { menu_ShowTitle, toolStripSeparator4, menu_CreateFolder, toolStripSeparator2, menu_Refresh, toolStripSeparator3, menu_OpenFolder });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(170, 126);
            // 
            // menu_ShowTitle
            // 
            menu_ShowTitle.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            menu_ShowTitle.Name = "menu_ShowTitle";
            menu_ShowTitle.Size = new Size(169, 26);
            menu_ShowTitle.Text = "文件夹名称";
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(166, 6);
            // 
            // menu_CreateFolder
            // 
            menu_CreateFolder.Image = Properties.Resources.folder;
            menu_CreateFolder.Name = "menu_CreateFolder";
            menu_CreateFolder.Size = new Size(169, 26);
            menu_CreateFolder.Text = "新建文件夹";
            menu_CreateFolder.Click += menu_CreateFolder_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(166, 6);
            // 
            // menu_Refresh
            // 
            menu_Refresh.Name = "menu_Refresh";
            menu_Refresh.Size = new Size(169, 26);
            menu_Refresh.Text = "刷新(&F)";
            menu_Refresh.Click += LoadTreeNodes;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(166, 6);
            // 
            // menu_OpenFolder
            // 
            menu_OpenFolder.Image = Properties.Resources.openfolder;
            menu_OpenFolder.Name = "menu_OpenFolder";
            menu_OpenFolder.Size = new Size(169, 26);
            menu_OpenFolder.Text = "打开文件夹...";
            menu_OpenFolder.Click += menu_OpenFolder_Click;
            // 
            // Form_Main
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1630, 931);
            Controls.Add(splitContainer1);
            Controls.Add(label1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 4, 4, 4);
            Name = "Form_Main";
            StartPosition = FormStartPosition.Manual;
            Text = "Hey，Editor！";
            WindowState = FormWindowState.Maximized;
            Load += Form_Main_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel txtCount;
        private Label label1;
        private SplitContainer splitContainer1;
        private TreeView docTree;
        private ToolStripMenuItem menu_ChooseFile;
        private FolderBrowserDialog folderBrowserDialog1;
        private ImageList imageList1;
        private SplitContainer splitContainer2;
        private RichTextBox tbx_FileContent;
        private TextBox tbx_Has_children;
        private TextBox tbx_Nav_order;
        private TextBox tbx_Level;
        private TextBox tbx_Parent;
        private TextBox tbx_title;
        private TextBox tbx_Layout;
        private Label txt_Nav_order;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private CheckBox cbx_Has_children;
        private LinkLabel txt_FilePath;
        private Panel panel2;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem menu_CreateFolder;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem menu_Refresh;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem menu_OpenFolder;
        private ToolStripMenuItem menu_ShowTitle;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem btn_Save;
        private ToolStripMenuItem toolStripMenuItem5;
        private ToolStripMenuItem toolStripMenuItem6;
        private ToolStripMenuItem toolStripMenuItem7;
    }
}