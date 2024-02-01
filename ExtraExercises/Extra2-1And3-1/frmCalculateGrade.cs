using System;
using System.Windows.Forms;

/*
 *      Extra 2-1 Design a simple form
 *      
 *      In this exercise, you'll design a form that 
 *      lets the user enter a number grade and then 
 *      displays the letter grade when the user 
 *      clicks the Calculate button.
 *      
 *      1.  Start a new project named CalculateLetterGrade 
 *          in the ExtraStarts\Ch02 directory.
 *          
 *      2.  Add the labels, text boxes, and buttons to 
 *          the form as shown above. 
 *          
 *      3.  Set the properties of the form as shown.
 *
 *      4.  Use the Form Designer to adjust the size 
 *          and position of the controls and the size of 
 *          the form so they look as shown above.
 *          
 *      5.  Rename the form to frmCalculateGrade. When 
 *          you're asked if you want to modify any 
 *          references to the form, click the Yes button.
 *          
 *      6.  Save the project and all of its files.
 *      
 *      Extra 3-1 Code and test the Calculate Letter 
 *      Grade form
 *      
 *      In this exercise, you'll add code to a Calculate 
 *      Letter Grade form. Then, you'll test the project 
 *      to be sure it works correctly.
 *      
 *      1.  Open the CalculateLetterGrade project in the 
 *          ExtraStarts\Ch03 directory.
 *          
 *      2.  Display the form in the Form Designer, and 
 *          double-click the Calculate button to generate 
 *          a Click event handler for the button.
 *          
 *      3.  Add this statement to display the letter grade 
 *          in the Letter Grade text box: 
 *          
 *          txtLetterGrade.Text = letterGrade; 5. 
 *          
 *      4.  Add this statement to move the focus back to 
 *          the Number Grade text box:
 *          
 *          txtNumberGrade.Focus(); 6. 
 *          
 *      5.  Return to the Form Designer, and then 
 *          double-click the Exit button to generate a 
 *          Click event handler for the button. 
 *          
 *          Then, add this statement to the event handler 
 *          to close the form: 
 *          
 *          this.Close(); 7. 
 *          
 *      6.  Run the app, enter a number between 0 and 100, 
 *          and then click the Calculate button. A letter 
 *          grade should be displayed and the focus should 
 *          return to the Number Grade text box. 
 *          
 *          Next, enter a different number and press the 
 *          enter key to display the letter grade for that 
 *          number.        
 */

namespace Extra2_1And3_1
{
    public partial class frmCalculateGrade : Form
    {
        public frmCalculateGrade()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            CalculateLetterGrade();
        }

        private void CalculateLetterGrade()
        {
               int numberGrade = Convert.ToInt32(txtNumberGrade.Text);
            string letterGrade;

            if (numberGrade >= 90)
            {
                letterGrade = "A";
            }
            else if (numberGrade >= 80)
            {
                letterGrade = "B";
            }
            else if (numberGrade >= 70)
            {
                letterGrade = "C";
            }
            else if (numberGrade >= 60)
            {
                letterGrade = "D";
            }
            else if (numberGrade >= 0)
            {
                letterGrade = "F";
            }
            else
            {
                letterGrade = "Illegal Input";
            }

            txtLetterGrade.Text = letterGrade;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtNumberGrade.Text = "";
            txtLetterGrade.Text = "";
            txtNumberGrade.Focus();
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
