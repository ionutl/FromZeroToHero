using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercitiu2Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintInfoSeason(Season.Summer);
        }

        public enum Season
        {
            Spring = 1,
            Summer = 2,
            Autumn = 3,
            Winter = 4
        }

        public static void PrintInfoSeason(Season season)
        {
            switch (season)
            {
                case Season.Spring:
                    {
                        Console.WriteLine("This season is {0}", season);
                        break;
                    }
                case Season.Summer:
                    {
                        Console.WriteLine("Now it is {0}", season);
                        break;
                    }
                case Season.Autumn:
                    {
                        Console.WriteLine("This is the {0} season", season);
                        break;
                    }
                case Season.Winter:
                    {
                        Console.WriteLine("It is quite cold because it is {0}", season);
                        break;
                    }
            }
         }  
    }
}
