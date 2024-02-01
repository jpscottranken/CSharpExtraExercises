using System;
using static System.Console;

/*
 *  Extra 5-1 Calculate the factorial of a number
 *  =============================================
 *  In this exercise, you'll create Extra5-1Console
 *  and Extra5-1GUI that accepts an integer from the
 *  user and then calculates the factorial of that
 *  integer.
 *  
 *  The factorial of a # is an integer multiplied by
 *  every positive integer less than itself.
 *  
 *  A factorial number is identified by an 
 *  exclamation point following the number.
 *  
 *  Here's how you calculate the factorial of the 
 *  numbers 1 through 5:
 *  
 *  1! = 1 which equals 1 
 *  2! = 2 * 1 which equals 2
 *  3! = 3 * 2 * 1 which equals 6 
 *  4! = 4 * 3 * 2 * 1 which equals 24 
 *  5! = 5 * 4 * 3 * 2 * 1 which equals 120
 *  
 *  To be able to store the large integer values 
 *  for the factorial, this app can't use the 
 *  Int32 data type.
 *  
 *  1.	GUI Only
 *   	Create an event handler for the Click 
 *   	event of the Calculate button. The event 
 *   	handler should get the number the user 
 *   	enters, calculate the factorial of that
 *   	number, display the factorial with commas 
 *   	but	no decimal places, and move the focus 
 *   	to the Number text box. It should return 
 *   	an accurate value for integers from 1 to 20.
 *   	
 *   2. Create an event handler for the Click event 
 *      of the Exit button that closes the form.
 *
 *  3.  Test the app to be sure it works correctly.
 */

namespace Extra5_2
{
    internal class Program
    {
        //  Declare and initialize program constants
        const int MINNUMBER =  1;
        const int MAXNUMBER = 20;

        //  Declare and initialize class variables
        static int number     = 0;
        static long factorial = 0L;

        static void Main(string[] args)
        {
            while (1 == 1)
            {
                InputNumber();
                factorial = CalculateFactorial(number);
                PrintAnswer();
                ReadLine();
            }
        }

        static void InputNumber()
        {
            bool result;

            Clear();
            Write($"Enter a number between {MINNUMBER} and {MAXNUMBER}\t\t");
            string numberStr = ReadLine();

            if (numberStr == "")
            {
                WriteLine("You Must Input a Number. Please Try Again.");
                InputNumber();
            }

            result = int.TryParse(numberStr, out number);

            if (!result || number < MINNUMBER ||  number > MAXNUMBER)
            {
                WriteLine("Non-Numeric or Number Out Of Range. Please Try Again.");
                InputNumber();
            }
        }

        static long CalculateFactorial(int n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }
            else
            {
                return n * CalculateFactorial(n - 1);
            }
        }

        static void PrintAnswer()
        {
            WriteLine($"\n{number}! = {factorial:n0}");
        }
    }
}
