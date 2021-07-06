﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CTSupply.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Who we are";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Email Us";

            return View();
        }
    }
}