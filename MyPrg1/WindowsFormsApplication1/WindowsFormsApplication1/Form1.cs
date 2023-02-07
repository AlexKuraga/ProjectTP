using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Resources;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        ResourceManager rm = new ResourceManager("ColOfPR", typeof(Form1).Assembly);
        string dateString;
        string text;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // ResourceManager rm = new ResourceManager("ColOfPR", typeof(Form1).Assembly);
            //dateString = rm.GetString("ColOfPr");
            text = "HelloWorld";

            string[] countries = { "123", "2", "a", "b", "c" };
            listBox1.Items.AddRange(countries);

            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            
        }
        
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCountry = listBox1.SelectedItem.ToString();
            MessageBox.Show(selectedCountry);
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "HelloWorld";
            textBox2.Text = "dlroWolleH";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.fontDialog1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            text = textBox2.Text;
            textBox2.Text = textBox1.Text;
            textBox1.Text = text;
        }
    }
}
