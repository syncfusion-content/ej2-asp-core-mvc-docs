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
            ViewBag.usmap = GetUSMap();
            ViewBag.usMap = GetMap();
            return View();
        }
        public object GetUSMap()
        {
            string allText = System.IO.File.ReadAllText("./wwwroot/scripts/MapsData/USA.json");
            return JsonConvert.DeserializeObject(allText);
        }
        public object GetMap()
        {
            string allText = System.IO.File.ReadAllText(Server.MapPath("~/App_Data/USA.json"));
            return JsonConvert.DeserializeObject(allText, typeof(object));
        }
    }
}
