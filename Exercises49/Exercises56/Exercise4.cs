using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises56
{
    class Exercise4
    {
        public static void Execute()
        {
            //Write a program and ask the user to continuosly enter a number or 
            //type "Quit" to exit. The list of numbers may include duplicates. Display the unique numbers
            //that the user has entered.
            Console.WriteLine("Continuosly enter a number or type 'Quit' to exit.");
            
            List<int> numbers = new List<int>();
            List<int> numbersNonRepeated = new List<int>();
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "Quit")
                    break;
                int number = Convert.ToInt32(input);
                if (!numbers.Contains(number))
                    numbersNonRepeated.Add(number);
                numbers.Add(number);
            }
            foreach (var number in numbersNonRepeated)
            {
                Console.WriteLine(number);
            }
        }
    }
}
