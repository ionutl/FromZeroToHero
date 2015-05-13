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
            hotel.HotelName( "Unirea Hotel");
            hotel.HotelDescription( @"Unirea Hotel is one of the most good looking hotel in Iasi Romania.");
            hotel.HotelAddress( "Piaţa Unirii Street No. 5, 700056 Iaşi, Romania");
            hotel.HotelStars( 4);
            hotel.HotelDistanceToCenter(1.6);
            hotel.HotelOpeningDate( new DateTime(1975, 10, 25));

            Room room1 = new Room();
            room1.RoomRoomTypes(RoomTypes.Single);
            room1.RoomDescription( @"A beautiful room for 1 person with all facilities inclued");
            room1.RoomPlaces( 1);
            room1.RoomNumber( 1);
            room1.RoomFloor( 2);

            Room room2 = new Room();
            room2.RoomRoomTypes( RoomTypes.Double);
            room2.RoomDescription(@"A beautiful room for 2 person with a beautiful view towords the city cener");
            room2.RoomPlaces(2);
            room2.RoomNumber( 2);
            room2.RoomFloor( 7);

            hotel.rooms = new Room[] { room1, room2 };

            hotel.DisplayInfo();

            
        }
    }
}
