using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises68
{
    class Exercise5
    {
        /*
         * Write a program and ask the user to enter an English word.
         * Count the number of vowels (a,e,i,o,u) in the word. So, if
         * the user enters "inadequate", the program should display 6
         * on the console.
         * */
        public static void Execute()
        {
            Console.WriteLine("Enter an English word.");
            string input = Console.ReadLine();
            int countVowels = GetVowelsCount(input);
            Console.WriteLine("Vowels: {0}", countVowels);
        }

        private static int GetVowelsCount(string input)
        {
            int countVowels = 0;
            foreach (char character in input)
            {
                if (character == 'a' || character == 'e' || character == 'i' || character == 'o' || character == 'u' ||
                    character == 'A' || character == 'E' || character == 'I' || character == 'O' || character == 'U')
                {
                    countVowels++;
                }
            }
            return countVowels;
        }
    }
}
