using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string first, second;
        char operationType = ' ';

        private void operation(int number)
        {
            if(operationType == ' ')
            {
                first += number;
                textBox1.Text = first;
            }
            else
            {
                second += number;
                textBox1.Text = second;
            }
        }
            

        private void button1_Click(object sender, EventArgs e)
        {
            operation(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            operation(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            operation(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            operation(4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            operation(5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            operation(6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            operation(7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            operation(8);

        }

        private void button9_Click(object sender, EventArgs e)
        {
            operation(9);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            operation(0);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Multiplication_Click(object sender, EventArgs e)
        {
            operationType = '*';
            textBox1.Text = "";
        }

        private void Division_Click(object sender, EventArgs e)
        {
            operationType = '/';
            textBox1.Text = "";
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            operationType = '+';
            textBox1.Text = "";
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            operationType = '-';
            textBox1.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            operationType = '$';
        }

        private void sqrt_Click(object sender, EventArgs e)
        {
            operationType = '#';
        }


        private void clear_Click(object sender, EventArgs e)
        {
            operationType = ' ';
            textBox1.Text = " ";
        }

        private void Equal_Click(object sender, EventArgs e)
        {
            switch(operationType)
            {
                case ('+'):
                    textBox1.Text = (double.Parse(first) + double.Parse(second)).ToString();
                    break;
                case ('-'):
                    textBox1.Text = (double.Parse(first) - double.Parse(second)).ToString();
                    break;
                case ('*'):
                    textBox1.Text = (double.Parse(first) * double.Parse(second)).ToString();
                    break;
                case ('/'):
                    textBox1.Text = (double.Parse(first) / double.Parse(second)).ToString();
                    break;
                case ('#'):
                    textBox1.Text = Math.Sqrt(double.Parse(first)).ToString();
                    break;
                case ('$'):
                    textBox1.Text = Math.Pow(double.Parse(first), 1D / 3).ToString();
                    break;
            }
            first = "";
            second = "";
            operationType = ' ';
        }
    }
}
