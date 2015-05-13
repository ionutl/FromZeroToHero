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
            Room room3 = new Room(75, @"A beautiful room for 1 person with all facilities inclued only at Astoria.", 1,
                                  6, RoomTypes.Single);

            Hotel hotelAstoria = new Hotel("Astoria", @"Astora Hotel is an excellent place to stay while in Iasi",
                                    @"Piata Unirii Street No. 7 Iasi, Romania", 5, 1.8, new DateTime(1990, 12, 19),
                                    new Room[] { room3 });

            Hotel.SetDistanceMesurementUnit("KM");


            Console.WriteLine("Distance to center for hotel {0} is {1} {2}", hotel.name,
                hotel.GetDistanceToCenter("Miles"), "Miles");
        }
    }
}
