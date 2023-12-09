using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises49
{
    public class Exercise5
    {
        public static void Execute()
        {
            //Write a program and ask the user to enter a series of numbers separated by a comma.
            //Find the maximum of the numbers and display it on the console. For example, if the user
            //enters "5,3,8,1,4", the program should display 8.
            Console.WriteLine("Enter numbers separated by a comma");
            var input = Console.ReadLine();
            var numbers = input.Split(',');
            int maxNumber = 0;
            foreach (var number in numbers)
            {
                int num = Convert.ToInt32(number);
                if (num > maxNumber)
                    maxNumber = num;
            }
            Console.WriteLine("Max number: {0}", maxNumber);
        }
    }
}
