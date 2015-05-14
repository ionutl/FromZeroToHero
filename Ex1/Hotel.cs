using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    sealed class Hotel : Property
    {
        public int Likes { get; set; }
        public Hotel(string name, string description, string address, int stars,
                    double distanceToCenter, DateTime openingDate, Room[] rooms, int likes)
            : base(name, description, address, stars, distanceToCenter, openingDate, rooms)
        {
            Likes = likes;
        }

        public void ChangeAddress(string value)
        {
            if (value.Length <= 100)
            {
                address = value;
            }
            else
                address = string.Empty;
        }

        public override double CalculateRating()
        {
            int trimLikes = Likes > 10000 ? 10000 : Likes;
            return trimLikes / 1000 * 0.3 + 2 * Stars * 0.7;
        }
    }
}
