﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace print_kita.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            if (Session["activeUser"] == null)
                Response.Redirect("/Login", true);

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
    }
}