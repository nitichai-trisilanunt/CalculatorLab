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
        private void lblDisplay_Click(object sender, EventArgs e)
        {

        }
       
        private void btnNumber_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text.Length <= 7)
            {
                if (lblDisplay.Text == "0" || lblDisplay.Text == "ERROR!")
                {
                    lblDisplay.Text = ((Button)sender).Text;
                }
                else
                {
                    lblDisplay.Text = lblDisplay.Text + ((Button)sender).Text;
                }
            }
        }
        //properties -> event -> change the name to btnNumber_Click/btnOperator_click

        double n;
        double n1;
        double n2;
        string TheFirstOperator;
        int countDot = 0;

        private void btnOperator_click(object sender, EventArgs e)
        {
            TheFirstOperator = ((Button)sender).Text;
            n1 = double.Parse(lblDisplay.Text);
            lblDisplay.Text = "0";
            countDot = 0;
        }

        private void btnPercent_click(object sender, EventArgs e)
        {
            n = double.Parse(lblDisplay.Text);
            if(n1 == 0)
            {
                n = n / 100;
            }
            else
            {
                n = (n / 100) * n1;
            }

            if (n % 1 == 0)
            {
                countDot = 0;
            }
            else countDot = 1;
            lblDisplay.Text = n.ToString();
            
        }

        private void btnSign_click(object sender, EventArgs e)
        {
            n = double.Parse(lblDisplay.Text);
            n = -n;
            lblDisplay.Text = n.ToString();
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            n2 = double.Parse(lblDisplay.Text);
            if (TheFirstOperator == "+")
            {
                n1 = n1 + n2;
            }
            else if (TheFirstOperator == "-")
            {
                n1 = n1 - n2;
            }
            else if (TheFirstOperator == "x")
            {
                n1 = n1 * n2;
            }
            else if (TheFirstOperator == "÷")
            {
                n1 = n1 / n2;
            }
            lblDisplay.Text = n1.ToString();
            if (lblDisplay.Text.Length > 7)
            {
                lblDisplay.Text = "ERROR!";
            }
            if (n1 % 1 == 0)
            {
                countDot = 0;
            }
            else countDot = 1;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "0";
            n1 = 0;
            n2 = 0;
            countDot = 0;
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if (countDot==0)
            {
                lblDisplay.Text = lblDisplay.Text + ".";
                countDot = 1;
            }
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            if(lblDisplay.Text.Length == 1)
            {
                lblDisplay.Text = "0";
            }
            else
            {
                lblDisplay.Text = lblDisplay.Text.Remove(lblDisplay.Text.Length - 1);
            }
            
        }

    
    }

}