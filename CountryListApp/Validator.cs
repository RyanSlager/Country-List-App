using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountryListApp
{
    class Validator
    {
        static Validator()
        {

        }

        public static int CheckInts(string x, int min, int max)
        {
            int z;
            string y = x;
            while (!Int32.TryParse(y, out z) || z < min || z > max)
            {
                Console.WriteLine($"That is not a valid input.\nPlease select an option from our menu:\n1) View list of countries" +
                $"\n2) Add a country\n3) Exit");
                y = Console.ReadLine();
            }

            return z;
        }

        public static double CheckDubs(string x)
        {
            double z;
            string y = x;

            while (!Double.TryParse(y, out z) || z <= 0)
            {
                Console.WriteLine("That is not a valid input, please enter a positive number\n");
                y = Console.ReadLine();
            }

            return z;
        }
    }
}
