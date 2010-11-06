using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace Aont
{
    public partial class MainForm : Form
    {
        public MainForm()
        { InitializeComponent(); }

        private void openexe_event(object sender, EventArgs e)
        { this.exe_openFileDialog.ShowDialog(); }

        private void exe_openFileDialog_FileOk(object sender, CancelEventArgs e)
        { this.exe_textBox.Text = this.exe_openFileDialog.FileName; }

        private void openfiles_event(object sender, EventArgs e)
        { this.files_openFileDialog.ShowDialog(); }

        private void files_openFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            var AddFiles = string.Join("\r\n", this.files_openFileDialog.FileNames);
            var NowFiles = this.files_textBox.Text;
            if (NowFiles == "")
            {
                this.files_textBox.Text = AddFiles;
            }
            else
            {
                this.files_textBox.Text = this.files_textBox.Text.TrimEnd('\r', '\n') + "\r\n" + AddFiles;
            }
        }

        private void exit_event(object sender, EventArgs e)
        { this.Close(); }

        private void execute_event(object sender, EventArgs e)
        {
            var p = new Process();
            p.StartInfo.FileName = this.exe_textBox.Text;
            p.StartInfo.WindowStyle = ProcessWindowStyle.Minimized;
            var Filenames = this.files_textBox.Text.Split('\r', '\n');
            foreach (var FileName in Filenames)
            {
                if (FileName == "")
                    continue;

                p.StartInfo.Arguments = string.Format(this.args_textBox.Text, FileName);
                p.Start();
                p.WaitForExit();

            }
            p.Dispose();
        }




    }
}
