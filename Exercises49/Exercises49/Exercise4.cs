using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises49
{
    public class Exercise4
    {
        public static void Execute()
        {
            //Write a program that picks a random number between 1 and 10.
            //Give the user 4 chances to guess the number. If the user
            //guess the number, display "You won"; otherwise, display "You lost".
            //(To make sure the program is behaving correctly, you can display
            //the secret number on the console first
            var random = new Random();
            int randomNumber = random.Next(1, 10);
            const int chances = 4;
            int attempts = 1;
            int inputNumber = 0;
            while (attempts <= chances)
            {
                Console.WriteLine("Guess the random number (Attempt({0})): ", attempts);
                inputNumber = Convert.ToInt32(Console.ReadLine());
                if (randomNumber == inputNumber)
                {
                    Console.WriteLine("You won. Random number was: {0}", randomNumber);
                    break;
                }
                attempts++;
            }
            if (randomNumber != inputNumber)
                Console.WriteLine("You lost. Random number was: {0}", randomNumber);
        }
    }
}
