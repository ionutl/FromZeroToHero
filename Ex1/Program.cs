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
            Hotel hotel = new Hotel()
            {
                Name = "Unirea Hotel",
                Description = @"Unirea Hotel is one of the most good looking hotel in Iasi Romania.",
                Address = @"Piaţa Unirii Street No. 5, 700056 Iaşi, Romania",
                Stars = 4,
                DistanceToCenter = 1.6,
                OpeningDate = new DateTime(1975, 10, 25),
                HasIndoorPool = true,
                HasWireless = true,
                Rooms = new Room[]
                        {
                            new Room(){
                                Number = 2,
                                Description =  @"A beautiful room for 2 person with a beautiful view towords the city cener",
                                Places = 2,
                                Floor = 7,
                                Type =  RoomTypes.Double,
                                HasAirConditioning = false,
                                HasFlatTVScreen = false
                            },
                            new Room(){
                                Number = 1,
                                Description =  @"A beautiful room for 1 person with all facilities inclued",
                                Places = 1,
                                Floor = 5,
                                Type =  RoomTypes.Single,
                                HasAirConditioning = true,
                                HasFlatTVScreen = false
                            },
                        }
            };
            hotel.DisplayInfo();
        }
    }
}
