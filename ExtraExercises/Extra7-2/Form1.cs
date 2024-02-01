using System;
using System.Windows.Forms;

/*
 *      Extra 7-2 Add data validation to the simple 
 *      calculator.
 *      
 *      In this exercise, you'll add data validation to 
 *      the Simple Calculator form.
 *      
 *      1.  Open the SimpleCalculator project in the 
 *          ExtraStarts\Ch07\ SimpleCalculatorValidation 
 *          directory.
 *      
 *      2.  Code methods named IsPresent(), IsDecimal(), 
 *          and IsWithinRange() that work like the methods 
 *          described in chapter 7 of the book.
 *          
 *          
 *      3.  Code a method named IsOperator() that checks 
 *          that the string value that’s passed to it is 
 *          +, -, *, or /.
 *          
 *      4.  Code a method named IsValidOperation() that 
 *          checks for a divide by zero operation. 
 *          
 *          This method will need to check the value of the 
 *          Operand 2 text box and the value of the Operator 
 *          text box.
 *          
 *      5.  Code a method named IsValidData() that checks 
 *          that the Operand 1 and Operand 2 text boxes 
 *          contain a decimal value between 0 and 1,000,000, 
 *          that the Operator text box contains a valid 
 *          operator, and that the operation is valid.
 *          
 *      6.  Delete all the catch blocks from the try-catch 
 *          statement in the btnCalculate_Click() event 
 *          handler except for the one that catches any 
 *          exception.
 *          
 *          Then, add code to this event handler that 
 *          performs the calculation and displays the result
 *          only if the values of the text boxes are valid.
 *          
 *      7.  Test the app to be sure that all the data is 
 *          validated properly.
 */

namespace Extra7_2
{
    public partial class Form1 : Form
    {
        //  Declare and initialize program constants
        const decimal MINNUMBER =       0m;
        const decimal MAXNUMBER = 1000000m;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValidData())
                {
                    decimal operand1 = Convert.ToDecimal(txtOperand1.Text);
                    string operator1 = txtOperator1.Text;
                    decimal operand2 = Convert.ToDecimal(txtOperand2.Text);
                    PerformCalculation(operand1, operator1, operand2);
                }
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex.Message + "\n\n" +
                                ex.GetType().ToString() + "\n\n" +
                                ex.StackTrace,
                                "Exception Found");
            }           
        }

        private bool IsValidData()
        {
            bool success = true;
            string errorMessage = "";

            //  Validate the Operand1 text box
            errorMessage += IsPresent(txtOperand1.Text, "Operand1");
            errorMessage += IsDecimal(txtOperand1.Text, "Operand1");
            errorMessage += IsWithinRange(txtOperand1.Text, "Operand1",
                                          MINNUMBER, MAXNUMBER);

            //  Validate the Operator1 text box
            errorMessage += IsPresent(txtOperator1.Text, "Operator");
            errorMessage += IsOperator(txtOperator1.Text, "Operator");

            //  Validate the Operand2 text box
            errorMessage += IsPresent(txtOperand2.Text, "Operand2");
            errorMessage += IsDecimal(txtOperand2.Text, "Operand2");
            errorMessage += IsWithinRange(txtOperand2.Text, "Operand2",
                                          MINNUMBER, MAXNUMBER);
            errorMessage += IsValidOperation(txtOperand2.Text, "Operand2");

            if (errorMessage != "")
            {
                success = false;
                ShowErrorMessage(errorMessage, "Error Occurred");
            }

            return success;
        }

        private void PerformCalculation(decimal operand1, string operator1, decimal operand2)
        {
            decimal result = 0m;

            switch (operator1)
            {
                case "+":
                    result = operand1 + operand2;
                    break;

                case "-":
                    result = operand1 - operand2;
                    break;

                case "*":
                    result = operand1 * operand2;
                    break;

                case "/":
                    result = operand1 / operand2;
                    break;

                default:
                    break;
            }

            txtResult.Text = ($"{result:n4}");
        }

        private string IsPresent(string value, string name)
        {
            string msg = "";
            if (value == "")
            {
                msg = name + " is a required field.\n";
            }

            return msg;
        }

        private string IsOperator(string value, string name)
        {
            string msg = "";
            if (value != "+" && value != "-" &&
                value != "*" && value != "/")
            {
                msg = name + " must be a '+', '-', '*', or '/'.";
            }

            return msg;
        }

        private string IsDecimal(string value, string name)
        {
            string msg = "";
            if (!Decimal.TryParse(value, out _))
            {
                msg = name + " must be a valid decimal value.\n";
            }

            return msg;
        }

        private string IsWithinRange(string value, string name, decimal min, decimal max)
        {
            string msg = "";
            if (decimal.TryParse(value, out decimal number))
            {
                if (number < min || number > max)
                {
                    msg = name + " must be between " + min + " and " + max + ".\n";
                }
            }

            return msg;
        }

        private string IsValidOperation(string value, string name)
        {
            string operator1 = txtOperator1.Text.Trim();
            decimal operand2 = decimal.Parse(txtOperand2.Text.Trim());
            string msg = "";
            if (operator1 == "/" && operand2 == 0)
            {
                msg = name + " attempt to divide by 0.\n";
            }

            return msg;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtOperand1.Text = "";
            txtOperand2.Text = "";
            txtOperator1.Text = "";
            txtResult.Text = "";
            txtOperand1.Focus();
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

        private void ClearResultTextBox(object sender, EventArgs e)
        {
            txtResult.Text = "";
        }
    }
}
