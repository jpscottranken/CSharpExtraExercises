using System;
using System.Windows.Forms;

/*
 *      In this exercise, you'll create a form 
 *      that accepts two operands and an operator 
 *      from the user and then performs the 
 *      requested operation.
 *      
 *      1.  Start a new project named SimpleCalculator 
 *          in the ExtraStarts\Ch06 directory.
 *          
 *      2.  Add labels, text boxes, and buttons to the 
 *          default form and set the properties of the 
 *          form and its controls so they appear as shown 
 *          above. 
 *          
 *          When the user presses the Enter key, the Click 
 *          event of the Calculate button should fire. 
 *          
 *          When the user presses the Esc key, the Click
 *          event of the Clear button should fire.
 *          
 *      3.  Code a private method named Calculate() that 
 *          performs the requested operation and returns 
 *          a decimal value. 
 *          
 *          This method should accept the following 
 *          arguments: 
 *          
 *          Argument Description decimal operand1:
 *          The value entered for the first operand. 
 *          
 *          Argument Description string operator1 
 *          One of these four operators: +, -, *, or /. 
 *          
 *          Argument Description decimal operand2 
 *          The value entered for the second operand.
 *          
 *      4.  Create an event handler for the Click event 
 *          of the Calculate button. 
 *          
 *          This event handler should get the two numbers 
 *          and operand the user enters, call the Calculate() 
 *          method to get the result of the calculation, 
 *          display the result rounded to four decimal places, 
 *          and move the focus to the Operand 1 text box.
 *          
 *      5.  Create an event handler for the Click event of the 
 *          Exit button that closes the form.
 *          
 *      6.  Create an event handler that clears the Result 
 *          text box if the user changes the text in any of 
 *          the other text boxes.
 *          
 *      7.  Test the app to be sure it works correctly.
 */

namespace Extra6_1
{
    public partial class Form1 : Form
    {
        //  Declare and initialize program constants
        const decimal MINNUMBER = 0m;
        const decimal MAXNUMBER = 1000000m;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal operand1 = 0;
            string operator1 = "";
            decimal operand2 = 0;

            Calculate(operand1, operator1, operand2);
        }

        private void Calculate(decimal operand1,
                               string operator1,
                               decimal operand2)
        {
            string operand1Str = txtOperand1.Text.Trim();
            string operatorStr = txtOperator1.Text.Trim();
            string operand2Str = txtOperand2.Text.Trim();

            try
            {
                operand1 = Convert.ToDecimal(txtOperand1.Text);
                operand2 = Convert.ToDecimal(txtOperand2.Text);
                operator1 = txtOperator1.Text;

                if (IsValidData())
                {
                    PerformCalculation(operand1, operator1, operand2);
                }
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex.Message + "\n\n" +
                                 ex.GetType().ToString() + "\n\n" +
                                 ex.StackTrace, "Exception Details");
            }
        }

        private bool IsValidData()
        {
            bool success = true;
            string errorMessage = "";

            // Validate the Operand1 text box
            errorMessage += IsPresent(txtOperand1.Text, "Operand1");
            errorMessage += IsDecimal(txtOperand1.Text, "Operand1");
            errorMessage += IsWithinRange(txtOperand1.Text, "Operand1", 
                                          MINNUMBER, MAXNUMBER);

            // Validate the Operator1 text box 
            errorMessage += IsPresent(txtOperator1.Text, "Operator");
            errorMessage += IsOperator(txtOperator1.Text, "Operator");

            // Validate the Operand2 text box
            errorMessage += IsPresent(txtOperand2.Text, "Operand2");
            errorMessage += IsDecimal(txtOperand2.Text, "Operand2");
            errorMessage += IsWithinRange(txtOperand2.Text, "Operand2",
                                         MINNUMBER, MAXNUMBER);
            if (errorMessage != "")
            {
                success = false;
                MessageBox.Show(errorMessage, "Entry Error");
            }

            return success;
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

        private string IsDecimal(string value, string name)
        {
            string msg = "";
            if (!decimal.TryParse(value, out _))
            {
                msg = name + " must be a valid decimal value.\n";
            }

            return msg;
        }

        private string IsOperator(string value, string name)
        {
            string opStr = txtOperator1.Text.Trim();
            string msg = "";
            if (opStr != "+" && opStr != "-" && 
                opStr != "*" && opStr != "/")
            {
                msg = name + " must be a '+', '-', '*', or '/'.\n";
            }

            return msg;
        }

        private string IsWithinRange(string value, string name, decimal min, decimal max)
        {
            string msg = "";
            if (Decimal.TryParse(value, out decimal number))
            {
                if (number < min || number > max)
                {
                    msg = name + " must be between " + min + " and " + max + ".\n";
                }
            }

            return msg;
        }

        private void PerformCalculation(decimal operand1,
                                        string operator1,
                                        decimal operand2)
        {
            decimal result = 0m;

            //MessageBox.Show("operand1 = " + operand1 + "\n" +
            //                "operand2 = " + operand2 + "\n" +
            //                "operator = " + operator1,
            //                "DETAILS");
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

            txtResult.Text = result.ToString("n4");
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
    }
}
