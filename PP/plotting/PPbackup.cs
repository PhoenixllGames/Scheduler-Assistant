using PP.message;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PP.plotting
{
    public partial class PPbackup : Form
    {
        public PPbackup()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog() { Description = "Select your path." })
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    webBrowser1.Url = new Uri(fbd.SelectedPath);
                    textBox1.Text = fbd.SelectedPath;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoBack)
                webBrowser1.GoBack();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoForward)
                webBrowser1.GoForward();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bool confirm;
            if (textBox1.Text == "") {
                using (var form = new PPerr_massege())
                {
                    form.change = 3;
                    var result = form.ShowDialog();
                }
                return;
            }
            string directory = System.IO.Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName)+"\\";
            string before = "db.sqlite3", after = "backup.sqlite3";
            string sourceFile = System.IO.Path.Combine(directory, before);
            string destFile = System.IO.Path.Combine(textBox1.Text, after);

            using (var form = new PPconfirm())
            {
                var result = form.ShowDialog();
                confirm = form.confirm;
            }
            if (!confirm) return;
            try
            {
                System.IO.File.Copy(sourceFile, destFile, true);
            }
            catch { 
            using (var form = new PPerr_massege())
                {
                    form.change = 3;
                    var result = form.ShowDialog();
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            bool confirm;
            if (textBox1.Text == "")
            {
                using (var form = new PPerr_massege())
                {
                    form.change = 3;
                    var result = form.ShowDialog();
                }
                return;
            }
            string directory = System.IO.Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName) + "\\";
            string before = "db.sqlite3", after = "backup.sqlite3";
            string sourceFile = System.IO.Path.Combine(directory, before);
            string destFile = System.IO.Path.Combine(textBox1.Text, after);

            using (var form = new PPconfirm())
            {
                var result = form.ShowDialog();
                confirm = form.confirm;
            }
            if (!confirm) return;
            if (System.IO.File.Exists(destFile))
                try
                {


                    System.IO.File.Delete(sourceFile);
                    System.IO.File.Copy(destFile, sourceFile, true);
                }
                catch
                {
                    using (var form = new PPerr_massege())
                    {
                        form.change = 3;
                        var result = form.ShowDialog();
                    }
                }
            else using (var form = new PPerr_massege())
                {
                    form.change = 3;
                    var result = form.ShowDialog();
                }
        }
    }
}
