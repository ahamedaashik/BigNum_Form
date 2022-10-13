using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BigNum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float num1 = float.Parse(textBox1.Text);
            float num2 = float.Parse(textBox2.Text);

            if (num1 > num2)
            {
                textBox3.Text = ("First number is big" + num1);
            }
            else if (num1 == num2)
            {
                textBox3.Text = ("Both Numbers are equal " + num1);
            }
            else
            {
                textBox3.Text = ("Number 2 is big : " + num2);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
