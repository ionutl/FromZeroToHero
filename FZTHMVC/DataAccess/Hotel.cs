using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FZTHMVC.DataAccess
{
    public class Hotel
    {
        public Int32 Id { get; set; }
        public String Name { get; set; }
        public String Adress { get; set; }
        public String City { get; set; }
        public String Site { get; set; }
        public Int32 Rooms { get; set; }
        public Int32 Rating { get; set; }
    }
}