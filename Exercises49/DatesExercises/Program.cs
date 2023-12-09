using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatesExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            var dateStart = new DateTime(2023, 5, 3);
            var dateEnd = new DateTime(2023, 8, 7);
            var cycle = dateEnd - dateStart;
            Console.WriteLine("Days: " + cycle);
        }
    }
}
