using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    sealed class Hotel : Property
    {
        public int Likes { get; set; }
        public Hotel(string name, string description, string address, int stars,
                    double distanceToCenter, DateTime openingDate, Room[] rooms, int likes)
            : base(name, description, address, stars, distanceToCenter, openingDate, rooms)
        {
            Likes = likes;
        }

        public void ChangeAddress(string value)
        {
            if (value.Length <= 100)
            {
                address = value;
            }
            else
                address = string.Empty;
        }

        public override double CalculateRating()
        {
            int trimLikes = Likes > 10000 ? 10000 : Likes;
            return trimLikes / 1000 * 0.3 + 2 * Stars * 0.7;
        }
        public void DisplayInfoHotel()
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
            Console.WriteLine("Likes number: {0}", CalculateRating());
        }
    }
}
