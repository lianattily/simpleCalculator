using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    
    public partial class Form1 : Form
    {
        string op;
        double firstnum;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        //n1
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "1";
            }
            else textBox1.Text = textBox1.Text + "1";
        }

        private void n2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "2";
            }
            else textBox1.Text = textBox1.Text + "2";
        }

        private void n3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "3";
            }
            else textBox1.Text = textBox1.Text + "3";
        }

        private void n4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "4";
            }
            else textBox1.Text = textBox1.Text + "4";
        }

        private void n5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "5";
            }
            else textBox1.Text = textBox1.Text + "5";
        }

        private void n6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "6";
            }
            else textBox1.Text = textBox1.Text + "6";
        }

        private void n7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "7";
            }
            else textBox1.Text = textBox1.Text + "7";
        }

        private void n8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "8";
            }
            else textBox1.Text = textBox1.Text + "8";
        }

        private void n9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "9";
            }
            else textBox1.Text = textBox1.Text + "9";
        }

        private void n0_Click(object sender, EventArgs e)
        {
           textBox1.Text = textBox1.Text + "0";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            firstnum = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            op = "+";
        }

        private void sub_Click(object sender, EventArgs e)
        {
            firstnum = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            op = "-";
        }

        private void div_Click(object sender, EventArgs e)
        {
            firstnum = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            op = "/";
        }

        private void mul_Click(object sender, EventArgs e)
        {
            firstnum = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            op = "*";
        }

        private void mod_Click(object sender, EventArgs e)
        {
            firstnum = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            op = "%";
        }

        private void equal_Click(object sender, EventArgs e)
        {
            double secondnum, res;
            secondnum = Convert.ToDouble(textBox1.Text);
            switch (op)
            {
                case "+": res = firstnum + secondnum; textBox1.Text = Convert.ToString(res); break;
                case "-": res = firstnum - secondnum; textBox1.Text = Convert.ToString(res); break;
                case "/": if (secondnum == 0) { textBox1.Text = "Cannot divide by zero"; break; }
                    else { res = (firstnum * 1.0 / secondnum); textBox1.Text = Convert.ToString(res); break; }
                case "*": res = firstnum *secondnum; textBox1.Text = Convert.ToString(res); break;
                case "%": res = firstnum % secondnum; textBox1.Text = Convert.ToString(res); break;
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            textBox1.Text += ".";
        }

        private void clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }
    }
}
