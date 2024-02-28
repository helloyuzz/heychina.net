namespace HeyEditor {
    partial class DialogAddFolder {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            label1 = new Label();
            tbx_Folder = new TextBox();
            btn_Save = new Button();
            txt_FolderPath = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 68);
            label1.Name = "label1";
            label1.Size = new Size(68, 17);
            label1.TabIndex = 0;
            label1.Text = "文件夹名称";
            // 
            // tbx_Folder
            // 
            tbx_Folder.Location = new Point(107, 65);
            tbx_Folder.Name = "tbx_Folder";
            tbx_Folder.Size = new Size(224, 23);
            tbx_Folder.TabIndex = 1;
            // 
            // btn_Save
            // 
            btn_Save.Location = new Point(107, 128);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(75, 23);
            btn_Save.TabIndex = 2;
            btn_Save.Text = "确定";
            btn_Save.UseVisualStyleBackColor = true;
            btn_Save.Click += btn_Save_Click;
            // 
            // txt_FolderPath
            // 
            txt_FolderPath.AutoSize = true;
            txt_FolderPath.Location = new Point(59, 37);
            txt_FolderPath.Name = "txt_FolderPath";
            txt_FolderPath.Size = new Size(24, 17);
            txt_FolderPath.TabIndex = 3;
            txt_FolderPath.Text = "d:\\";
            // 
            // DialogAddFolder
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(390, 241);
            Controls.Add(txt_FolderPath);
            Controls.Add(btn_Save);
            Controls.Add(tbx_Folder);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DialogAddFolder";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "新增文件夹";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbx_Folder;
        private Button btn_Save;
        private Label txt_FolderPath;
    }
}