using System.Diagnostics;

namespace HeyEditor {
    public partial class Form_Main : Form {
        int folderCount = 0;
        int fileCount = 0;
        public Form_Main() {
            InitializeComponent();
        }

        private void menu_ChooseFile_Click(object sender, EventArgs e) {
            if (Directory.Exists(menu_ChooseFile.Text) == true) {
                //Process.Start(menu_ChooseFile.Text);
                var dlgResult = MessageBox.Show("是否更换文件夹？", "系统提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlgResult != DialogResult.Yes) {
                    return;
                }
            }
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK) {
                menu_ChooseFile.Text = folderBrowserDialog1.SelectedPath;

                ConfigUtil.WriteValue("FileFolder", menu_ChooseFile.Text);
                LoadTreeNodes(sender, e);
            }
        }

        private void Form_Main_Load(object sender, EventArgs e) {
            LoadTreeNodes(sender, e);
        }

        private void LoadTreeNodes(object sender, EventArgs e) {
            var filePath = ConfigUtil.ReadSetting("FileFolder");
            if (string.IsNullOrEmpty(filePath)) {
                filePath = "！未选择文件路径...";
            }
            if (Directory.Exists(filePath) == true) {
                folderCount = 0;
                fileCount = 0;
                menu_ChooseFile.Text = filePath;
                docTree.Nodes.Clear();

                LoadTreeNode(null, filePath);
            }
            for (int n = 0; n < docTree.Nodes.Count; n++) {
                docTree.Nodes[n].Expand();
            }
            txtCount.Text = "统计，文件夹数量：" + folderCount + " | 文件数量：" + fileCount;
        }

        private void LoadTreeNode(TreeNode node, string filePath) {
            if (node != null) {
                node.Nodes.Clear();
            }
            var items = Directory.GetDirectories(filePath);
            foreach (var item in items) {
                DirectoryInfo info = new DirectoryInfo(item);
                TreeNode treeNode = new TreeNode(info.Name, 0, 0);
                treeNode.Name = info.FullName;
                if (node == null) {
                    docTree.Nodes.Add(treeNode);
                } else {
                    node.Nodes.Add(treeNode);
                }
                folderCount++;
                LoadTreeNode(treeNode, info.FullName);
                LoadTreeFile(treeNode, info.FullName);
            }
        }

        // 文件名为TreeNode.name
        private void LoadTreeFile(TreeNode treeNode, string directoryName) {
            var items = Directory.GetFiles(directoryName);
            foreach (var item in items) {
                var info = new FileInfo(item);
                TreeNode file = new TreeNode(info.Name, 1, 1);
                file.Name = info.FullName;
                treeNode.Nodes.Add(file);
                fileCount++;
            }
        }

        private void docTree_MouseClick(object sender, MouseEventArgs e) {

        }

        private void menu_ExpandAll_Click(object sender, EventArgs e) {
            if (docTree.SelectedNode != null) {
                docTree.SelectedNode.ExpandAll();
            }
        }

        private void menu_Collapse_Click(object sender, EventArgs e) {
            if (docTree.SelectedNode != null) {
                docTree.CollapseAll();
            }
        }

        private void docTree_AfterSelect(object sender, TreeViewEventArgs e) {
            if (e.Node == null) {
                return;
            }
            txt_FilePath.Text = e.Node.Name;
            if (File.Exists(e.Node.Name) == false) {
                return;
            }
            tbx_FileContent.Clear();
            tbx_Has_children.Clear();
            tbx_Layout.Clear();
            tbx_Level.Clear();
            tbx_Nav_order.Clear();
            tbx_Parent.Clear();
            tbx_title.Clear();

            string txt = "";
            var rowIndex = 0;
            using (var reader = File.OpenText(e.Node.Name)) {
                while ((txt = reader.ReadLine()) != null) {
                    tbx_FileContent.AppendText(txt);
                    tbx_FileContent.AppendText("\n");
                    if ("---".Equals(txt.Trim())) {
                        rowIndex++;
                    }

                    if (rowIndex > 2) {
                        continue;
                    }
                    var items = txt.Split(":");
                    if(items.Length<=1) { continue; }
                    var value = items[1].Trim();
                    if (txt.StartsWith("layout")) {
                        tbx_Layout.Text = value;
                    }
                    if (txt.StartsWith("title")) {
                        tbx_title.Text = value;
                    }
                    if (txt.StartsWith("parent")) {
                        tbx_Parent.Text = value;
                    }
                    if (txt.StartsWith("level")) {
                        tbx_Level.Text = value;
                    }
                    if (txt.StartsWith("nav_order")) {
                        tbx_Nav_order.Text = value;
                    }
                    if (txt.StartsWith("has_children")) {
                        tbx_Has_children.Text = value;
                    }
                }
            }
        }

        private void menu_CreateFolder_Click(object sender, EventArgs e) {
            if (docTree.SelectedNode == null) { return; }
            var addFolder = new DialogAddFolder(docTree.SelectedNode.Name);
            if (addFolder.ShowDialog() == DialogResult.OK) {
                docTree.SelectedNode.Expand();
                LoadTreeNode(docTree.SelectedNode, docTree.SelectedNode.Name);
                LoadTreeFile(docTree.SelectedNode, docTree.SelectedNode.Name);
            }
        }

        private void docTree_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e) {
            if (e.Button == MouseButtons.Right) {
                if (e.Node != null) {
                    docTree.SelectedNode = e.Node;
                }
                menu_ShowTitle.Text = e.Node.Name;
                contextMenuStrip1.Show(PointToClient(MousePosition));
            }
        }

        private void menu_OpenFolder_Click(object sender, EventArgs e) {
            if (docTree.SelectedNode == null) { return; };
            if (Directory.Exists(docTree.SelectedNode.Name)) {
                Process.Start("explorer.exe", docTree.SelectedNode.Name);
            }
        }
    }
}