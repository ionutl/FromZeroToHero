using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FZTHMVC.DataAccess;

namespace FZTHMVC.Controllers
{
    public class HotelController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View(Data.Hotels);
        }

        public ActionResult addHotel()
        {
            return View();
        }

       public ActionResult Detail(Int32 id)
        {
            var hotel = FZTHMVC.DataAccess.Data.Hotels.FirstOrDefault(x => x.Id == id);
            if (hotel != null)
            {
                return Json(hotel, JsonRequestBehavior.AllowGet);
            }
            return HttpNotFound();
        }
	}
}