using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FZTHMVC.DataAccess
{
    public static class Data
    {
        public static List<Hotel> Hotels
        {
            get
            {
                return new List<Hotel>()
                {
                    new Hotel
                    {
                        Id = 1,
                        Name = "Hotel International",
                        Adress = "DFescriere hotel International",
                        City = "Iasi",
                        Site = "http://www.grandhoteltraian.ro",
                        Rooms = 30,
                        Rating = 4  
                    },
                    new Hotel
                    {
                        Id = 2,
                        Name = "Hotel Unique",
                        Adress = "Descriere national",
                        City = "Bucuresti",
                        Site = "http://www.grandhoteltraian.ro",
                        Rooms = 15,
                        Rating = 2 
                    },
                    new Hotel
                    {
                        Id = 2,
                        Name = "Hotel Mariko",
                        Adress = "Descriere",
                        City = "Bacau",
                        Site = "http://www.grandhoteltraian.ro",
                        Rooms = 10,
                        Rating = 1 
                    }
                };
            }
        }
    }
}