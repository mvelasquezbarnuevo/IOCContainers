﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UnityContainer.Domain;

namespace UnityContainer.Controllers
{
    public class HomeController : Controller
    {
        private readonly IFakeService _service;
        public HomeController(IFakeService service)
        {
            _service = service;
        }

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
    }
}