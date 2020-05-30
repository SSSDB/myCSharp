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
        public Form1()
        {
            InitializeComponent();
        }
        double num1, num2, result;
        string op;
        private void btn_calculator_Click(object sender, EventArgs e)
        {
            result = double.NaN;
            switch (op)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    break;
                default:
                    break;
            }
            textBox_result.Text = Convert.ToString(result);
        }
        private void textBox_num1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                num1 = Convert.ToDouble(textBox_num1.Text);
            }
            catch (FormatException)
            {             
            }
        }

        private void textBox_result_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_num2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                num2 = Convert.ToDouble(textBox_num2.Text);
            }
            catch (FormatException)
            {
            }
        }
        private void comboBox_operator_SelectedIndexChanged(object sender, EventArgs e)
        {
            op = comboBox_operator.Text;
        }
    }
}
   
