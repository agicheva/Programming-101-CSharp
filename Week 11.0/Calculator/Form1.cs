using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private string operand1;
        private string operand2;
        private char operation;
        private string result;

        public Form1()
        {   
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void buttonPoint_Click(object sender, EventArgs e)
        {
            string textTillNow = (string)textBox1.Text.Clone();

            textBox1.Text = textTillNow + ",";
        }

        private void buttonSum_Click(object sender, EventArgs e)
        {
            string textTillNow = (string)textBox1.Text.Clone();

            operand1 = textTillNow;
            operation = '+';
            textBox1.Text = textTillNow + "+";
            textBox1.Text = string.Empty;
        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            string textTillNow = (string)textBox1.Text.Clone();

            operand1 = textTillNow;
            operation = '-';
            textBox1.Text = textTillNow + "-";
            textBox1.Text = string.Empty;
        }

        private void buttonMult_Click(object sender, EventArgs e)
        {
            string textTillNow = (string)textBox1.Text.Clone();

            operand1 = textTillNow;
            operation = '*';
            textBox1.Text = textTillNow + "*";
            textBox1.Text = string.Empty;
        }

        private void buttonDev_Click(object sender, EventArgs e)
        {
            string textTillNow = (string)textBox1.Text.Clone();

            operand1 = textTillNow;
            operation = '/';
            textBox1.Text = textTillNow + "/";
            textBox1.Text = string.Empty;
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            operand2 = textBox1.Text;

            double operand1Double;
            operand1Double= double.Parse(operand1);
            double operand2Double;
            operand2Double = double.Parse(operand2);

            switch (operation)
            {
                case '+':
                    result = (operand1Double + operand2Double).ToString();
                    break;

                case '-':
                    result = (operand1Double - operand2Double).ToString();
                    break;

                case '*':
                    result = (operand1Double * operand2Double).ToString();
                    break;

                case '/':
                    if (operand2Double != 0)
                    {
                        result = (operand1Double / operand2Double).ToString();
                    }
                    else
                    {
                        textBox1.Text = "Can't devide by zero.";
                    }
                    break;
            }

            textBox1.Text = result;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            operand2 = string.Empty;
        }

        private void buttonClearAll_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            operand1 = string.Empty;
            operand2 = string.Empty;
        }

        private void buttonSqrt_Click(object sender, EventArgs e)
        {
            string textTillNow = (string)textBox1.Text.Clone();

            operand1 = textTillNow;
            double operandDouble = double.Parse(operand1);

            result = Math.Sqrt(operandDouble).ToString();
            textBox1.Text = result;
        }

        private void buttonLog_Click(object sender, EventArgs e)
        {
            string textTillNow = (string)textBox1.Text.Clone();

            operand1 = textTillNow;
            double operandDouble = double.Parse(operand1);

            result = Math.Log(operandDouble, 2).ToString();
            textBox1.Text = result;
        }

        private void buttonLn_Click(object sender, EventArgs e)
        {
            string textTillNow = (string)textBox1.Text.Clone();

            operand1 = textTillNow;
            double operandDouble = double.Parse(operand1);

            result = Math.Log(operandDouble).ToString();
            textBox1.Text = result;
        }
    }
}
