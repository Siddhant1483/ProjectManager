﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TaskManager.API.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var i = 10;
            ViewBag.Title = "Mahesh Home Page";

            return View();
        }
    }
}
