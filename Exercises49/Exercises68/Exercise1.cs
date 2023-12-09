using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises68
{
    class Exercise1
    {
        /*
         * Write a program and ask the user to enter a few numbers separated
         * by a hyphen ("-"). Work out if the numbers are consecutive. For example,
         * if the input is "5-6-7-8-9" or "20-19-18-17-16", display a message:
         * "Consecutive"; otherwise, display "Not Consecutive".
         * */
         public static void Execute()
        {
            Console.WriteLine("Enter consecutive numbers separated by a hyphen.");
            var input = Console.ReadLine();
            var numbers = input.Split('-');
            if (numbers.Count() < 2) return;
            bool UpperConsecutive = IsConsecutive(numbers, 1);
            bool LowerConsecutive = IsConsecutive(numbers, -1);
            if (UpperConsecutive)
            {
                Console.WriteLine("Upper consecutive.");
            }
            else if (LowerConsecutive)
            {
                Console.WriteLine("Lower consecutive.");
            }
            else
            {
                Console.WriteLine("Not Consecutive.");
            }
        }

        private static bool IsConsecutive(string[] numbers, int Operator)
        {
            bool Consecutive = false;
            for (int i = 0; i < numbers.Count() - 1; i++)
            {
                var currentNumber = Convert.ToInt32(numbers[i]);
                var nextNumber = Convert.ToInt32(numbers[i + 1]);
                if (currentNumber + Operator != nextNumber)
                {
                    Consecutive = false;
                    break;
                }
                Consecutive = true;
            }
            return Consecutive;
        }
    }
}
