using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U04091702
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Text = "+";
            button2.Text = "-";
            button3.Text = "x";
            button4.Text = "/";
            label1.Text = "Tal 1   -->";
            label2.Text = "Tal 2   -->";
            label3.Text = "Summan av talen är: ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i;
            i = Int32.Parse(textBox1.Text);

            int j;
            j = Int32.Parse(textBox2.Text);

            listBox1.Items.Add(i + j);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i;
            i = Int32.Parse(textBox1.Text);

            int j;
            j = Int32.Parse(textBox2.Text);

            listBox1.Items.Add(i - j);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i;
            i = Int32.Parse(textBox1.Text);

            int j;
            j = Int32.Parse(textBox2.Text);

            listBox1.Items.Add(i * j);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            float i;
            i = float.Parse(textBox1.Text);

            float j;
            j = float.Parse(textBox2.Text);

            listBox1.Items.Add(i / j);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
