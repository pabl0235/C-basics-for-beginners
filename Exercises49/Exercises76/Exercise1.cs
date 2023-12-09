using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exercises76
{
    class Exercise1
    {
        public static void Execute()
        {
            /*
             * Write a program that reads a text file 
             * and displays the number of words
             * */
            string path = @"C: \Users\pablo\OneDrive\Escritorio\Nuevo documento de texto.txt";
            var content = File.ReadAllText(path);
            int words = CountWords(content);
            Console.WriteLine(content);
            Console.WriteLine("Words: " +  words);
        }

        private static int CountWords(string content)
        {
            return content.Split().Count();
        }
    }
}
