namespace Aont
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナ変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナで生成されたコード

        /// <summary>
        /// デザイナ サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディタで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openExecutableFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.executeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exe_textBox = new System.Windows.Forms.TextBox();
            this.args_textBox = new System.Windows.Forms.TextBox();
            this.exe_openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.files_textBox = new System.Windows.Forms.TextBox();
            this.files_openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(480, 26);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openExecutableFileToolStripMenuItem,
            this.openFilesToolStripMenuItem,
            this.toolStripSeparator1,
            this.executeToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(40, 22);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openExecutableFileToolStripMenuItem
            // 
            this.openExecutableFileToolStripMenuItem.Name = "openExecutableFileToolStripMenuItem";
            this.openExecutableFileToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.openExecutableFileToolStripMenuItem.Text = "Open E&xecutable File";
            this.openExecutableFileToolStripMenuItem.Click += new System.EventHandler(this.openexe_event);
            // 
            // openFilesToolStripMenuItem
            // 
            this.openFilesToolStripMenuItem.Name = "openFilesToolStripMenuItem";
            this.openFilesToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.openFilesToolStripMenuItem.Text = "Open &Files";
            this.openFilesToolStripMenuItem.Click += new System.EventHandler(this.openfiles_event);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(194, 6);
            // 
            // executeToolStripMenuItem
            // 
            this.executeToolStripMenuItem.Name = "executeToolStripMenuItem";
            this.executeToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.executeToolStripMenuItem.Text = "E&xecute";
            this.executeToolStripMenuItem.Click += new System.EventHandler(this.execute_event);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(194, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exit_event);
            // 
            // exe_textBox
            // 
            this.exe_textBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.exe_textBox.Location = new System.Drawing.Point(0, 26);
            this.exe_textBox.Name = "exe_textBox";
            this.exe_textBox.Size = new System.Drawing.Size(480, 19);
            this.exe_textBox.TabIndex = 3;
            this.exe_textBox.Text = "explorer";
            this.exe_textBox.DoubleClick += new System.EventHandler(this.openexe_event);
            // 
            // args_textBox
            // 
            this.args_textBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.args_textBox.Location = new System.Drawing.Point(0, 401);
            this.args_textBox.Name = "args_textBox";
            this.args_textBox.Size = new System.Drawing.Size(480, 19);
            this.args_textBox.TabIndex = 4;
            this.args_textBox.Text = "\"{0}\"";
            // 
            // exe_openFileDialog
            // 
            this.exe_openFileDialog.DefaultExt = "exe";
            this.exe_openFileDialog.Filter = "Executable File|*.exe|Any Files|*";
            this.exe_openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.exe_openFileDialog_FileOk);
            // 
            // files_textBox
            // 
            this.files_textBox.AcceptsReturn = true;
            this.files_textBox.AcceptsTab = true;
            this.files_textBox.AllowDrop = true;
            this.files_textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.files_textBox.Location = new System.Drawing.Point(0, 45);
            this.files_textBox.Multiline = true;
            this.files_textBox.Name = "files_textBox";
            this.files_textBox.Size = new System.Drawing.Size(480, 356);
            this.files_textBox.TabIndex = 5;
            this.files_textBox.WordWrap = false;
            this.files_textBox.DoubleClick += new System.EventHandler(this.openfiles_event);
            // 
            // files_openFileDialog
            // 
            this.files_openFileDialog.Filter = "Any File|*";
            this.files_openFileDialog.Multiselect = true;
            this.files_openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.files_openFileDialog_FileOk);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 420);
            this.Controls.Add(this.files_textBox);
            this.Controls.Add(this.args_textBox);
            this.Controls.Add(this.exe_textBox);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "Batch Execute";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.TextBox exe_textBox;
        private System.Windows.Forms.TextBox args_textBox;
        private System.Windows.Forms.OpenFileDialog exe_openFileDialog;
        private System.Windows.Forms.TextBox files_textBox;
        private System.Windows.Forms.OpenFileDialog files_openFileDialog;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openExecutableFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem executeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

