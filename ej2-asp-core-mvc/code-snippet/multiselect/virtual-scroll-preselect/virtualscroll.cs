﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class MultiSelectController : Controller
    {
        public ActionResult virtualscroll()
        {
            ViewBag.data = new Record().RecordModelList();
            ViewBag.value = new string[] { "id5", "id14", "id25" };
            return View();
        }
    }
}