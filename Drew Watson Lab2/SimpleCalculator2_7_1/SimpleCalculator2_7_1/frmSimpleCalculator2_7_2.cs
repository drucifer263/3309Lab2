using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator2_7_1
{
    public partial class frmSimpleCalculator2_7_2 : Form
    {
        /*
	    9/20/17
        Drew Watson
        Jupin
        Fall 17
        Lab 2
        7-1       
        */
        
        //Global variables
        private decimal  operand1 = 0;
        private decimal operand2 = 0;
        private decimal result = 0;
        private string operator1 = "";

        public frmSimpleCalculator2_7_2()
        {
            InitializeComponent();
        }

        //Method calculates the result based on input from user
        private decimal calculate(decimal operand1, decimal operand2, string operator1)
        {

            //If statements determine what operation to perform
            if (operator1 == "+")
            {
                result = operand1 + operand2;
            }

            else if (operator1 == "-")
            {
                result = operand1 - operand2;
            }

            else if (operator1 == "*")
            {
                result = operand1 * operand2;
            }

            else
            {
                    result = operand1 / operand2;
            }
            return result;
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal endResult = 0;
            string resultString = "";

            try
            {
            
            //Does the conversion from text box to decimal
            operand1 = Convert.ToDecimal(txtOperand1.Text);
            operand2 = Convert.ToDecimal(txtOperand2.Text);
            operator1 = txtOperator.Text;
            
            //Places the decimal result into endresult variable
            endResult = calculate(operand1, operand2, operator1);
            
            //Formats the end result to a string and places that into a string and puts it into the result textbox
            resultString = endResult.ToString("f4");
            txtResult.Text = resultString;
            txtOperand1.Focus();
            }

            //Catches the format exception
            catch(FormatException ex )
            {
                MessageBox.Show(ex.Message + "\n \n" + ex.GetType().ToString() + "\n \n" + ex.StackTrace,"Exception");
            }

            //Catches the overflow exception
            catch(OverflowException ex)
            {
                MessageBox.Show(ex.Message + "\n \n" + ex.GetType().ToString() + "\n \n" + ex.StackTrace,"Exception");

            }

            //Catches the divide by zero exception
            catch (DivideByZeroException ex)
            {
                MessageBox.Show(ex.Message + "\n \n" + ex.GetType().ToString() + "\n \n" + ex.StackTrace, "Exception");

            }

            //Generic exception handler
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n \n" + ex.GetType().ToString() + "\n \n" + ex.StackTrace, "Exception");

            }

        }

        //Lazyly didnt create a single event handler due to VS2015 crashing on me if I tried to change it. I got too nervous to start alllll over again so I KEPT IT.
        private void txtOperand1_TextChanged(object sender, EventArgs e)
        {
            txtResult.Text = "";
            result = 0;
        }

        private void txtOperator_TextChanged(object sender, EventArgs e)
        {
            txtResult.Text = "";
            result = 0;
        }

        private void txtOperand2_TextChanged(object sender, EventArgs e)
        {
            txtResult.Text = "";
            result = 0;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
