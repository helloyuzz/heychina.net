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
            toolStripMenuItem3 = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripMenuItem2 = new ToolStripMenuItem();
            menu_ChooseFile = new ToolStripMenuItem();
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
            panel1 = new Panel();
            label6 = new Label();
            button3 = new Button();
            button1 = new Button();
            button2 = new Button();
            btn_Reload = new Button();
            btn_Save = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            contextMenuStrip1 = new ContextMenuStrip(components);
            menu_ShowTitle = new ToolStripMenuItem();
            menu_CreateFolder = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            menu_Refresh = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            menu_OpenFolder = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
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
            panel1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, menu_ChooseFile });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1268, 25);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem3, toolStripSeparator1, toolStripMenuItem2 });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(58, 21);
            toolStripMenuItem1.Text = "文件(&F)";
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(116, 22);
            toolStripMenuItem3.Text = "刷新";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(113, 6);
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(116, 22);
            toolStripMenuItem2.Text = "退出(&X)";
            // 
            // menu_ChooseFile
            // 
            menu_ChooseFile.Name = "menu_ChooseFile";
            menu_ChooseFile.Size = new Size(125, 21);
            menu_ChooseFile.Text = "！未选择文件路径...";
            menu_ChooseFile.Click += menu_ChooseFile_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { txtCount });
            statusStrip1.Location = new Point(0, 769);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1268, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // txtCount
            // 
            txtCount.Name = "txtCount";
            txtCount.Size = new Size(32, 17);
            txtCount.Text = "统计";
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ActiveBorder;
            label1.Dock = DockStyle.Top;
            label1.Location = new Point(0, 25);
            label1.Name = "label1";
            label1.Size = new Size(1268, 1);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // splitContainer1
            // 
            splitContainer1.BackColor = SystemColors.ActiveBorder;
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 26);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = SystemColors.ControlLight;
            splitContainer1.Panel1.Controls.Add(docTree);
            splitContainer1.Panel1.Padding = new Padding(3);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Size = new Size(1268, 743);
            splitContainer1.SplitterDistance = 422;
            splitContainer1.TabIndex = 3;
            // 
            // docTree
            // 
            docTree.Dock = DockStyle.Fill;
            docTree.HideSelection = false;
            docTree.ImageIndex = 0;
            docTree.ImageList = imageList1;
            docTree.Location = new Point(3, 3);
            docTree.Name = "docTree";
            docTree.SelectedImageIndex = 0;
            docTree.Size = new Size(416, 737);
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
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.BackColor = SystemColors.Control;
            splitContainer2.Panel1.Controls.Add(tbx_FileContent);
            splitContainer2.Panel1.Controls.Add(txt_FilePath);
            splitContainer2.Panel1.Padding = new Padding(3);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.BackColor = Color.White;
            splitContainer2.Panel2.Controls.Add(panel2);
            splitContainer2.Panel2.Controls.Add(panel1);
            splitContainer2.Size = new Size(842, 743);
            splitContainer2.SplitterDistance = 280;
            splitContainer2.TabIndex = 0;
            // 
            // tbx_FileContent
            // 
            tbx_FileContent.BackColor = Color.White;
            tbx_FileContent.Dock = DockStyle.Fill;
            tbx_FileContent.Location = new Point(3, 3);
            tbx_FileContent.Name = "tbx_FileContent";
            tbx_FileContent.ReadOnly = true;
            tbx_FileContent.Size = new Size(836, 257);
            tbx_FileContent.TabIndex = 0;
            tbx_FileContent.Text = "";
            // 
            // txt_FilePath
            // 
            txt_FilePath.Dock = DockStyle.Bottom;
            txt_FilePath.Location = new Point(3, 260);
            txt_FilePath.Name = "txt_FilePath";
            txt_FilePath.Size = new Size(836, 17);
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
            panel2.Location = new Point(0, 60);
            panel2.Name = "panel2";
            panel2.Size = new Size(842, 399);
            panel2.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 13);
            label2.Name = "label2";
            label2.Size = new Size(43, 17);
            label2.TabIndex = 0;
            label2.Text = "layout";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 57);
            label3.Name = "label3";
            label3.Size = new Size(29, 17);
            label3.TabIndex = 1;
            label3.Text = "title";
            // 
            // cbx_Has_children
            // 
            cbx_Has_children.AutoSize = true;
            cbx_Has_children.Location = new Point(-4, 231);
            cbx_Has_children.Name = "cbx_Has_children";
            cbx_Has_children.Size = new Size(98, 21);
            cbx_Has_children.TabIndex = 14;
            cbx_Has_children.Text = "has_children";
            cbx_Has_children.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 98);
            label4.Name = "label4";
            label4.Size = new Size(46, 17);
            label4.TabIndex = 2;
            label4.Text = "parent";
            // 
            // tbx_Has_children
            // 
            tbx_Has_children.Location = new Point(100, 230);
            tbx_Has_children.Name = "tbx_Has_children";
            tbx_Has_children.Size = new Size(200, 23);
            tbx_Has_children.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 148);
            label5.Name = "label5";
            label5.Size = new Size(34, 17);
            label5.TabIndex = 3;
            label5.Text = "level";
            // 
            // tbx_Nav_order
            // 
            tbx_Nav_order.Location = new Point(100, 189);
            tbx_Nav_order.Name = "tbx_Nav_order";
            tbx_Nav_order.Size = new Size(200, 23);
            tbx_Nav_order.TabIndex = 10;
            // 
            // txt_Nav_order
            // 
            txt_Nav_order.AutoSize = true;
            txt_Nav_order.Location = new Point(15, 192);
            txt_Nav_order.Name = "txt_Nav_order";
            txt_Nav_order.Size = new Size(66, 17);
            txt_Nav_order.TabIndex = 4;
            txt_Nav_order.Text = "nav_order";
            // 
            // tbx_Level
            // 
            tbx_Level.Location = new Point(100, 145);
            tbx_Level.Name = "tbx_Level";
            tbx_Level.Size = new Size(200, 23);
            tbx_Level.TabIndex = 9;
            // 
            // tbx_Layout
            // 
            tbx_Layout.Location = new Point(100, 10);
            tbx_Layout.Name = "tbx_Layout";
            tbx_Layout.Size = new Size(200, 23);
            tbx_Layout.TabIndex = 6;
            // 
            // tbx_Parent
            // 
            tbx_Parent.Location = new Point(100, 95);
            tbx_Parent.Name = "tbx_Parent";
            tbx_Parent.Size = new Size(350, 23);
            tbx_Parent.TabIndex = 8;
            // 
            // tbx_title
            // 
            tbx_title.Location = new Point(100, 54);
            tbx_title.Name = "tbx_title";
            tbx_title.Size = new Size(323, 23);
            tbx_title.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.Controls.Add(label6);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(btn_Reload);
            panel1.Controls.Add(btn_Save);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(842, 60);
            panel1.TabIndex = 18;
            // 
            // label6
            // 
            label6.BackColor = SystemColors.ActiveBorder;
            label6.Dock = DockStyle.Bottom;
            label6.Location = new Point(0, 59);
            label6.Name = "label6";
            label6.Size = new Size(842, 1);
            label6.TabIndex = 18;
            label6.Text = "label6";
            // 
            // button3
            // 
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.ImageKey = "file.png";
            button3.ImageList = imageList1;
            button3.Location = new Point(131, 14);
            button3.Name = "button3";
            button3.Size = new Size(139, 32);
            button3.TabIndex = 17;
            button3.Text = "Create .md File";
            button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.ImageIndex = 0;
            button1.ImageList = imageList1;
            button1.Location = new Point(15, 14);
            button1.Name = "button1";
            button1.Size = new Size(110, 32);
            button1.TabIndex = 15;
            button1.Text = "Create Folder";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(276, 14);
            button2.Name = "button2";
            button2.Size = new Size(112, 32);
            button2.TabIndex = 16;
            button2.Text = "Rename Folder";
            button2.UseVisualStyleBackColor = true;
            // 
            // btn_Reload
            // 
            btn_Reload.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_Reload.Location = new Point(751, 14);
            btn_Reload.Name = "btn_Reload";
            btn_Reload.Size = new Size(79, 32);
            btn_Reload.TabIndex = 13;
            btn_Reload.Text = "刷新";
            btn_Reload.UseVisualStyleBackColor = true;
            // 
            // btn_Save
            // 
            btn_Save.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_Save.Location = new Point(403, 14);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(112, 32);
            btn_Save.TabIndex = 12;
            btn_Save.Text = "Save File(.md)";
            btn_Save.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { menu_ShowTitle, toolStripSeparator4, menu_CreateFolder, toolStripSeparator2, menu_Refresh, toolStripSeparator3, menu_OpenFolder });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(146, 110);
            // 
            // menu_ShowTitle
            // 
            menu_ShowTitle.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            menu_ShowTitle.Name = "menu_ShowTitle";
            menu_ShowTitle.Size = new Size(180, 22);
            menu_ShowTitle.Text = "文件夹名称";
            // 
            // menu_CreateFolder
            // 
            menu_CreateFolder.Image = Properties.Resources.folder;
            menu_CreateFolder.Name = "menu_CreateFolder";
            menu_CreateFolder.Size = new Size(180, 22);
            menu_CreateFolder.Text = "新建文件夹";
            menu_CreateFolder.Click += menu_CreateFolder_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(177, 6);
            // 
            // menu_Refresh
            // 
            menu_Refresh.Name = "menu_Refresh";
            menu_Refresh.Size = new Size(180, 22);
            menu_Refresh.Text = "刷新(&F)";
            menu_Refresh.Click += LoadTreeNodes;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(177, 6);
            // 
            // menu_OpenFolder
            // 
            menu_OpenFolder.Image = Properties.Resources.openfolder;
            menu_OpenFolder.Name = "menu_OpenFolder";
            menu_OpenFolder.Size = new Size(145, 22);
            menu_OpenFolder.Text = "打开文件夹...";
            menu_OpenFolder.Click += menu_OpenFolder_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(177, 6);
            // 
            // Form_Main
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1268, 791);
            Controls.Add(splitContainer1);
            Controls.Add(label1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
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
            panel1.ResumeLayout(false);
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel txtCount;
        private Label label1;
        private SplitContainer splitContainer1;
        private TreeView docTree;
        private ToolStripMenuItem menu_ChooseFile;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripSeparator toolStripSeparator1;
        private FolderBrowserDialog folderBrowserDialog1;
        private ImageList imageList1;
        private SplitContainer splitContainer2;
        private RichTextBox tbx_FileContent;
        private Button btn_Reload;
        private Button btn_Save;
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
        private Button button3;
        private Button button2;
        private Button button1;
        private Panel panel1;
        private Panel panel2;
        private Label label6;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem menu_CreateFolder;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem menu_Refresh;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem menu_OpenFolder;
        private ToolStripMenuItem menu_ShowTitle;
        private ToolStripSeparator toolStripSeparator4;
    }
}