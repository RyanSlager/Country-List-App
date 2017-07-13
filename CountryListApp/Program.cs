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
            List<string> countries = new List<string>();
            List<string> newCountries = new List<string>();
            CountryWriter country = new CountryWriter(path);

            country.OpenFile(path);
            countries = country.ScanFile(path);
            newCountries = country.AddCountries(countries, path);


        }


    }
}
