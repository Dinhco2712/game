using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace phandinhco2122110336
{
    public partial class bai11 : Form
    {
        decimal memory = 0;
        decimal workingMemory = 0;
        string opr = "";
        public bai11()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            if ((char.IsDigit(bt.Text, 0) & bt.Text.Length == 1) || bt.Text == ".")
            {
                txtDisplay.Text += bt.Text;
            }
            else if (bt.Text == "*" || bt.Text == "/" || bt.Text == "+" || bt.Text == "-")
            {
                opr = bt.Text;
                workingMemory = decimal.Parse(txtDisplay.Text);
                txtDisplay.Clear();
            }
            else if (bt.Text == "=")
            {
                decimal seconValue = decimal.Parse(txtDisplay.Text);
                switch (opr)
                {
                    case "+":
                        {
                            txtDisplay.Text = (workingMemory + seconValue).ToString();
                            break;
                        }
                    case "-":
                        {
                            txtDisplay.Text = (workingMemory - seconValue).ToString();
                            break;
                        }
                    case "*":
                        {
                            txtDisplay.Text = (workingMemory * seconValue).ToString();
                            break;
                        }
                    case "/":
                        {

                            txtDisplay.Text = (workingMemory / seconValue).ToString();
                            break;
                        }
                }
            }
            else if (bt.Text == "±")
            {
                decimal currVal = decimal.Parse(txtDisplay.Text);
                currVal = -currVal;
                txtDisplay.Text = currVal.ToString();
            }
            else if (bt.Text == "√")
            {
                decimal currVal = decimal.Parse(txtDisplay.Text);
                if (currVal > 0)
                {
                    currVal = (decimal)Math.Sqrt((double)currVal);
                    txtDisplay.Text = currVal.ToString();
                }
                else
                {
                    //MessageBox.Show("Khong the thuc hien phep tinh");
                    btSqrt.Enabled = false;
                }
                btSqrt.Enabled = true;
            }
            else if (bt.Text == "%")
            {
                decimal currVal = decimal.Parse(txtDisplay.Text);
                currVal = currVal / 100;
                txtDisplay.Text = currVal.ToString();
            }
            else if (bt.Text == "1/x")
            {
                decimal currVal = decimal.Parse(txtDisplay.Text);
                if (currVal != 0)
                {
                    currVal = 1 / currVal;
                    txtDisplay.Text = currVal.ToString();
                }
                else
                {
                    //MessageBox.Show("Khong the thuc hien phep tinh");
                    this.btPartX.Enabled = false;
                }
                this.btPartX.Enabled = true;


            }
            else if (bt.Text == "←")
            {
                if (txtDisplay.TextLength != 0)
                {
                    txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.TextLength - 1);
                }
            }
            else if (bt.Text == "MC")
            {
                memory = 0;
            }
            else if (bt.Text == "MR")
            {
                txtDisplay.Text = memory.ToString();
            }
            else if (bt.Text == "MS")
            {
                memory = decimal.Parse(txtDisplay.Text);
                txtDisplay.Clear();
            }
            else if (bt.Text == "M+")
            {
                memory += decimal.Parse(txtDisplay.Text);
            }
            else if (bt.Text == "M-")
            {
                memory -= decimal.Parse(txtDisplay.Text);
            }
            else if (bt.Text == "C")
            {
                workingMemory = 0;
                opr = "";
                txtDisplay.Clear();
            }
            else if (bt.Text == "CE")
            {
                txtDisplay.Clear();
            }
        }

        private void txtDisplay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


    }
}
