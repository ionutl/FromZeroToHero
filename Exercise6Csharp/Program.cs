using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6Csharp
{
    class Program
    {
        static void Discount(decimal price, int age, out decimal priceWithDiscount)
        {
            if (age < 7)
            {
                priceWithDiscount = price - 0.25M * price;
            }

            else if ((age >= 7) && (age <= 14))
            {
                priceWithDiscount = price - 0.15M * price;
            }
            else
                priceWithDiscount = price - 0.05M * price;
        }
        static void Main(string[] args)
        {
            decimal priceWithDiscount;
            Discount(99.9M, 7, out priceWithDiscount);
            Console.WriteLine("Price with discount is {0}", priceWithDiscount);
        }
    }
}
