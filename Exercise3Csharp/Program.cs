using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3Csharp
{
    class Program
    {

        static string LargestNamedCountry(string[] countries)
        {
            string largestCountry = string.Empty;
            foreach(string country in countries)
            {
                if(country.Length > largestCountry.Length)
                    largestCountry = country;
            }
            return largestCountry;
        }
        static void Main(string[] args)
        {
            string[] countries = {"Argentina", "Romania", "Ciad" };
            string largestCountry = LargestNamedCountry(countries);
            Console.WriteLine("Largest country name is {0}", largestCountry);
        }
    }
}
