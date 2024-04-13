using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace лаба_10__задание_2
{
    public partial class Form1 : Form
    {
        int a;
        public Form1()
        {
            InitializeComponent();
        }
        private double whhile(int a, int n = 0)
        {
            double result = 0;
            while (n <=a)
            {
                result += Math.Pow((2 * n - 1), 2);
                n++;
            }
            
            return result;
        }
        private double Formula(int a)
        {
            return a * (4 * a * a - 1) / 3;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '0';
            if (textBox1.Text[0] == '0')
            {
                textBox1.Text.Remove(textBox1.Text[0]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '1';
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '2';
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '3';
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '4';
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '5';
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '6';
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '7';
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '8';
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '9';
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button11_MouseClick(object sender, MouseEventArgs e)
        {
            a = Convert.ToInt32(textBox1.Text);
            textBox1.Text = Convert.ToString(whhile(a, 1)) + " " +"ВЫЧИСЛЕНО ЦИКЛОМ";

        }

        private void button12_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = null;
        }

        private void button13_MouseClick(object sender, MouseEventArgs e)
        {
            a = Convert.ToInt32(textBox1.Text);
            textBox1.Text = Convert.ToString(Formula(a)) + " " + "ВЫЧЕСЛЕНО ФОРМУЛОЙ - НЕ ЗНАЮ ЗАЧЕМ, НО НАДО!";
        }
    }
}
