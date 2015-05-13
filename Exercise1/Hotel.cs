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

       
        public void HotelName(string name)
        {
            this.name = name;
        }
        public void HotelDescription(string description)
        {
            this.description = description;
        }
        public void HotelAddress(string address)
        {
            this.address = address;
        }

        public void HotelDistanceToCenter(double distanceToCenter)
        {
            this.distanceToCenter = distanceToCenter;
        }

        public void HotelStars(int stars)
        {
            this.stars = stars;
        }
        public void HotelOpeningDate(DateTime openingDate)
        {
            this.openingDate = openingDate;
        }
        public void HotelNumberRooms(Room[] rooms)
        {
            this.rooms = rooms;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Details of Hotel: {0}", name);
            Console.WriteLine("Description: {0}", description);
            Console.WriteLine("Address: {0}", address);
            Console.WriteLine("Stars {0}", new string('*', stars));
            Console.WriteLine("Distance to center: {0} km", distanceToCenter);
            Console.WriteLine("Opening Date: {0}", openingDate.ToShortDateString());
            foreach (Room room in rooms)
            {
                room.DisplayInfo();
            }
        }
    }
}
