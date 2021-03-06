﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Design_Pattern.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
         
        public ActionResult About()
        {
            ViewBag.Message = "About the MVC Design Pattern";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Developer Details";

            return View();
        }
    }
}