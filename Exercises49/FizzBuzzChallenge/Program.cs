using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            bool IsNDivisibleBy(int n, int divisor)
            {
                int count = 0;
                while (count < n)
                {
                    count += divisor;
                }
                return (count == n);
            }
            //Create list of numbers
            List<int> numbers = new List<int>();
            for (int i = 0; i < 101; i++)
            {
                numbers.Add(i);
            }
            //Go through whole FizzBuzz
            foreach (var number in numbers)
            {
                if (IsNDivisibleBy(number, 3) && !IsNDivisibleBy(number, 5))
                {
                    Console.WriteLine("{0}: Fizz", number);
                }
                if (!IsNDivisibleBy(number, 3) && IsNDivisibleBy(number, 5))
                {
                    Console.WriteLine("{0}: Buzz", number);
                }
                if (IsNDivisibleBy(number, 3) && IsNDivisibleBy(number, 5))
                {
                    Console.WriteLine("{0}: FizzBuzz", number);
                }
                //if ((number % 3 == 0) && (number % 5 != 0))
                //{
                //    Console.WriteLine("{0}: Fizz", number);
                //}
                //if ((number % 3 != 0) && (number % 5 == 0))
                //{
                //    Console.WriteLine("{0}: Buzz", number);
                //}
                //if ((number % 3 == 0) && (number % 5 == 0))
                //{
                //    Console.WriteLine("{0}: FizzBuzz", number);
                //}
            }
        }
    }
}
