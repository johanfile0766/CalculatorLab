using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPE200Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        float number;
        float result;
        string symbol;


        private void btn9_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0")
            {
                lblDisplay.Text = "9";
            }
            else if (lblDisplay.Text.Length == 8)
            {
                lblDisplay.Text = "99999999";
            }
            else
            {
                lblDisplay.Text = lblDisplay.Text + "9";
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {

            if (lblDisplay.Text == "0")
            {
                lblDisplay.Text = "1";
            }
            else if (lblDisplay.Text.Length == 8)
            {
                lblDisplay.Text = "11111111";
            }
            else
            {
                lblDisplay.Text = lblDisplay.Text + "1";
            }

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0")
            {
                lblDisplay.Text = "2";
            }
            else if (lblDisplay.Text.Length == 8)
            {
                lblDisplay.Text = "22222222";
            }
            else
            {
                lblDisplay.Text = lblDisplay.Text + "2";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {

            if (lblDisplay.Text == "0")
            {
                lblDisplay.Text = "3";
            }
            else if (lblDisplay.Text.Length == 8)
            {
                lblDisplay.Text = "33333333";
            }
            else
            {
                lblDisplay.Text = lblDisplay.Text + "3";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {

            if (lblDisplay.Text == "0")
            {
                lblDisplay.Text = "6";
            }
            else if (lblDisplay.Text.Length == 8)
            {
                lblDisplay.Text = "66666666";
            }
            else
            {
                lblDisplay.Text = lblDisplay.Text + "6";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {

            if (lblDisplay.Text == "0")
            {
                lblDisplay.Text = "5";
            }
            else if (lblDisplay.Text.Length == 8)
            {
                lblDisplay.Text = "55555555";
            }
            else
            {
                lblDisplay.Text = lblDisplay.Text + "5";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {

            if (lblDisplay.Text == "0")
            {
                lblDisplay.Text = "4";
            }
            else if (lblDisplay.Text.Length == 8)
            {
                lblDisplay.Text = "44444444";
            }
            else
            {
                lblDisplay.Text = lblDisplay.Text + "4";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {

            if (lblDisplay.Text == "0")
            {
                lblDisplay.Text = "8";
            }
            else if (lblDisplay.Text.Length == 8)
            {
                lblDisplay.Text = "88888888";
            }
            else
            {
                lblDisplay.Text = lblDisplay.Text + "8";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {

            if (lblDisplay.Text == "0")
            {
                lblDisplay.Text = "7";
            }
            else if (lblDisplay.Text.Length == 8)
            {
                lblDisplay.Text = "77777777";
            }
            else
            {
                lblDisplay.Text = lblDisplay.Text + "7";
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0")
            {
                lblDisplay.Text = "0";
            }
            else if (lblDisplay.Text.Length == 8)
            {
                lblDisplay.Text = "0000000";
            }
            else
            {
                lblDisplay.Text = lblDisplay.Text + "0";


            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = null;
            lblDisplay.Text = "0";
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {

            number = float.Parse(lblDisplay.Text);
            lblDisplay.Text = "0";
            symbol = "+";

            // result = result + float.Parse(lblDisplay.Text);
            // lblDisplay.Text = result.ToString();
            // result = 0;
        }
        private void btnMinus_Click(object sender, EventArgs e)
        {
            number = float.Parse(lblDisplay.Text);
            lblDisplay.Text = "0";
            symbol = "-";
        }


        private void btnEqual_Click(object sender, EventArgs e)
        {


            if (symbol == "+")
            {
                if (lblDisplay.Text.Length < 8)
                {
                    result = (number + float.Parse(lblDisplay.Text));
                    if (result >= 1e8)
                    {
                        lblDisplay.Text = "error";
                    }
                    else
                    {
                        lblDisplay.Text = Convert.ToString(result);
                        number = 0;
                    }
                }
                if (lblDisplay.Text.Length > 8)
                {
                    lblDisplay.Text = "error";
                }
            }
            if (symbol == "-")
            {
                result = (number - float.Parse(lblDisplay.Text));
                if (result < 0)
                {
                    lblDisplay.Text = "error";
                }
                else
                {
                    lblDisplay.Text = Convert.ToString(result);
                    number = 0;
                }
                if (symbol == "X")
                {
                    if (lblDisplay.Text.Length < 8)
                    {
                        result = (number * float.Parse(lblDisplay.Text));
                        if (result >= 1e8)
                        {
                            lblDisplay.Text = "error";
                        }
                        else
                        {
                            lblDisplay.Text = Convert.ToString(result);
                            number = 0;
                        }
                    }

                }
                if (symbol == "/")
                { if (lblDisplay.Text == "0")
                    {
                        lblDisplay.Text = "error";
                         }
                    else {
                        result = (number / float.Parse(lblDisplay.Text));
                    }
                    lblDisplay.Text = Convert.ToString(result);
                    number = 0;
                }

                if (symbol == "%")
                {
                    result = ((number * float.Parse(lblDisplay.Text)) / 100);
                    lblDisplay.Text = Convert.ToString(result);
                    number = 0;
                }
            }
        }
        private void btnMultiply_Click(object sender, EventArgs e)
        {
            number = float.Parse(lblDisplay.Text);
            lblDisplay.Text = "0";
            symbol = "X";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            number = float.Parse(lblDisplay.Text);
            lblDisplay.Text = "0";
            symbol = "/";
        }

        private void btnPercent_Click(object sender, EventArgs e)
        {
            number = float.Parse(lblDisplay.Text);
            lblDisplay.Text = "0";
            symbol = "%";
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0")
            {
                lblDisplay.Text = "0.";

            }
            if (symbol == ".")
            {
                lblDisplay.Text = lblDisplay.Text;
            }
            else
            {
                lblDisplay.Text = lblDisplay.Text + ".";
                symbol = ".";
            }
        }
    }
}
