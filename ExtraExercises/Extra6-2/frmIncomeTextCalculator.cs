using System;
using System.Windows.Forms;

/*
 *      In this exercise, you'll add a method 
 *      and another event handler to an income 
 *      tax calculator app.
 *      
 *      1.  Open the TaxCalculator project in the 
 *          ExtraStarts\Ch06 directory and display 
 *          the code for the form.
 *          
 *      2.  Code the declaration for a private 
 *          method named CalculateTax() that receives 
 *          the income amount and returns the tax amount.
 *          
 *      3.  Move the if-else statement in the 
 *          btnCalculate_Click() event handler to the 
 *          CalculateTax() method. 
 *          
 *          Then, declare a variable for the tax at 
 *          the beginning of this method, and return 
 *          the tax at the end of the method.
 *          
 *      4.  Modify the statement in the 
 *          btnCalculate_Click() event handler that 
 *          declares the tax variable so it gets its 
 *          value by calling the CalculateTax() method.
 *          
 *      5.  Create an event handler that clears the 
 *          Income Tax Owed text box if the user 
 *          changes the value in the Taxable Income 
 *          text box.
 *          
 *      6.  Test the app to be sure it still works 
 *          correctly. The income values of 8700 and 
 *          35150 should display taxable amounts of 
 *          870 and 3998.
 */

namespace Extra6_2
{
    public partial class frmIncomeTextCalculator : Form
    {
        public frmIncomeTextCalculator()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal income = decimal.Parse(txtTaxableIncome.Text.Trim());

            decimal taxDue = CalculateTax(income);

            //txtIncomeTaxOwed.Text = taxDue.ToString("c");
            txtIncomeTaxOwed.Text = ($"{taxDue:c}");
        }

        private decimal CalculateTax(decimal taxableIncome)
        {
            decimal taxDue = 0.00m;
            txtIncomeTaxOwed.Text = "";

            if (taxableIncome >= 578125)
            {
                taxDue = 174238.25m + ((taxableIncome - 578125m) * 0.37m);
            }
            else if (taxableIncome >= 231250)
            {
                taxDue = 52832.00m + ((taxableIncome - 231250m) * 0.35m);
            }
            else if (taxableIncome >= 182100)
            {
                taxDue = 37104.00m + ((taxableIncome - 182100) * 0.32m);
            }
            else if (taxableIncome >= 95375)
            {
                taxDue = 16290.00m + ((taxableIncome - 95375) * 0.24m);
            }
            else if (taxableIncome >= 44725)
            {
                taxDue = 5147.00m + ((taxableIncome - 44725) * 0.22m);
            }
            else if (taxableIncome >= 11000)
            {
                taxDue = 1100.00m + ((taxableIncome - 11000) * 0.12m);
            }
            else if (taxableIncome > 0)
            {
                taxDue = 0.00m + (taxableIncome * 0.10m);
            }

            return taxDue;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtIncomeTaxOwed.Text = "";
            txtTaxableIncome.Text = "";
            txtTaxableIncome.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ExitProgramOrNot();
        }

        private void ExitProgramOrNot()
        {
            DialogResult dialog = MessageBox.Show(
                        "Do You Really Want To Exit The Program?",
                        "EXIT NOW?",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void ShowErrorMessage(string msg, string title)
        {
            MessageBox.Show(msg, title,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
        }

        private void ClearIncomeTaxOwed(object sender, EventArgs e)
        {
            txtIncomeTaxOwed.Text = "";
        }
    }
}
