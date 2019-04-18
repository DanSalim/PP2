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
        double resultValue = 0;
        string operationPerformed = "";
        bool isOperationPerformed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_click(object sender, EventArgs e)
        {
            if (textBox_Result.Text == "0" || (isOperationPerformed))
                textBox_Result.Clear();
            isOperationPerformed = false;
            Button button1 = (Button)sender;
            if(button1.Text == ".")
            {
                if (!textBox_Result.Text.Contains("."))
                    textBox_Result.Text = textBox_Result.Text + button1.Text;
            }else
            textBox_Result.Text = textBox_Result.Text + button1.Text;

        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button1 = (Button)sender;
            if (resultValue != 0)
            {
                equalbutton.PerformClick();
                operationPerformed = button1.Text;
                labelCurrentOperation.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;

            }
            else
            {
                operationPerformed = button1.Text;
                resultValue = double.Parse(textBox_Result.Text);
                labelCurrentOperation.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
        }

        private void ce_click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
        }

        private void c_click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
            resultValue = 0;
        }

        private void equalbutton_click(object sender, EventArgs e)
        {
            switch (operationPerformed)
            {
                case "+":
                    textBox_Result.Text = (resultValue + double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "-":
                    textBox_Result.Text = (resultValue - double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "*":
                    textBox_Result.Text = (resultValue * double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "/":
                    textBox_Result.Text = (resultValue / double.Parse(textBox_Result.Text)).ToString();
                    break;
                default:
                    break;
            }
            resultValue = double.Parse(textBox_Result.Text);
            labelCurrentOperation.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox_Result_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
