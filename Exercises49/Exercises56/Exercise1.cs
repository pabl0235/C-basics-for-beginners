using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises56
{
    public class Exercise1
    {
        public static void Execute()
        {
            //When you post a message on Facebook, depending on the number of people who liked your post,
            //Facebook displays different information. 
            //If no one likes your post, it doesn't display anything.
            //If only one person likes your post, it displays [Friend's name] likes your post
            //If two people likes your post, it displays: [Friend1] and [Firend2] like your post.
            //If more than 2 people like your post, it displays: [Friend1], [Friend2] and [number of other people] 
            //others like your post
            //Write a program ad continously ask the user to enter different names, until the user presses Enter 
            //(without supplying a name). Depending on the number of names provided, display a message based on the 
            //above pattern.
            var Friends = new List<string>();
            while (true)
            {
                Console.WriteLine("Enter friends names. Click just enter to finish entering names.");
                string input = Console.ReadLine();
                if (string.IsNullOrEmpty(input)) // clicked enter -> exit
                {
                    break;
                }
                else
                {
                    Friends.Add(input);
                }
            }
            Output(Friends);
        }

        private static void Output(List<string> Friends)
        {
            if (Friends.Count == 1)
                Console.WriteLine(Friends[0] + " likes your post.");
            if (Friends.Count == 2)
                Console.WriteLine(Friends[0] + " and " + Friends[1] + " like your post.");
            if (Friends.Count > 2)
                Console.WriteLine(Friends[0] + ", " + Friends[1] + " and " + (Friends.Count - 2) + " others like your post.");
        }
    }
}
