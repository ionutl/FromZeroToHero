using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    public class Hotel
    {
        public string name;
        public string description;
        public string address;
        public int stars;
        public double distanceToCenter;
        public DateTime openingDate;
        public Room[] rooms;
        private static string distanceMesurementUnit;

        static Hotel()
        {
            distanceMesurementUnit = "Miles";
        }

        public Hotel(string name, string description, string address, int stars,
                    double distanceToCenter, DateTime openingDate, Room[] rooms)
        {
            this.name = name;
            this.description = description;
            this.address = address;
            this.stars = stars;
            this.distanceToCenter = distanceToCenter;
            this.openingDate = openingDate;
            this.rooms = rooms;
        }

        public static void SetDistanceMesurementUnit(string measurementUnit)
        {
            distanceMesurementUnit = measurementUnit;
        }

        public static string GetDistanceMesurementUnit()
        {
            return distanceMesurementUnit;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Details of Hotel: {0}", name);
            Console.WriteLine("Description: {0}", description);
            Console.WriteLine("Address: {0}", address);
            Console.WriteLine("Stars {0}", new string('*', stars));
            Console.WriteLine("Distance to center: {0} {1}", distanceToCenter, distanceMesurementUnit);
            Console.WriteLine("Opening Date: {0}", openingDate.ToShortDateString());
            foreach (Room room in rooms)
            {
                room.DisplayInfo();
            }

        }
    }
}
