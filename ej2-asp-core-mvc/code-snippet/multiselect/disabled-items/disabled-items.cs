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
       public ActionResult Index()
        {
            ViewBag.data = new Tag().TagDataList();
            return View();
        }     
    }
}