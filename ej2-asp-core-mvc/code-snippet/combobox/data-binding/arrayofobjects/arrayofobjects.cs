﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ComboBoxController : Controller
    {
        public ActionResult arrayofobjects()
        {
            ViewBag.data = new Vegetables().VegetablesList();
            return View();
        }
    }
}