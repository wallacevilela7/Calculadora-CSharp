using System.CodeDom.Compiler;
using System.Runtime.Intrinsics;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        private double v1, v2 = 0;
        private String op = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textResult.Text.Length != 0)
            {
            double inv = (-1) * double.Parse(textResult.Text);
            textResult.Text = inv.ToString("F2");

            }
            else
            {
                textResult.Text = "Informe um valor!";
            }
            textResult.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String value;
            value = textResult.Text;
            textResult.Text = value + "0";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            v1 = 0;
            v2 = 0;
            op = "";
            textResult.Text = "";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            String value;
            value = textResult.Text;
            textResult.Text = value + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            String value;
            value = textResult.Text;
            textResult.Text = value + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            String value;
            value = textResult.Text;
            textResult.Text = value + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            String value;
            value = textResult.Text;
            textResult.Text = value + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            String value;
            value = textResult.Text;
            textResult.Text = value + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            String value;
            value = textResult.Text;
            textResult.Text = value + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            String value;
            value = textResult.Text;
            textResult.Text = value + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            String value;
            value = textResult.Text;
            textResult.Text = value + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            String value;
            value = textResult.Text;
            textResult.Text = value + "9";
        }

        private void btnPonto_Click(object sender, EventArgs e)
        {
            String value = textResult.Text;
            if (value.Length != 0)
            {
                if (value.Contains(",") == false)
                {
                    textResult.Text = value + ",";
                }
            }
            else
            {
                textResult.Text = value + "0,";
            }
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            if (v1 == 0)
            {
                v1 = double.Parse(textResult.Text);
            }
            else
            {
                v1 = v1 + double.Parse(textResult.Text);
            }
            op = "+";
            textResult.Text = "";
        }


        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            if (v1 == 0)
            {
                v1 = double.Parse(textResult.Text);
            }
            else
            {
                v1 = v1 + double.Parse(textResult.Text);
            }
            op = "-";
            textResult.Text = "";
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            if (v1 == 0)
            {
                v1 = double.Parse(textResult.Text);
            }
            else
            {
                v1 = v1 + double.Parse(textResult.Text);
            }
            op = "*";
            textResult.Text = "";
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            if (v1 == 0)
            {
                v1 = double.Parse(textResult.Text);
            }
            else
            {
                v1 = v1 + double.Parse(textResult.Text);
            }
            op = "/";
            textResult.Text = "";
        }
        private void btnResult_Click(object sender, EventArgs e)
        {
            v2 = double.Parse(textResult.Text);

            switch (op)
            {
                case "+":
                    textResult.Text = (v1 + v2).ToString("F2");
                    break;
                case "-":
                    textResult.Text = (v1 - v2).ToString("F2");
                    break;
                case "*":
                    textResult.Text = (v1 * v2).ToString("F2");
                    break;
                case "/":
                    if (v2 == 0)
                    {
                        textResult.Text = "Não é possível dividir por zero";
                        break;
                    }
                    else
                    {
                        textResult.Text = (v1 / v2).ToString("F2");
                    }
                    break;
                default:
                    break;
            }

            v1 = 0;
            v2 = 0;
            op = "";
        }

        private void btnPerc_Click(object sender, EventArgs e)
        {
            double pct = double.Parse(textResult.Text) / 100;
            textResult.Text = pct.ToString("F2");
        }

        private void btn1porX_Click(object sender, EventArgs e)
        {
            double v = 1.00 / double.Parse(textResult.Text);
            textResult.Text = v.ToString("F2");
        }
    }
}