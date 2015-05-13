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
            Room room1 = new Room(1, @"A beautiful room for 1 person with all facilities inclued", 1,
                                  2, RoomTypes.Single);

            Room room2 = new Room(2, @"A beautiful room for 2 person with a beautiful view towords the city cener", 2,
                                   7, RoomTypes.Double);

            Hotel hotel = new Hotel("Unirea Hotel", @"Unirea Hotel is one of the most good looking hotel in Iasi Romania.",
                                    @"Piaţa Unirii Street No. 5, 700056 Iaşi, Romania", 4, 1.6, new DateTime(1975, 10, 25),
                                    new Room[] { room1, room2 });

            hotel.rooms = new Room[] { room1, room2 };

            hotel.DisplayInfo();

        }
    }
}
