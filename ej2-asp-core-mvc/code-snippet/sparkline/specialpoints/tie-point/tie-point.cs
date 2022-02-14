using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EJ2_Core_Application.Models;
using Newtonsoft.Json;

namespace EJ2_Core_Application.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.sparkData = new int[] { 12, 15, -10, 13, 15, 6, -12, 17, 13, 0, 8, -10 };
            return View();
        }
    }
}
