using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    public enum RoomTypes
    {
        Single,
        Double,
        Twin,
        Duplex,
        KingBedroom
    }

    public class Room
    {
        public RoomTypes type;
        public string description;
        public int places;
        public int number;
        public int floor;

        public Room(int number, string description, int places, int floor, RoomTypes type)
        {
            this.number = number;
            this.description = description;
            this.places = places;
            this.floor = floor;
            this.type = type;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Details of Room {0}", number);
            Console.WriteLine("\t Description: {0}", description);
            Console.WriteLine("\t Maximul allowed persons: {0}", places);
            Console.WriteLine("\t Floor: {0}", floor);
            Console.WriteLine("\t Type: {0}", type);
        }
    }
}
