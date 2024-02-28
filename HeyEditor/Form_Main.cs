using System.Configuration;
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
                return;
            }
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK) {
                menu_ChooseFile.Text = folderBrowserDialog1.SelectedPath;

                ConfigUtil.WriteValue("FileFolder", menu_ChooseFile.Text);
            }
        }

        private void Form_Main_Load(object sender, EventArgs e) {
            refreshTree();
        }

        private void refreshTree() {
            var filePath = ConfigUtil.ReadSetting("FileFolder");
            if (string.IsNullOrEmpty(filePath)) {
                filePath = "！未选择文件路径...";
            }
            if (Directory.Exists(filePath) == true) {
                folderCount = 0;
                fileCount = 0;
                menu_ChooseFile.Text = filePath;

                loadTreeNode(null, filePath);
            }
            txtCount.Text = "统计，文件夹数量：" + folderCount + " | 文件数量：" + fileCount;
        }

        private void loadTreeNode(TreeNode node, string filePath) {
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
                loadTreeNode(treeNode, info.FullName);
                loadTreeFile(treeNode, info.FullName);
            }
        }

        // 文件名为TreeNode.name
        private void loadTreeFile(TreeNode treeNode, string fullName) {
            var items = Directory.GetFiles(fullName);
            foreach (var item in items) {
                var info = new FileInfo(item);
                TreeNode file = new TreeNode(info.Name, 1, 1);
                file.Name = info.FullName;
                treeNode.Nodes.Add(file);
                fileCount++;
            }
        }

        private void docTree_MouseClick(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Right) {
                var item = docTree.GetNodeAt(e.Location);
                if (item != null) {
                    docTree.SelectedNode = item;
                    contextMenuStrip1.Show(docTree, PointToClient(e.Location));
                }
            }
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
                    if ("---".Equals(txt)) {
                        rowIndex++;
                    }

                    if (rowIndex > 2) {
                        continue;
                    }
                    var items = txt.Split(":");
                    if (txt.StartsWith("layout")) {
                        tbx_Layout.Text = items[1].Trim();
                    }
                    if (txt.StartsWith("title")) {
                        tbx_title.Text = items[1].Trim();
                    }
                    if (txt.StartsWith("parent")) {
                        tbx_Parent.Text = items[1].Trim();
                    }
                    if (txt.StartsWith("level")) {
                        tbx_Level.Text = items[1].Trim();
                    }
                    if (txt.StartsWith("nav_order")) {
                        tbx_Nav_order.Text = items[1].Trim();
                    }
                    if (txt.StartsWith("has_children")) {
                        tbx_Has_children.Text = items[1].Trim();
                    }
                }
            }
        }

        private void menu_CreateFolder_Click(object sender, EventArgs e) {
            if (docTree.SelectedNode == null) { return; }
            var addFolder = new DialogAddFolder(docTree.SelectedNode.Name);
            if (addFolder.ShowDialog() == DialogResult.OK) {

            }
        }
    }
}