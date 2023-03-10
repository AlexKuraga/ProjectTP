using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public string Path1;
        public string ChosenFile;
        public string chfl;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await Task.Run(() => redactor());
        }

        private void redactor()
        {
            try 
            {

            }
            catch (Exception ex) { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            FolderBrowserDialog fbg = new FolderBrowserDialog();
            fbg.ShowDialog();
            Path1 = Path.GetFullPath(fbg.SelectedPath);
            DirectoryInfo dinfo1 = new DirectoryInfo(Path1);
            FileInfo[] Files1 = dinfo1.GetFiles("*.txt");
            foreach (FileInfo file in Files1)
            {
                listBox1.Items.Add(file.Name);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string curItem1 = listBox1.SelectedItem.ToString();
            ChosenFile = curItem1;
            string curFile1 = Path1 + @"\" + curItem1;
            chfl = curFile1;
        }
    }
}
