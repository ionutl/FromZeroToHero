using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class GuestHouse:Property
    {
        public int ComfortIndex { get; set; }
        public GuestHouse(string name, string description, string address, int stars,
                    double distanceToCenter, DateTime openingDate, Room[] rooms, int comfortIndex)
            : base(name, description, address, stars, distanceToCenter, openingDate, rooms)
        {
            ComfortIndex = comfortIndex;
        }

        public override sealed double CalculateRating()
        {
            return ComfortIndex * 0.6 + 2 * Stars * 0.4;
        }
        public void DisplayInfoGuest()
        {
            Console.WriteLine("Details of Hotel: {0}", Name);
            Console.WriteLine("Description: {0}", Description);
            Console.WriteLine("Address: {0}", Address);
            Console.WriteLine("Stars {0}", new string('*', Stars));
            Console.WriteLine("Distance to center: {0} {1}", DistanceToCenter, distanceMesurementUnit);
            Console.WriteLine("Opening Date: {0}", OpeningDate.ToShortDateString());
            foreach (Room room in Rooms)
            {
                room.DisplayInfo();
            }
            Console.WriteLine("Confort idex: {0}", CalculateRating());
        }

    }
}
