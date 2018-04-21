using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        string num;
        string sign;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }
            Button b = (Button)sender;

            textBox1.Text += b.Text;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Text = "0";
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = num + " " + sign;
            
            num = textBox1.Text;
            textBox1.Clear();
            sign = "+";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            label1.Text = num + " " + sign;
            num = textBox1.Text;
            textBox1.Clear();
            sign = "-";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            label1.Text = num + " " + sign;
            num = textBox1.Text;
            textBox1.Clear();
            sign = "*";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            label1.Text = num + " " + sign;
            num = textBox1.Text;
            textBox1.Clear();
            sign = "/";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            label1.Text = " ";
            if (sign == "+")
            {
                textBox1.Text = (double.Parse(num) + double.Parse(textBox1.Text)).ToString();
            }
            else if (sign == "-")
            {
                textBox1.Text = (double.Parse(num) - double.Parse(textBox1.Text)).ToString();
            }
            else if (sign == "*")
            {
                textBox1.Text = (double.Parse(num) * double.Parse(textBox1.Text)).ToString();
            }
            else if (sign == "/")
            {
                if (textBox1.Text == "0")
                {
                    Console.WriteLine("Math error");
                }
                else
                {
                    textBox1.Text = (double.Parse(num) + double.Parse(textBox1.Text)).ToString();
                }

            }
           

        }

       
        

        

       
    }
}
