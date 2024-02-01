
/*
 *  Extra 5-2 Calculate change
 *  ==========================
 *  In this exercise, you'll develop a form 
 *  that tells how many quarters, dimes, nickels, 
 *  and pennies are needed to make change for 
 *  any amount of change from 0 through 99 cents.
 *  
 *  One way to get the results is to use the
 *  division and modulus operators and to cast 
 *  the result of each division to an integer.
 *  
 *  1.	GUI Only:
 *		Create an event handler for the Click event 
 *		of the Calculate button. Then, write the code 
 *		for calculating and displaying the number of 
 *		quarters, dimes, nickels, and pennies that 
 *		are needed for the change amount a user enters.
 *		
 *		This code should provide for integer entries, 
 *		but you can assume that the user will enter 
 *		valid integer values.
 *		
 *		GUI Only:
 *	2.	Create an event handler for the Click event 
 *	    of the Exit button that closes the form.
 *	    
 *	3.  Test the app to be sure it works correctly.
 */

namespace Extra5_2bGUI
{
    public partial class frmChangeCalculator : Form
    {
        //  Declare and initialize program constants
        const int MINNUMBER = 1;
        const int MAXNUMBER = 99;
        const int QUARTERVALUE = 25;
        const int DIMEVALUE = 10;
        const int NICKELVALUE = 5;

        //  Declare and initialize class variables
        static int number = 0;

        public frmChangeCalculator()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            CalculateChange();
        }

        private void CalculateChange()
        {
            InputNumber();
            CalculateChangeAmounts();
        }

        private void InputNumber()
        {
            bool result;
            string numberStr = txtChangeDue.Text;

            if (numberStr == "")
            {
                ShowErrorMessage("You Must Input a Number. Please Try Again.",
                                 "NO VALUE INPUTTED");
                txtChangeDue.Focus();
                return;
            }

            result = int.TryParse(numberStr, out number);

            if (!result || number < MINNUMBER || number > MAXNUMBER)
            {
                ShowErrorMessage("Non-Numeric or Number Out Of Range. Please Try Again.",
                                 "INVALID OR OUT-OF-RANGE INPUT");
                txtChangeDue.Text = "";
                txtChangeDue.Focus();
                return;
            }
        }

        private void CalculateChangeAmounts()
        {
            int numQuarters = 0;
            int numDimes = 0;
            int numNickels = 0;
            int numPennies = 0;
            int whatsLeft = 0;

            numQuarters = number / QUARTERVALUE;
            whatsLeft = number % QUARTERVALUE;

            numDimes = whatsLeft / DIMEVALUE;
            whatsLeft = whatsLeft % DIMEVALUE;

            numNickels = whatsLeft / NICKELVALUE;
            numPennies = whatsLeft % NICKELVALUE;

            txtChangeDue.Text = ($"{number}");
            txtQuarters.Text  = ($"{numQuarters}");
            txtDimes.Text     = ($"{numDimes}");
            txtNickels.Text   = ($"{numNickels}");
            txtPennies.Text   = ($"{numPennies}");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtChangeDue.Text = "";
            txtQuarters.Text = "";
            txtDimes.Text = "";
            txtNickels.Text = "";
            txtPennies.Text = "";
            txtChangeDue.Focus();
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
    }
}
