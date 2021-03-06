﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCStart.Controllers
{
    [Authorize(Roles = "Employee, Manager")]
    public class FormsController : Controller
    {
        // GET: Forms
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Membership()
        {
            return View();
        }

        public ActionResult Demographics()
        {
            return View();
        }

        public ActionResult Equipment()
        {
            return View();
        }

        public ActionResult Maintenance()
        {
            return View();
        }
    }
}