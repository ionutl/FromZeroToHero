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

        public ActionResult Index1()
        {
            return View();
        }

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

        [AcceptVerbs(HttpVerbs.Get)]
        public ActionResult Create()
        {
            return View();
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Create(Hotel hotel)
        {
            var id = Data.Hotels.Max(x => x.Id);
            hotel.Id = id + 1;
            Data.Hotels.Add(hotel);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            Hotel h = new Hotel();
            foreach (Hotel h1 in Data.Hotels)
            {
                if (h1.Id == id)
                {
                    h.Name = h1.Name;
                    h.Adress = h1.Adress;
                    h.City = h1.City;
                    h.Site = h1.Site;
                    h.Rooms = h1.Rooms;
                    h.Rating = h1.Rating;
                }
            }
            return View(h);
        }

        [HttpPost]
        public ActionResult Edit(Hotel h)
        {
            if (!ModelState.IsValid)
            {
                return View("Edit", h);
            }
            foreach (Hotel h1 in Data.Hotels)
            {
                if (h1.Id == h.Id)
                {
                    h1.Name = h.Name;
                    h1.Adress = h.Adress;
                    h1.City = h.City;
                    h1.Site = h.Site;
                    h1.Rooms = h.Rooms;
                    h1.Rating = h.Rating;
                }
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var hotel = Data.Hotels.FirstOrDefault(x => x.Id == id);
            if (hotel != null)
            {
                return View(hotel);
            }
            return HttpNotFound();
        }

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            var hotel = Data.Hotels.FirstOrDefault(x => x.Id == id);
            Data.Hotels.Remove(hotel);

            return RedirectToAction("Index");
        }
	}
}