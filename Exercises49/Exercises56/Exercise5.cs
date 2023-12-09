using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises56
{
    class Exercise5
    {
        public static void Execute()
        {
            //Write a program and ask the user to supply a list of comma separated numbers 
            //(e.g 5,1,9,2,10). If the list is empty or includes less than 5 numbers, 
            //display "Invalid list" and ask the user to re-try; otherwise, display the 3
            //smallest numbers in the list.
            Console.WriteLine("Supply a list of comma separated numbers (e.g 5,1,9,2,10).");
            List<int> numbers = new List<int>();
            string[] numbersList;
            while (true)
            {
                var input = Console.ReadLine();
                numbersList = input.Split(',');
                if (numbersList.Count() < 5)
                {
                    Console.WriteLine("Invalid list. Retry.");
                }
                else
                {
                    break;
                }
            }
            foreach (var number in numbersList)
            {
                numbers.Add(Convert.ToInt32(number));
            }
            numbers.Sort();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
