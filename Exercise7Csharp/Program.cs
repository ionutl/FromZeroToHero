using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7Csharp
{
    class Program
    {
        public enum DiscountType{
            General,
            Promotion,
            BestDeal
        }
        static decimal Discount(decimal price, int age, DiscountType discountDeal = DiscountType.General)
        { 
            decimal priceWithDiscount;
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
            switch (discountDeal)
            {
                case DiscountType.Promotion:
                    {
                        priceWithDiscount = priceWithDiscount - 0.25M * priceWithDiscount;
                        break;
                    }
                case DiscountType.BestDeal:
                    {
                        priceWithDiscount = priceWithDiscount - 0.5M * priceWithDiscount;
                        break;
                    }
            }
            return priceWithDiscount;
        }
        static void Main(string[] args)
        {
            decimal priceWithPromotion = Discount(125M, 16, DiscountType.Promotion);
            Console.WriteLine("Price with discount is {0}", priceWithPromotion);

            decimal priceWithoutPromotion = Discount(125M, 12);
            Console.WriteLine("Price with discount is {0}", priceWithoutPromotion);
        }
    }
}
