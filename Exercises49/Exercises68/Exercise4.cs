using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises68
{
    class Exercise4
    {
        /*
         * Write a program and ask the user to enter
         * a few words separated by a space. Use the 
         * words to create a variable name with PascalCase.
         * For example, if the user types: "number of students", 
         * display "NumberOfStudents". Make sure that the program
         * is not dependent on the input. So, if the user types
         * "NUMBER OF STUDENTS", the program should still display 
         * "NumberOfStudents".
         * 
         **/
        public static void Execute()
        {
            Console.WriteLine("Enter a vairable name to convert to PascalCase");
            string input = Console.ReadLine();
            string LowerCaseInput = input.ToLower();
            string[] SplitLowerCaseInput = LowerCaseInput.Split();
            StringBuilder PascalCase = GetPascalCaseString(SplitLowerCaseInput);
            Console.WriteLine(PascalCase);
        }

        private static StringBuilder GetPascalCaseString(string[] SplitLowerCaseInput)
        {
            var PascalCase = new StringBuilder();
            foreach (string word in SplitLowerCaseInput)
            {
                string FirstLetter = word[0].ToString();
                PascalCase.Append(FirstLetter.ToUpper());
                for (int i = 1; i < word.Length; i++)
                {
                    PascalCase.Append(word[i]);
                }
            }
            return PascalCase;
        }
    }
}
