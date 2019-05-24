using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChangeCalculator
{
    /*
    9/20/17

    Drew Watson 
    Jupin
    Fall 17
    Lab 2
    5-2

 */
    public partial class frmChangeCalculator : Form
    {
        public frmChangeCalculator()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            const int conQ = 25, conD = 10, conN = 5; 
            int change = 0, quaters = 0, dimes = 0, nickels = 0, pennies = 0;

            //Converts Change text box string into an int and places it into change variable
            change = Convert.ToInt32(txtChange.Text);

            //Tests change to see if it meets the 0-99 requirement 
            if (change >= 0 && change < 100)
            {

                /*
                  Gets the number of quarters by dividing change by 25
                  Works well due to precision lose from quaters being an int
                 */
                quaters = change / conQ;

                /*
                  Calculates the remaining change by subtracting the amount of
                  quarters that was in change and placing the product back in change
                 */  
                change = change - (quaters * conQ);

                /*
                  Gets the number of dime by dividing change by 10
                  Works well due to precision lose from dimes being an int
                 */
                dimes = change / conD;

                /*
                  Calculates the remaining change by subtracting the amount of
                  dimes that was in change and placing the product back in change
                 */
                change = change - (dimes * conD);

                /*
                  Gets the number of nickels by dividing change by 5
                  Works well due to precision lose from nickels being an int
                 */
                nickels = change / conN;
                /*
                  Calculates the remaining change by subtracting the amount of
                  nickles that was in change and placing the product back in change
                 */
                change = change - (nickels * conN);
           
                // What ever is left is pennies
                pennies = change; 

                //Converts and places the appropriate variables into the right text boxes
                txtQuaters.Text = Convert.ToString(quaters) ;
                txtDimes.Text = Convert.ToString(dimes);
                txtNickels.Text = Convert.ToString(nickels);
                txtPennies.Text = Convert.ToString(pennies);

                /*
                 Essentially this if statement works like a greedy algorithm and subtracts or eliminates the largest
                 element from the set and works its way down.
                */
            }

            // Else statement for if they place anything not in the range of 0-99 into change
            else
            {
                MessageBox.Show("Invalid input please try again");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
