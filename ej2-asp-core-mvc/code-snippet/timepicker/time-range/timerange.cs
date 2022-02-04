﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EJ2CoreSampleBrowser.Controllers
{
    public class HomeController: Controller
    {
        public ActionResult DefaultFunctionalities()
        {
            ViewBag.minVal= new DateTime(2017,08,03, 09,00,00);
            ViewBag.maxVal = new DateTime(2017,08,03, 11,30,00);
            ViewBag.value =  new DateTime(2017,08,03, 11,00,00);
            return View();
        }
    }
}
