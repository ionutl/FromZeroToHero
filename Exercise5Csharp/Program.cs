﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5Csharp
{
    class Program
    {
        static void Discount(ref decimal price, int age)
        {
            if (age < 7)
            {
                price = price - 0.25M * price;
            }

            else if ((age >= 7) && (age <= 14))
            {
                price = price - 0.15M * price;
            }
            else
                price = price - 0.05M * price;
        }
        static void Main(string[] args)
        {
            decimal price = 99.9M;
            Discount(ref price, 7);
            Console.WriteLine("Price with discount is {0}", price);
        }
    }
}
