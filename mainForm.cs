/*
 * Author Name : Dush Hewa 
 */
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
    public partial class frmCalculator : Form
    {
        public frmCalculator()
        {
            InitializeComponent();
        }
        //Declaring gobal variables
        double numTot = 0.0; 
        double nextNum = 0.0; 
        bool plusButtonClicked = false;
        bool minusButtonClicked = false;
        bool divideButtonClicked = false;
        bool multiplyButtonClicked = false;

        // These functins add the each button value 0 to 9 to the text feild 
        private void btnZero_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnZero.Text;
            lblFormula.Text += btnZero.Text;
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnOne.Text;
            lblFormula.Text += btnOne.Text;
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnTwo.Text;
            lblFormula.Text += btnTwo.Text;
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnThree.Text;
            lblFormula.Text += btnThree.Text;
        }

        // Continue till number nine

 
       }
       
        //when pressed it makes negative number positive and positive ones negative
        private void btnPlusMinus_Click_1(object sender, EventArgs e)
        {
            int lenDis = txtDisplay.Text.Length; // get the length of the display text feid
            int lenF = 0;
            if (lblFormula.Text !="")
            {
                lenF = lblFormula.Text.Length; // get the length label Formul Display
            }
            
            if (txtDisplay.Text.Contains("-"))
            {
                txtDisplay.Text = txtDisplay.Text.Remove(0, 1);
                if (lenF >0)
                {
                    lblFormula.Text = lblFormula.Text.Remove(lenF - lenDis, lenDis);
                }               
                lblFormula.Text += txtDisplay.Text;
            }
            else
            {               
                txtDisplay.Text = "-" + txtDisplay.Text;
                if (lenF > 0)
                {
                    lblFormula.Text = lblFormula.Text.Remove(lenF - lenDis, lenDis);
                }
                lblFormula.Text += txtDisplay.Text;
            }
            
        // Method for the Inverse button
        private void btbInv_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text != "")
            {
                numTot = double.Parse(txtDisplay.Text);
                if (numTot == 0)
                {
                    txtDisplay.Text = "Invalid Input";
                    return;
                }
                else
                {
                    txtDisplay.Text = MathLib.Algebraic.Inv(numTot).ToString();                   
                }
            }
            numTot = 0.0;
        }
        
        // Method for the Square Root button
        private void btnSqrt_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text != "")
            {
                numTot = double.Parse(txtDisplay.Text);
                if (numTot >= 0)
                {
                    txtDisplay.Text = MathLib.Algebraic.Sqrt(numTot).ToString();
                }
                else
                {
                    txtDisplay.Text = "Invalid Input";
                }
            }
            numTot = 0.0;
        }
        
        // Method for the Tan button
        private void btnTan_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text !="")
            {
                numTot = double.Parse(txtDisplay.Text);
                if (numTot == 90)
                {
                    txtDisplay.Text = "Invalid Input";
                    return;
                }else if (numTot == 180 || numTot == 360)
                {
                    txtDisplay.Text = "0";
                    return;
                }
                else
                {
                    txtDisplay.Text = MathLib.Trigonometric.Tan(numTot).ToString();
                }               
                numTot = 0.0;
            }          
        }
        
        // Similar to above add rest of the function eg Add, Sub, Div, Mul, Sin, Cos
        
        }
