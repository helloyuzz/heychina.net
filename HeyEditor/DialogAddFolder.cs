using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeyEditor {
    public partial class DialogAddFolder : Form {
        string folderName;
        public DialogAddFolder(string folderPath) {
            InitializeComponent();
            folderName = folderPath;
            txt_FolderPath.Text = folderPath;
        }

        private void btn_Save_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
