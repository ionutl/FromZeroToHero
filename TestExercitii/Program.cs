using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestExercitii
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now.ToShortDateString(), Meth(DateTime.Now));
        }

        static bool Meth(DateTime date)
        {
            if ((date.DayOfWeek == DayOfWeek.Saturday) || (date.DayOfWeek == DayOfWeek.Sunday))
            {
                Console.WriteLine("weekend");
                return true;
            }
            else
                Console.WriteLine("is not weekend");
                return false;
        }
    }
}
