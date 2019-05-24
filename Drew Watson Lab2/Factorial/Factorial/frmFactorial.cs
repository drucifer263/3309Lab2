using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
    9/20/17

    Drew Watson 
    Jupin
    Fall 17
    Lab 2
    5-1
    
 */
namespace Factorial
{
    public partial class frmFactorial : Form
    {
        public frmFactorial()
        {
            InitializeComponent();
        }

        private void frmFactorial_Load(object sender, EventArgs e)
        {
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            long number = 0;
            long factorial = 0;
            
            // Takes the string from the number box and converts it to a long
            number = Convert.ToInt64(txtNumber.Text);

            /*
              For loop that decrements variable i.
              i starts at one less than number the user enters and is decremented until it reaches 1.
              Everytime it is decremented it is multiplied by the number variable and the product is then
              added back into number.
             */
            for (long i = number-1; i>=1; i--)
            {
                number = number * i;
            }

            // Places the end result of the above for loop into factorial.
            factorial = number;
            
            //Factorial variable is then formated by ToString
            txtFactorial.Text = factorial.ToString("n0");

            //Moves the focus back to number text box
            txtNumber.Focus();
        }
    }
}
