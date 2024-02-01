
/*
 *      Extra 4-2 Accumulate test score data
 *      ====================================
 *      In this exercise, you'll create a form that 
 *      accepts one or more scores from the user.
 *      
 *      Each time a score is added, the score total, 
 *      score count, and average score are calculated 
 *      and displayed.
 *      
 *      1.	Create Extra4-2Console and Extra4-2GUI.
 *      
 *      2.	Declare two class variables to store the 
 *			score total and the score count.
 *		
 *		3. 	GUI Only
 *			Create an event handler for the Click 
 *			event of the Add button. The event handler 
 *			should get the score the user enters, 
 *			calculate and display the score total,
 *			score count, and average score, and move 
 *			the focus to the Score text box. It should 
 *			provide for integer entries, but you can 
 *			assume that the user will enter valid 
 *			integer values.
 *			
 *		4. 	GUI Only:
 *			Create an event handler for the Click 
 *			event of the  Clear button. The event 
 *			handler should set the two class 
 *			variables to zero, clear the text boxes 
 *			on the form, and move the focus to the 
 *			Score text box.
 *			
 *		5.	GUI Only:
 *			Create an event handler for the Click
 *			event of the Exit button that closes 
 *			the form.
 *			
 *		6.	Test the app to be sure it works correctly.
 */


using static System.Formats.Asn1.AsnWriter;

namespace Extra4_2GUI
{
    public partial class frmScoreCalculator : Form
    {
        //	Declare and initialize program constants
        const int MINSCORE       = 0;
        const int MAXSCORE       = 100;
        const string STOPPROGRAM = "-999";

        //	Declare and initialize class variables;
        int currentScore     = 0;
        int scoreTotal       = 0;
        int scoreCount       = 0;
        decimal scoreAverage = 0m;

        public frmScoreCalculator()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AttemptToAddTestScore();
            UpdateTotals();
        }

        private void AttemptToAddTestScore()
        {
            string scoreStr = txtScore.Text;
            bool result;

            //	Check for empty test score input
            if (scoreStr.Trim() == "")
            {
                ShowErrorMessage("Score Cannot Be Empty.Please Try Again.",
                                 "NO SCORE INPUTTED");
                txtScore.Focus();
                return;
            }

            //	Check for non-numeric or oor test score
            result = int.TryParse(scoreStr, out currentScore);
            if (!result || currentScore < MINSCORE || currentScore > MAXSCORE)
            {
                ShowErrorMessage("Non-Numeric Or Out-Of-Range Score. Please Try Again.",
                                 "INVALID SCORE INPUTTED");
                txtScore.Text = "";
                txtScore.Focus();
                return;
            }
        }

        private void UpdateTotals()
        {
            //	Add 1 to score count
            scoreCount++;
            txtScoreCount.Text = scoreCount.ToString();

            //	Add current score to scoreTotal
            scoreTotal += currentScore;
            txtScoreTotal.Text = scoreTotal.ToString();

            //	Calculate current score average
            scoreAverage = (decimal)scoreTotal / scoreCount;
            txtAverage.Text = scoreAverage.ToString("n2");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtScore.Text      = "";
            txtScoreTotal.Text = "";
            txtScore.Focus();
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
