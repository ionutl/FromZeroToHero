using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
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
        public bool HasAirConditioning { get; set; }
        public bool HasFlatTVScreen { get; set; }
        private string description;
        public string Description
        {
            get { return description; }
            set
            {
                if (value.Length <= 500)
                    description = value;
                else
                    Console.WriteLine("Error! Name must be less than 500 characters!");
            }
        }

        private int floor;
        public int Floor
        {
            get { return floor; }
            set
            {
                if ((value >= 0)&& (value <= 10000))
                    floor = value;
                else
                    Console.WriteLine("Error! Can't be negative or is too much!");
            }
        }

        private int number;
        public int Number
        {
            get { return number; }
            set
            {
                if ((value >= 0) && (value <= 10000))
                    number = value;
                else
                    Console.WriteLine("Error! Can't be negative or is too much!");
            }
        }

        private RoomTypes type;
        public RoomTypes Type
        {
            get { return type; }
            set
            {
                type = value;
                switch (value)
                {
                    case RoomTypes.Single:
                    case RoomTypes.Double:
                    case RoomTypes.Twin: places = 1; break;
                    case RoomTypes.KingBedroom:
                    case RoomTypes.Duplex: places = 2; break;
                }
            }
        }

        private int places;
        public int Places
        {
            get { return places; }
            set
            {
                switch (Type)
                {
                    case RoomTypes.Single:
                        {
                            places = value == 1 ? value : 0;
                            break;
                        }
                    case RoomTypes.Double:
                    case RoomTypes.Twin:
                        {
                            places = value >= 1 && value <= 2 ? value : 0;
                            break;
                        }
                    case RoomTypes.KingBedroom:
                        {
                            places = value >= 2 && value <= 4 ? value : 0;
                            break;
                        }
                    case RoomTypes.Duplex:
                        {
                            places = value >= 2 && value <= 6 ? value : 0;
                            break;
                        }
                }
            }
        }

        public Room(int number, string description, int places, int floor, RoomTypes type)
        {
            this.Number = number;
            this.Description = description;
            this.Places = places;
            this.Floor = floor;
            this.Type = type;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Details of Room {0}", Number);
            Console.WriteLine("\t Description: {0}", Description);
            Console.WriteLine("\t Maximul allowed persons: {0}", Places);
            Console.WriteLine("\t Floor: {0}", Floor);
            Console.WriteLine("\t Type: {0}", Type);
        }
    }
}
