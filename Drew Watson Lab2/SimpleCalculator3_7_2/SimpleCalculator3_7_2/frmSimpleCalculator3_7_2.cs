using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator3_7_2
{
    /*
	    9/20/17
        Drew Watson
        Jupin
        Fall 17
        Lab 2
        7-2      
    */
    public partial class frmSimpleCalculator3_7_2 : Form
    {
        //Declared these global because it just made it easier
        decimal operand1 = 0;
        decimal operand2 = 0;
        decimal result = 0;
        string operator1 = "";

        public frmSimpleCalculator3_7_2()
        {
            InitializeComponent();
        }

        private decimal calculate(decimal operand1, decimal operand2, string operator1)
        {
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
            bool proceed = false;

            try
            {
                operand1 = Convert.ToDecimal(txtOperand1.Text);
                operand2 = Convert.ToDecimal(txtOperand2.Text);
                operator1 = txtOperator.Text;

                //isValue returns a true of false value and places it in proceed
                proceed = isValidData(txtOperand1, txtOperand2, txtOperator);

                //Checks to see if proceed is true and does the calculation if it is so
                if (proceed == true)
                {
                    //Calls calculate and places result  into end result
                    endResult = calculate(operand1, operand2, operator1);

                    //Formats, places result into a text box and changes focus
                    resultString = endResult.ToString("f4");
                    txtResult.Text = resultString;
                    txtOperand1.Focus();
                }
            }

            //Catch a generic exception
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.GetType().ToString() + "\n\n" + ex.StackTrace, "Exception");

            }
        }

        //I wasn't able to delete these text change event handlers and I dont want to crash VS again.
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

        //Checks to see if there is anything in the operator but the try catch will catch this exception
        private bool isPresent (TextBox txtOperand1, TextBox txtOperand2)
        {
            bool entry = false;

            if ((txtOperand1.Text != "") | (txtOperand2.Text == ""))
            {
                entry = true;
            }

            else
            {
                MessageBox.Show("You have to enter a value");
            }

            return entry;
            
        }

        //Checks to see if it is a decimal value
        private bool isDecimal(TextBox txtOperand1, TextBox txtOperand2)
        {
            bool isDecimal = false;
            decimal number = 0;

            if (Decimal.TryParse(txtOperand1.Text, out number) && (Decimal.TryParse(txtOperand2.Text, out number)))
            {
                isDecimal = true;
            }

            else
            {
                MessageBox.Show("Entry error, Not a decimal value.");
                isDecimal = false;
                txtOperand1.Focus();
            }

            return isDecimal;
        }

        // Checks to see if the operators are in range of 0-1000000 non inclusive 
        private bool isWithinRange(TextBox txtOperand1, TextBox txtOperand2)
        {
            bool inRange = true;
            decimal rangeNumber1 = 0, rangeNumber2 = 0, min = 0, max = 1000000;

            rangeNumber1 = Convert.ToDecimal(txtOperand1.Text);
            rangeNumber2 = Convert.ToDecimal(txtOperand2.Text);

            if ((rangeNumber1 < min) | (rangeNumber1 >= max))
            {
                inRange = false;
                MessageBox.Show("Entry error, Operator 1 not between 0 and 1,000,000 (non-inclusive).");
                txtOperand1.Focus();

            }

            else if ((rangeNumber2 < min) | (rangeNumber2 >= max))
            {
                inRange = false;
                MessageBox.Show("Entry error, Operator 2 not between 0 and 1,000,000 (non-inclusive).");
                txtOperand2.Focus();
            }

            return inRange;

        }

        //Checks to see if there is a valid operator

        private bool isOperator(TextBox sentBox)
        {
            Boolean isItThere = false;

            if ((sentBox.Text == "*") | (sentBox.Text == "/") | (sentBox.Text == "+") | (sentBox.Text == "-"))
            {
                isItThere = true;
            }

            else
            {
                MessageBox.Show("Entry error, Not a valid operator.");
                txtOperator.Focus();
            }

            return isItThere;
        }

        //Checks to make sure the data is valid from the previous methods
        private bool isValidData(TextBox txtOperand1, TextBox txtOperand2, TextBox txtOperator)
        {
            bool valid = false;
            
            if(isOperator(txtOperator) &&
               isDecimal(txtOperand1, txtOperand2)  &&
               isWithinRange(txtOperand1, txtOperand2))
            {
                valid = true;
            }
            else
            {
                MessageBox.Show("Entry error, Data not  valid.");
                txtOperand1.Focus();
                valid = false;
            }

            return valid;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
