using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    public class Room
    {
        public string description;
        public int places;
        public int number;
        public int floor;
        public enum RoomTypes
        {
            Single,
            Double,
            Twin,
            Duplex,
            KingBedroom
        };
    }
}
