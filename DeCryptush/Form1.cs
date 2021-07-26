using Decryptor.lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Decryptor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string key = KeytextBox.Text;

            // collect file paths
            string docsDir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string desktopDir = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);           
            string[] paths = {
                @"C:\Users\yuval.moravchic\Desktop\RansomTest",
                @"C:\Users\yuval.moravchic\Desktop\RansomTest2" };

            var files = dCollector.Start(paths);
            bool success = true;

            foreach (string file in files)
            {
                string result = dAES.DecryptFile(file, key);
                if (result != "OK") { MessageBox.Show(result); success = false; break; }
                File.Delete(file);
            }
            if (success) { MessageBox.Show("Done."); }
        }
    }
}
