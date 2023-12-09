using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises68
{
    class Exercise3
    {
        /*
         * Write a program and ask the user to enter a time
         * value in the 24-hour time format (e.g. 19:00). A
         * valid time should be between 00:00 and 23:59. If 
         * the time is valid, display "Ok"; otherwise, display
         * "Invalid Time". If the user doesn't provide any 
         * values, consider it as invalid time.
         */
        public static void Execute()
        {
            var input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input) || !IsValidTime(input))
            {
                Console.WriteLine("Invalid Time");
            }
            else
            {
                Console.WriteLine("Ok");
            }
        }
        private static bool IsValidTime(string input)
        {
            var InputSplit = input.Split(':');
            if (InputSplit.Count() == 2)
            {
                int hour = Convert.ToInt32(InputSplit[0]);
                int minutes = Convert.ToInt32(InputSplit[1]);
                return ((hour <= 23 && minutes <= 59) && (hour >= 0 && minutes >= 0));
            }
            return false;
        }
    }
}
