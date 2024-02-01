using System;
using System.Windows.Forms;

/*
 *      Extra 7-1 Add exception handling to the 
 *      simple calculator.
 *      
 *      In this exercise, you'll add exception 
 *      handling to the Simple Calculator form.
 *      
 *      1.  Open the SimpleCalculator project in the 
 *          ExtraStarts\Ch07\ SimpleCalculatorExceptionHandling 
 *          directory.
 *          
 *      2.  Add a try-catch statement in the 
 *          btnCalculate_Click() event handler that will 
 *          catch any exceptions that occur when the 
 *          statements in that event handler are executed. 
 *          
 *          If an exception occurs, display a dialog with 
 *          the error message, the type of error, and a 
 *          stack trace. 
 *          
 *          Test the app by entering a nonnumeric value for 
 *          one of the operands.
 *          
 *      3.  Add three additional catch blocks to the try-catch 
 *          statement that will catch a FormatException, an 
 *          OverflowException, and a DivideByZeroException. 
 *          
 *          These catch blocks should display a dialog with an 
 *          appropriate error message.
 *          
 *      4.  Test the app again by entering a nonnumeric value for 
 *          one of the operands. Then, enter 0 for the second 
 *          operand as shown above to see what happens.
 */

namespace Extra7_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal operand1 = 0m;
            decimal operand2 = 0m;
            string operator1 = "";
            decimal result = 0m;

            try
            {
                operand1 = Convert.ToDecimal(txtOperand1.Text.Trim());
                operator1 = txtOperator1.Text.Trim();
                operand2 = Convert.ToDecimal(txtOperand2.Text.Trim());

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
            catch (FormatException fe)
            {
                ShowErrorMessage(fe.Message + "\n\n" +
                                 fe.GetType().ToString() + "\n\n" +
                                 fe.StackTrace,
                                 "FormatException Found");
            }
            catch (OverflowException oe)
            {
                ShowErrorMessage(oe.Message + "\n\n" +
                                 oe.GetType().ToString() + "\n\n" +
                                 oe.StackTrace,
                                 "OverflowException Found");
            }
            catch (DivideByZeroException dbze)
            {
                ShowErrorMessage(dbze.Message + "\n\n" +
                                 dbze.GetType().ToString() + "\n\n" +
                                 dbze.StackTrace,
                                 "DivideByZeroException Found");
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex.Message + "\n\n" +
                                 ex.GetType().ToString() + "\n\n" +
                                 ex.StackTrace,
                                 "General Exception");
            }
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
