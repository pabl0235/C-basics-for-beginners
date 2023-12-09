using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises56
{
    public class Exercise2
    {
        public static void Execute()
        {
            //Write a program and ask the user to enter their name. Use an array to reverse the name
            //and then store the result in a new string. Display the reversed name on the console.
            Console.WriteLine("Write your name.");
            string name = Console.ReadLine();
            char[] nameArray = name.ToCharArray();
            Array.Reverse(nameArray);
            var reversedName = new string(nameArray);
            Console.WriteLine("Original name: " + name + ". Reversed: " + reversedName);
        }
    }
}
