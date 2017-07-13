using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountryListApp
{
    class CountryWriter
    {
        private string path;
        
        public CountryWriter(string path)
        {
            this.path = path;
        }

        public void OpenFile(string path)
        {
            if (!File.Exists(path))
            {
                Console.WriteLine("File not found, creating...");
                StreamWriter writer = new StreamWriter(File.Create(path));
                writer.WriteLine("Countries List:");
                writer.Close();
            }
        }

        public List<string> ScanFile(string path)
        {
            List<string> lines = File.ReadAllLines(path).ToList<string>();

            foreach (string line in lines)
            {               
                Console.WriteLine(line);
            }

            return lines;
        }

        public List<string> AddCountries(List<string> lines, string path)
        {
            int countryCount = lines.Count;
            List<string> newCountries = new List<string>();
            StreamWriter write = new StreamWriter(path);
            bool enter = true;

            
            while (enter)
            {
                Console.WriteLine("Please enter the countries you'd like to add: \n");
                string country = Console.ReadLine();
                newCountries.Add(country);

                enter = Continue();
            }

            lines.AddRange(newCountries);

            foreach (string line in lines)
            {
                write.WriteLine(line);
            }

            write.Close();

            return lines;
        }

        public static Boolean Continue()
        {
            Boolean run;
            Console.WriteLine("Continue? Y/N");
            String answer = Console.ReadLine();

            if ((answer == "Y") || (answer == "y"))
            {
                run = true;
            }
            else if ((answer == "N") || (answer == "n"))
            {
                run = false;
                Console.WriteLine("Good Bye!");
            }
            else
            {
                Console.WriteLine("I'm sorry I don't understand. Let's try again");
                run = Continue();
            }
            return run;
        }
    }
}

