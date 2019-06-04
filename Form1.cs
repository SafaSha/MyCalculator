using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Arithmetic;

namespace MyCalender
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double total1 = 0; 
        double total2 = 0; 
        bool plusButtonClicked = false;
        bool minusButtonClicked = false;
        bool divideButtonClicked = false;
        bool multiplyButtonClicked = false;

        //Add the text of the button to the textbox
        //show in the text box

        private void btnZero_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnZero.Text;
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnOne.Text;
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnTwo.Text;
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnThree.Text;
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnFour.Text;
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnFive.Text;
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnSix.Text;
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnSeven.Text;
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnEight.Text;
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnNine.Text;
        }

        //Clear all text in the textbox
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
        }

        //Add the text of the button to the textbox
        //show in the text box
        private void btnPoint_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnPoint.Text;
        }

        //convert string in the textbox to double
        //clear textbox
        //assign value true to plusButtonClicked 
        private void btnPlus_Click(object sender, EventArgs e)
        {
            total1 += double.Parse(txtDisplay.Text);
            txtDisplay.Clear();
            plusButtonClicked = true;
            minusButtonClicked = false;
            divideButtonClicked = false;
            multiplyButtonClicked = false;
         
        }

        //convert string in the textbox to double
        //clear textbox
        //assign value true to minusButtonClicked
        private void btnMinus_Click(object sender, EventArgs e)
        {
            total1 += double.Parse(txtDisplay.Text);
            txtDisplay.Clear();
            plusButtonClicked = false;
            minusButtonClicked = true;
            divideButtonClicked = false;
            multiplyButtonClicked = false;
        }

        //convert string in the textbox to double
        //clear textbox
        //assign value true to divideButtonClicked
        private void btnDivide_Click(object sender, EventArgs e)
        {
            total1 += double.Parse(txtDisplay.Text);
            txtDisplay.Clear();
            plusButtonClicked = false;
            minusButtonClicked = false;
            divideButtonClicked = true;
            multiplyButtonClicked = false;
        }

        //convert string in the textbox to double
        //clear textbox
        //assign value true to multiplyButtonClicked
        private void btnMultiply_Click(object sender, EventArgs e)
        {
            total1 += double.Parse(txtDisplay.Text);
            txtDisplay.Clear();
            plusButtonClicked = false;
            minusButtonClicked = false;
            divideButtonClicked = false;
            multiplyButtonClicked = true;
        }

        //Check which operation should be used
        //call the method related to operation and pass the string of textbox and temporary result
        //convert the final result to string
        //show the final string on the textbox
        //assign amount of zero to temporary result 
        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (plusButtonClicked == true)
            {
             
                total2=Arithmetic.Class1.Addition(txtDisplay.Text, total1);
            }
            else if (minusButtonClicked == true)
            {
               
                total2 = Arithmetic.Class1.Subtraction(txtDisplay.Text, total1);
            }
            else if (divideButtonClicked == true)
            {
              
                if(double.Parse(txtDisplay.Text)==0)
                {
                    MessageBox.Show("You cannot use zero, choose another number");
                }
                else
                total2 = Arithmetic.Class1.Division(txtDisplay.Text, total1);
            }
            else if (multiplyButtonClicked == true)
            {
                total2 = Arithmetic.Class1.Multiplication(txtDisplay.Text, total1);
            }
            txtDisplay.Text = total2.ToString();
            total1 = 0;
        }

        //call the squareRoot method and pass the string of the textbox to it
        private void btnSqrt_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = Algebraic.Algebraic.squareRoot(txtDisplay.Text);
        }


        private double SquareRoot(double x)
        {
          
            double result = Math.Sqrt(x);
            return result;
        }

        //show the message box
        //if user click on Ok, then exit the program
        //else return to program
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Really Quit?", "Exit", MessageBoxButtons.OKCancel) ==
DialogResult.OK)
            {
                Application.Exit();
            }
        }

        //Clear the textBox
        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
        }

        private void clearToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            txtDisplay.Clear();
        }

        //call the Tan method and pass the string of the textbox to it
        private void btnTan_Click(object sender, EventArgs e)
        {

            txtDisplay.Text = Trigonometric.Trigonometric.Tan(txtDisplay.Text);
        }

        //call the Sine method and pass the string of the textbox to it
        private void btnSin_Click(object sender, EventArgs e)
        {
           
            txtDisplay.Text = Trigonometric.Trigonometric.Sine(txtDisplay.Text);
        }

        //call the Cosine method and pass the string of the textbox to it
        private void btnCos_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = Trigonometric.Trigonometric.Cosine(txtDisplay.Text);
        }

        //call the cubeRoot method and pass the string of the textbox to it
        private void btnCube_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = Algebraic.Algebraic.cubeRoot(txtDisplay.Text);
        }

        //call the inverse method and pass the string of the textbox to it
        private void btnInverse_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = Algebraic.Algebraic.inverse(txtDisplay.Text);
        }
    }
}
