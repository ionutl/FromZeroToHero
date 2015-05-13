using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    static class DistanceConverter
    {
        public static double ConvertMilesToKilometers(double miles)
        {
            return miles * 1.609;
        }

        public static double ConvertKilometersToMiles(double kilometers)
        {
            return kilometers / 1.609;
        }
    }
}
