using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises56
{
    class Exercise3
    {
        public static void Execute()
        {
            //Write a program and ask the user to enter 5 numbers. If a number
            //has been previously entered, display an error message and 
            //ask the user to re-try. Once the user succesfully enters 5 unique numbers,
            //sort them and display the result on the console.
            Console.WriteLine("Please, enter 5 numbers.");
            List<int> numbers = new List<int>();
            int i = 1;
            while (i <= 5)
            {
                var input = Console.ReadLine();
                int number = Convert.ToInt32(input);
                if (numbers.Contains(number))
                    Console.WriteLine("Re-try typing a different number.");
                else
                {
                    i++;
                    numbers.Add(number);
                }
            }
            numbers.Sort();
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
