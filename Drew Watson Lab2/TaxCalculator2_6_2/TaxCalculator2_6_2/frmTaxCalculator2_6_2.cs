using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaxCalculator2_6_2
{
    /*
	    9/20/17
        Drew Watson
        Jupin
        Fall 17
        Lab 2
        6-2       
    */
    public partial class frmTaxCalculator2_6_2 : Form
    {
        //Constance because they never change and I refer to them later so i made them global
        private const double taxableIncome1 = 9225, taxableIncome2 = 37450, taxableIncome3 = 90750, taxableIncome4 = 189300, taxableIncome5 = 411500, taxableIncome6 = 413200;
        private const double taxBracket1 = .10, taxBracket2 = .15, taxBracket3 = .25, taxBracket4 = .28, taxBracket5 = .33, taxBracket6 = .35, taxBracket7 = .396;
        private const double taxPlus0 = 0, taxPlus1 = 922.50, taxPlus2 = 5156.25, taxPlus3 = 18481.25, taxPlus4 = 46075.25, taxPlus5 = 119401.25, taxPlus6 = 119996.25;

        // When I change the text box i want this to be zero and so I can easily refer to it in the text change later if its global
        private double taxOwed = 0;

        public frmTaxCalculator2_6_2()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
           
            double taxIncome = 0;
            
            //Converts the input to a double essentially
            taxIncome = Convert.ToDouble(txtTaxableIncome.Text);
            
            //Calls calculate tax and places it into a tax owed variable
            taxOwed = calculateTax(taxIncome);

            //Converts and places tax owed into a text box
            txtIncomeTaxOwed.Text = Convert.ToString(taxOwed);
        }

        private double calculateTax(double income)
        {
            //For what ever reason they wanted a variable for the tax declared here and that same thing return in the end, tax amount
            double tempTax = 0, totalTax = 0, taxAmount = 0, taxIncome = 0;
            
            // Sets taxincome to the variable that is being passed to the method through income
            taxIncome = income;

            // Does all the calculations like the previous excersise 5-3
            //Subtracts previous tiered tax, taxes leftovers in the new bracket, adds the previously lower tiered taxed income to the upper/current teir income together
            if (taxIncome >= 0 && taxIncome <= taxableIncome1)
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

            
            taxAmount = totalTax;
            return taxAmount;
        }

        // Event handler clears text box taxable income and tax owed if text box  is changed
        private void txtTaxableIncome_TextChanged(object sender, EventArgs e)
        {
            txtIncomeTaxOwed.Text="";
            taxOwed = 0;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
