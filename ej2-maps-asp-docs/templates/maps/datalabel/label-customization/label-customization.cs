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
            ViewBag.usa = GetUSMap();
            ViewBag.usmap = GetUnitedStatesMap();
            return View();
        }
        public object GetUSMap()
        {
            string allText = System.IO.File.ReadAllText("./wwwroot/scripts/MapsData/USA.js");
            return JsonConvert.DeserializeObject(allText);
        }
        public object GetUnitedStatesMap()
        {
            string text = System.IO.File.ReadAllText(Server.MapPath("~/App_Data/USA.json"));
            return JsonConvert.DeserializeObject(text, typeof(object));
        }
    }
}