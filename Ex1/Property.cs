using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Property
    {
        #region Fields
        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                if (value.Length <= 50)
                {
                    name = value;
                }
                else
                {
                    name = string.Empty;
                }
            }
        }

        private string description;
        public string Description
        {
            get { return description; }
            set
            {
                if (value.Length <= 500)
                {
                    description = value;
                }
                else
                {
                    description = string.Empty;
                }
            }
        }

        protected string address;
        public string Address
        {
            get { return address; }
            set
            {
                if (value.Length <= 100)
                {
                    address = value;
                }
                address = string.Empty;
            }
        }

        private int stars;
        public int Stars
        {
            get { return stars; }
            set
            {
                if (value >= 0 && value <= 5)
                {
                    stars = value;
                }
                else
                {
                    stars = 0;
                }
            }
        }

        private double distanceToCenter;
        public double DistanceToCenter
        {
            get { return distanceToCenter; }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    distanceToCenter = value;
                }
                else
                {
                    distanceToCenter = 0;
                }
            }
        }

        private DateTime openingDate;
        public DateTime OpeningDate
        {
            get { return openingDate; }
            set
            {
                if (value >= new DateTime(1800, 1, 1) && value <= DateTime.Now)
                {
                    openingDate = value;
                }
                else
                {
                    openingDate = DateTime.Now;
                }
            }
        }

        private Room[] rooms;
        public Room[] Rooms
        {
            get { return rooms; }
            set { rooms = value; }
        }

        public bool HasIndoorPool { get; set; }
        public bool HasWireless { get; set; }

        private static string distanceMesurementUnit;
        #endregion

        static Property()
        {
            distanceMesurementUnit = "Miles";
        }
        public Property()
        {

        }

        public Property(string name, string description, string address, int stars,
                    double distanceToCenter, DateTime openingDate, Room[] rooms)
        {
            this.Name = name;
            this.Description = description;
            this.Address = address;
            this.Stars = stars;
            this.DistanceToCenter = distanceToCenter;
            this.OpeningDate = openingDate;
            this.rooms = rooms;
        }

        public double GetDistanceToCenter(string unit)
        {
            if (unit == "KM")
            {
                if (distanceMesurementUnit == "KM")
                {
                    return distanceToCenter;
                }
                else
                {
                    return DistanceConverter.ConvertMilesToKilometers(distanceToCenter);
                }
            }
            else if (unit == "Miles")
            {
                if (distanceMesurementUnit == "KM")
                {
                    return DistanceConverter.ConvertKilometersToMiles(distanceToCenter);
                }
                else
                {
                    return distanceToCenter;
                }
            }
            return distanceToCenter;
        }

        public static void SetDistanceMesurementUnit(string measurementUnit)
        {
            distanceMesurementUnit = measurementUnit;
        }

        public static string GetDistanceMesurementUnit()
        {
            return distanceMesurementUnit;
        }

        public virtual double CalculateRating()
        {
            return 2 * stars;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Details of Hotel: {0}", Name);
            Console.WriteLine("Description: {0}", Description);
            Console.WriteLine("Address: {0}", Address);
            Console.WriteLine("Stars {0}", new string('*', Stars));
            Console.WriteLine("Distance to center: {0} {1}", DistanceToCenter, distanceMesurementUnit);
            Console.WriteLine("Opening Date: {0}", OpeningDate.ToShortDateString());
            foreach (Room room in Rooms)
            {
                room.DisplayInfo();
            }
        }
    }
}
