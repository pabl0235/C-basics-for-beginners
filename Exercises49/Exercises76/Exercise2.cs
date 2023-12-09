using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exercises76
{
    class Exercise2
    {
        /*
         * Write a program that reads a text file and displays
         * the longest word in a file.
         * */
        public static void Execute()
        {
            string path = @"C: \Users\pablo\OneDrive\Escritorio\Nuevo documento de texto.txt";
            var content = File.ReadAllText(path);
            string[] words = content.Split();
            int wordLength;
            string LongestWord;
            GetLongestWord(words, out wordLength, out LongestWord);
            Console.WriteLine("Longest word: {0}. Chars length: {1}.", LongestWord, wordLength);
        }

        private static void GetLongestWord(string[] words, out int wordLength, out string LongestWord)
        {
            wordLength = 0;
            LongestWord = "";
            foreach (var word in words)
            {
                if (wordLength < word.Length)
                {
                    wordLength = word.Length;
                    LongestWord = word;
                }
            }
        }
    }
}
