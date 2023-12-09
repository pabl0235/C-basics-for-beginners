using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises49
{
    public class Exercise3
    {
        public static void Execute()
        {
            //Write a program and ask the user to enter a number. Compute the factorial of the number
            //and print it on the console. For example, if the user enters 5, the program should calculate
            //5*4*3*2*1 and display it as 5! = 120
            Console.WriteLine("Enter a number to calculate its factorial: ");
            var input = Console.ReadLine();
            var number = Convert.ToInt32(input);
            long factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }
            Console.WriteLine(input + "! = " + factorial);
        }
    }
}
