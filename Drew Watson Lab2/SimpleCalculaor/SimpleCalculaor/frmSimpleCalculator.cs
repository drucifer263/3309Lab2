using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculaor
{
    /*
	    9/20/17
        Drew Watson
        Jupin
        Fall 17
        Lab 2
        6-1       
    */

    public partial class frmSimpleCalculator : Form
    {
        //Global variables 
        decimal operand1 = 0;
        decimal operand2 = 0;
        decimal result = 0;
        string operator1 ="";

        public frmSimpleCalculator()
        {
            InitializeComponent();
        }

        // Method calculates the number a user enters and returns a decimal
        private decimal Calculate(decimal operand1, decimal operand2, string operator1)
        {

            /*
             * I used if statements instead of switches just because it was the first thing i thought of.
             * I can always go back and change it.
             * The if statements check the operator to see which type of calculation should be performed 
             */
            if(operator1 == "+")
            {
                result = operand1 + operand2;
            }

            else if(operator1 == "-")
            {
                result = operand1 - operand2;
            }

            else if (operator1 =="*")
            {
                result = operand1 * operand2;
            }

            // Check to see if the second operand is a zero because i entered it more than once and it got to me
            else
            {
                if (operand2 > 0)
                {
                    result = operand1 / operand2;
                }

                else
                {
                    MessageBox.Show("Can not divide by zero, try again.");
                }
            }

            // Returns the end result of the calculation
            return result;
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal endResult = 0;
            string resultString = "";

            // Converts and places the input from the text box to decimals variables
            operand1 = Convert.ToDecimal(txtOperand1.Text);
            operand2 = Convert.ToDecimal(txtOperand2.Text);
            
            //Takes the operator 
            operator1 = txtOperator.Text;

            //Calls the calculate method and places decimal result into end result variable
            endResult = Calculate(operand1,operand2,operator1);

            /*  
              Formats the end result variable for four decimal places and place it into result text box 
              Finally it changes focus to the operand 1 text box
            */
            resultString = endResult.ToString("f4");
            txtResult.Text = resultString;
            txtOperand1.Focus();
        }
        
        /*
         I got lazy and just created a text change for each box instead of linking one generic text change for all of the text boxes
         I get nervous when deleting things due to them being link a certain way and it crashed my program a few times so I kept it.
         I tried deleting it like the book says but got frustrated and stopped.
        */
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
