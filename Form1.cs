using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nelilaskin
{
    public partial class Form1 : Form
    {
        double summa;
        double num1;
        double num2;
        int op;
        string t = "0";


        public Form1()
        {
            InitializeComponent();

            button1.Click += lisaaEdelliseen;
            button2.Click += lisaaEdelliseen;
            button3.Click += lisaaEdelliseen;
            button6.Click += lisaaEdelliseen;
            button7.Click += lisaaEdelliseen;
            button8.Click += lisaaEdelliseen;
            button10.Click += lisaaEdelliseen;
            button11.Click += lisaaEdelliseen;
            button12.Click += lisaaEdelliseen;
            button15.Click += lisaaEdelliseen;
            button16.Click += lisaaEdelliseen;

        }

        private void lisaaEdelliseen(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            textBox1.Text += b.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {   
            num1 = int.Parse(textBox1.Text);

            if (double.Parse(t) > 0)
            {
                num1 = num1 + double.Parse(t);
            }

            textBox1.Clear();
            op = 1;
            t = num1.ToString();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(textBox1.Text);

            if (double.Parse(t) > 0)
            {
                num1 = num1 - double.Parse(t);
            }

            textBox1.Clear();
            op = 2;
            t = num1.ToString();
        }
        private void button9_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(textBox1.Text);

            if (double.Parse(t) > 0)
            {
                num1 = num1 / double.Parse(t);
            }

            textBox1.Clear();
            op = 3;
            t = num1.ToString();
        }
        private void kerroin_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(textBox1.Text);

            if (double.Parse(t) > 0)
            {
                num1 = num1 * double.Parse(t);
            }

            textBox1.Clear();
            op = 4;
            t = num1.ToString();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            num2 = double.Parse(textBox1.Text);

            switch (op)
            {
                case 1:
                    summa = double.Parse(t) + num2;
                    textBox1.Clear();
                    textBox1.Text += summa.ToString();
                    op = 0;
                    break;

                case 2:
                    summa = double.Parse(t) - num2;
                    textBox1.Clear();
                    textBox1.Text += summa.ToString();
                    op = 0;
                    break;

                case 3:
                    summa = double.Parse(t) / num2;
                    textBox1.Clear();
                    textBox1.Text += summa.ToString();
                    op = 0;
                    break;

                case 4:
                    summa = double.Parse(t) * num2;
                    textBox1.Clear();
                    textBox1.Text += summa.ToString();
                    op = 0;
                    break;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
    }
}
