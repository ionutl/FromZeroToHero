using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FZTHMVC.DataAccess
{
    public class Hotel
    {
        public Int32 Id { get; set; }
        [Required]
        [StringLength(50)]
        public String Name { get; set; }
        public String Adress { get; set; }
        public String City { get; set; }
        public String Site { get; set; }
        [Required]
        [Range(1, 2000)]
        public Int32 Rooms { get; set; }
        [Required]
        [Range(1, 7)]
        public Int32 Rating { get; set; }
    }
}