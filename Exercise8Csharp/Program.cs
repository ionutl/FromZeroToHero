using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8Csharp
{
    class Program
    {
        public enum DiscountType
        {
            General,
            Promotion,
            BestDeal
        }
        static decimal Discount(decimal price , int age = 14 ,DiscountType discountDeal = DiscountType.General )
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
        static decimal Discount(int price, int age = 14, DiscountType discountDeal = DiscountType.General)
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

            decimal priceWithoutPromotion = Discount(125M);
            Console.WriteLine("Price with discount is {0}", priceWithoutPromotion);

            decimal priceWithPromotion1 = Discount(125M, discountDeal: DiscountType.Promotion);
            Console.WriteLine("Price with discount is {0}", priceWithPromotion1);

            decimal priceWithPromotion2 = Discount(125M, discountDeal:DiscountType.BestDeal, age: 7);
            Console.WriteLine("Price with discount is {0}", priceWithPromotion2);

            decimal priceWithoutPromotion2 = Discount(125M);
            Console.WriteLine("Price with discount is {0}", priceWithoutPromotion2);

            decimal priceWithPromotion3 = Discount(15, discountDeal: DiscountType.Promotion);
            Console.WriteLine("Price with discount is {0}", priceWithPromotion3);

            decimal priceWithPromotion4 = Discount(15, discountDeal: DiscountType.BestDeal, age: 7);
            Console.WriteLine("Price with discount is {0}", priceWithPromotion4);


        }
    }
}
