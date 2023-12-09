using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises49
{
    public class Exercise2
    {
        //Write a program and continuosly ask the user to enter a number or "ok" to exit.
        //Calculate the sum of all entered numbers and display it on the console
        public static void Execute()
        {
            int sum = 0;
            while (true)
            {
                Console.WriteLine("Enter a number or 'ok' to exit.");
                var input = Console.ReadLine();
                if (input == "ok")
                {
                    break;
                }
                else
                {
                    sum += Convert.ToInt32(input);
                }
            }
            Console.WriteLine(sum);
        }
    }
}
