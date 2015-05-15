﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FZTHMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpGet]
        public string Hello(Person person)
        {
            return person.ToString();
        }
    }
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public override string ToString()
        {
            return String.Format("Hello {0} of age {1}", Name, Age);
        }
    }
    
    
}