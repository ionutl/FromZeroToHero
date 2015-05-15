using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FZTHMVC.Controllers
{
    public class HotelController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return Content("Here will be the list of hotels.");
        }
	}
}