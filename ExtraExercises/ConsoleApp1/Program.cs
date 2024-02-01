using System;
using System.Numerics;
using static System.Console;
using static System.Runtime.InteropServices.JavaScript.JSType;

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

namespace Extra5_2Console
{
    internal class Program
    {
        //  Declare and initialize program constants
        const int MINNUMBER     =  1;
        const int MAXNUMBER     = 99;
        const int QUARTERVALUE  = 25;
        const int DIMEVALUE     = 10;
        const int NICKELVALUE   =  5;

        //  Declare and initialize class variables
        static int number = 0;
        
        static void Main(string[] args)
        {
            while (1 == 1)
            {
                InputNumber();
                CalculateChangeNumbers();
            }
        }

        static void InputNumber()
        {
            Clear();
            bool result;

            Write($"Enter a number between {MINNUMBER} and {MAXNUMBER}\t\t");
            string? numberStr = ReadLine();

            if (numberStr == "")
            {
                WriteLine("You Must Input a Number. Please Try Again.");
                InputNumber();
            }

            result = int.TryParse(numberStr, out number);

            if (!result || number < MINNUMBER || number > MAXNUMBER)
            {
                WriteLine("Non-Numeric or Number Out Of Range. Please Try Again.");
                InputNumber();
            }
        }

        static void CalculateChangeNumbers()
        {
            int numQuarters = 0;
            int numDimes    = 0;
            int numNickels  = 0;
            int numPennies  = 0;
            int whatsLeft   = 0;

            numQuarters = number / QUARTERVALUE;
            whatsLeft   = number % QUARTERVALUE;

            numDimes  = whatsLeft / DIMEVALUE;
            whatsLeft = whatsLeft % DIMEVALUE;

            numNickels = whatsLeft / NICKELVALUE;
            numPennies = whatsLeft % NICKELVALUE;

            WriteLine($"\n\nNumber Inputted:\t{number}");
            WriteLine($"Number Quarters:\t{numQuarters}");
            WriteLine($"Number Dimes:\t\t{numDimes}");
            WriteLine($"Number Nickels:\t\t{numNickels}");
            WriteLine($"Number Pennies:\t\t{numPennies}");

            ReadLine();
        }
    }
}
