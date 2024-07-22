namespace HeyEditor {
    public partial class DialogAddFolder : Form {
        string folderName;
        public DialogAddFolder(string folderPath) {
            InitializeComponent();
            folderName = folderPath;
            txt_FolderPath.Text = folderPath;
            this.Text = folderPath;
        }

        private void btn_Save_Click(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(tbx_Folder.Text.Trim())) {
                return;
            }

            var newFolderPath = txt_FolderPath.Text + "\\" + tbx_Folder.Text.Trim();
            Directory.CreateDirectory(newFolderPath);
            if (Directory.Exists(newFolderPath)) {
                this.DialogResult = DialogResult.OK;
                this.Close();
            } else {
                WinUtil.Warring("文件夹未能创建，请检查原因。");
                tbx_Folder.Focus();
            }
        }
    }
}
