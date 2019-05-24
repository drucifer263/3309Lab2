using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaxCalculator
{
    /*
        9/20/17
        Drew Watson
        Jupin
        Fall 17
        Lab 2
        5-3        
    */
    public partial class frmTaxCalculator : Form
    {
        public frmTaxCalculator()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // I was origanially going to make an algorithm that would calculate it for any bracket easily but I got lazy hence all the constance
            const double taxableIncome1 = 9225, taxableIncome2 = 37450, taxableIncome3 = 90750, taxableIncome4 =189300 , taxableIncome5 = 411500, taxableIncome6 = 413200;
            const double taxBracket1 =.10, taxBracket2 = .15, taxBracket3 = .25, taxBracket4 = .28, taxBracket5 = .33, taxBracket6 = .35, taxBracket7 = .396;
            const double taxPlus0 = 0, taxPlus1 = 922.50, taxPlus2 = 5156.25, taxPlus3 = 18481.25, taxPlus4 = 46075.25, taxPlus5 = 119401.25, taxPlus6 = 119996.25;

            double taxIncome = 0, taxOwed = 0;
            double tempTax = 0,totalTax =0;

            // Converts the user input from text box into a double called taxIncome
            taxIncome = Convert.ToDouble(txtTaxableIncome.Text);

            /*
             If else statements that checks each of the tax bracket criteria
             Then it subtracts the lower tier taxable income from the present bracket and places it into temp tax.
             Next it takes the temp tax income  and multiplies it by the appropriate tax percentage for that bracket.
             Finally it  adds temp tax income with the previous taxed income and places it into a total tax variable.
             The only exception is the first bracket since all you neeed to do is add zero. 
             */
            if (taxIncome >= 0 && taxIncome<=taxableIncome1)
            {
                totalTax = (taxIncome * taxBracket1) + taxPlus0;
            }

            else if (taxIncome > taxableIncome1 && taxIncome <= taxableIncome2)
            {
                tempTax = taxIncome - taxableIncome1;
                tempTax = tempTax * taxBracket2;
                totalTax = tempTax + taxPlus1;
            }

            else if (taxIncome > taxableIncome2 && taxIncome <= taxableIncome3)
            {
                tempTax = taxIncome - taxableIncome2;
                tempTax = tempTax * taxBracket3;
                totalTax = tempTax + taxPlus2;
            }

            else if (taxIncome > taxableIncome3 && taxIncome <= taxableIncome4)
            {
                tempTax = taxIncome - taxableIncome3;
                tempTax = tempTax * taxBracket4;
                totalTax = tempTax + taxPlus3;
            }

            else if (taxIncome > taxableIncome4 && taxIncome <= taxableIncome5)
            {
                tempTax = taxIncome - taxableIncome4;
                tempTax = tempTax * taxBracket5;
                totalTax = tempTax + taxPlus4;
            }

            else if (taxIncome > taxableIncome5 && taxIncome <= taxableIncome6)
            {
                tempTax = taxIncome - taxableIncome5;
                tempTax = tempTax * taxBracket6;
                totalTax = tempTax + taxPlus5;
            }

            else
            {
                tempTax = taxIncome - taxableIncome6;
                tempTax = tempTax * taxBracket7;
                totalTax = tempTax + taxPlus6;
            }

            // Places the total tax into a tac owed variable and then converts that to a string 
            // to be placed into tax owed text box
            taxOwed = totalTax;
            txtIncomeTaxOwed.Text = Convert.ToString(taxOwed);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
