using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string buf = 
                textBox1.Text + Environment.NewLine +
                textBox2.Text + Environment.NewLine +
                dateTimePicker1.Text + Environment.NewLine +
                textBox4.Text + Environment.NewLine +
                textBox5.Text;
            textBox6.Text = buf;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0)
            {
                foreach (char c in textBox1.Text)
                {
                    if (!char.IsLetter(c))
                        MessageBox.Show("В поле можна вводити тільки літери");
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0)
            {
                foreach (char c in textBox1.Text)
                {
                    if (!char.IsLetter(c))
                        MessageBox.Show("В поле можна вводити тільки літери");
                }
            }
        }
    }
}
