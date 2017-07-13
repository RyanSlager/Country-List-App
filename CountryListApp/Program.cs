using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountryListApp
{
    class Program
    {
        static void Main(string[] args)
        {

            string path = @"C:\Users\slage\Desktop\C# Bootcamp\CountryListApp\countries.txt";
            CountryAppMenu menu = new CountryAppMenu(path);
            bool cont = menu.DrawMenu();

            while (cont)
            {
                cont = menu.DrawMenu();
            }
        }


    }
}
