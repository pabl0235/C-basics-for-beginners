using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises49
{
    public class Exercise1
    {
        public static void Execute()
        {
            //Write a program to count how many numbers between 1 and 100 are divisible
            //by 3 with no remainder. Display the count on the console
            int count = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    count += 1;
                }
            }
            Console.WriteLine(count);
        }
    }
}
