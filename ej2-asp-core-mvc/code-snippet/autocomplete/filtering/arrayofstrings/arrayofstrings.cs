﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class AutoCompleteController : Controller
    {
        public ActionResult arrayofstring()
        {
            ViewBag.data = new string[] { "Badminton", "Basketball", "Cricket", "Football", "Golf", "Gymnastics", "Hockey", "Tennis" };
            return View();
        }
    }
}