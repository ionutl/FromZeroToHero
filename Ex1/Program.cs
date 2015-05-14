using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Room room1 = new Room(1, @"A beautiful room for 1 person with all facilities inclued", 1,
                                 2, RoomTypes.Single);

            Room room2 = new Room(2, @"A beautiful room for 2 person with a beautiful view towords the city cener", 2,
                                   7, RoomTypes.Double);

            Property property1 = new Hotel("Unirea Hotel", @"Unirea Hotel is one of the most good looking hotel in Iasi Romania.",
                                    @"Piaţa Unirii Street No. 5, 700056 Iaşi, Romania", 4, 1.6, new DateTime(1975, 10, 25),
                                    new Room[] { room1, room2 }, 6500);

            Room room3 = new Room(1, @"A beautiful room for 1 person with all facilities inclued", 1,
                                2, RoomTypes.Single);

            Room room4 = new Room(2, @"A beautiful room for 2 person with a beautiful view towords the city cener", 2,
                                   7, RoomTypes.Double);

            Property property2 = new GuestHouse("Unirea Hotel", @"Unirea Hotel is one of the most good looking hotel in Iasi Romania.",
                                    @"Piaţa Unirii Street No. 5, 700056 Iaşi, Romania", 4, 1.6, new DateTime(1975, 10, 25),
                                    new Room[] { room3, room4 }, 7);


            double p1Rating = property1.CalculateRating();
            Console.WriteLine("{0} has a rating of {1}", property1.Name, p1Rating);

            double p2Rating = property2.CalculateRating();
            Console.WriteLine("{0} has a rating of {1}", property2.Name, p2Rating);
        }
    }
}
