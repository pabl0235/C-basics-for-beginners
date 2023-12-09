using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises68
{
    class Exercise2
    {/*
        * Write a program and ask the user to enter a few numbers separated
        * by a hyphen ("-"). If the user simply presses Enter, without
        * supplying an input, exit inmediately; otherwise, check to see if
        * there are duplicates. If so, display "Duplicate" on the console.
        * */
        public static void Execute()
        {
            Console.WriteLine("Enter consecutive numbers separated by a hyphen.");
            var input = Console.ReadLine();
            if (string.IsNullOrEmpty(input)) return;
            var numbers = input.Split('-');
            List<string> numbers2 = new List<string>();
            foreach (var item in numbers)
            {
                if (numbers2.Contains(item))
                {
                    Console.WriteLine("Duplicate");
                    return;
                }
                else
                {
                    numbers2.Add(item);
                }
            }
        }
    }
}
