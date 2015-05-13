using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Hotel hotel = new Hotel();
            hotel.name = "Unirea Hotel";
            hotel.description = @"Unirea Hotel is one of the most good looking hotel in Iasi Romania.";
            hotel.address = "Piaţa Unirii Street No. 5, 700056 Iaşi, Romania";
            hotel.stars = 4;
            hotel.distanceToCenter = 1.6;
            hotel.openingDate = new DateTime(1975, 10, 25);

            Room room1 = new Room();
            room1.type = RoomTypes.Single;
            room1.description = @"A beautiful room for 1 person with all facilities inclued";
            room1.places = 1;
            room1.number = 1;
            room1.floor = 2;

            Room room2 = new Room();
            room2.type = RoomTypes.Double;
            room2.description = @"A beautiful room for 2 person with a beautiful view towords the city cener";
            room2.places = 2;
            room2.number = 2;
            room2.floor = 7;

            hotel.rooms = new Room[] { room1, room2 };

            hotel.DisplayInfo();

            
        }
    }
}
