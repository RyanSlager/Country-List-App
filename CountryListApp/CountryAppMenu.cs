using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountryListApp
{
    class CountryAppMenu
    {
        string path;
        string name;

        public CountryAppMenu(string path)
        {
            this.path = path;
            name = SetName();
        }

        public string SetName()
        {
            Console.WriteLine("Hello! Welcome to our country list!\nCan we get your name?\n");
            return Console.ReadLine();
        }

        public bool DrawMenu()
        {
            string rawChoice;
            int choice;
            bool cont = true;
            CountryWriter cw = new CountryWriter(path);
            List<string> countries = cw.ScanFile(path);

            Console.WriteLine($"{name}, please select an option from our menu:\n1) View list of countries" +
                $"\n2) Add a country\n3) Exit");
            rawChoice = Console.ReadLine();
            choice = Validator.CheckInts(rawChoice, 1, 3);
            Console.WriteLine();

            if (choice == 1)
            {
                PrintCountries(path);
            }
            else if (choice == 2)
            {
                cw.AddCountries(countries, path);
            }
            else if (choice == 3)
            {
                cont = false;
            }

            return cont;
        }

        public void PrintCountries(string path)
        {
            CountryWriter cw = new CountryWriter(path);
            List<string> countries = new List<string>();

            countries = cw.ScanFile(path);

            for(int i = 0; i < countries.Count; i++)
            {
                Console.WriteLine(countries[i]+"\n");
            }
        }
    }
}
