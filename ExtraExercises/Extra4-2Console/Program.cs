using System;
using static System.Console;
using static System.Formats.Asn1.AsnWriter;

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

namespace Extra4_2Console
{
    internal class Program
    {
		//	Declare and initialize program constants
		const int MINSCORE		 =     0;
		const int MAXSCORE		 =   100;
		const string STOPPROGRAM = "-999";

		//	Declare and initialize class variables;
		static int currentScore     = 0;
        static int scoreTotal	    = 0;
		static int scoreCount	    = 0;
		static decimal scoreAverage = 0m;

        static void Main(string[] args)
        {
			while (currentScore.ToString() != STOPPROGRAM)
			{
                InputTestScore();
                UpdateTotals();
                PrintAllStatistics();
            }
        }

		static void InputTestScore()
		{
			Clear();
			string scoreStr = "";
			bool result;

			//	Input test score between 0 - 100
			Write($"Enter a test score between {MINSCORE} and {MAXSCORE} or {STOPPROGRAM} to end:\t");
			scoreStr = ReadLine();

			//	Check for empty test score input
			if (scoreStr.Trim() == "")
			{
				WriteLine("\nScore Cannot Be Empty. Please Try Again.");
				ReadLine();

				InputTestScore();
			}

			if (scoreStr == STOPPROGRAM)
			{
				WriteLine("Program Exiting Naturally");
				Environment.Exit(0);
			}

			//	Check for non-numeric or oor test score
			result = int.TryParse(scoreStr, out currentScore);
            if (!result || currentScore < MINSCORE || currentScore > MAXSCORE)
			{
                WriteLine("\nNon-Numeric Or Out-Of-Range Score. Please Try Again.");
                ReadLine();

                InputTestScore();
            }
        }

		static void UpdateTotals()
		{
            //	Add 1 to score count
            scoreCount++;

            //	Add current score to scoreTotal
            scoreTotal += currentScore;

            //	Calculate current score average
            scoreAverage = (decimal)scoreTotal / scoreCount;
        }

        static void PrintAllStatistics()
		{
            WriteLine($"\n\nScore\t\t{currentScore}");
            WriteLine($"Score Total:\t{scoreTotal}");
            WriteLine($"Score Count:\t{scoreCount}");
            WriteLine($"Average:\t{scoreAverage:n2}");
			ReadLine();
        }
    }
}
