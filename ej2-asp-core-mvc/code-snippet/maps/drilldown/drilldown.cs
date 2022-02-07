using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EJ2_Core_Application.Models;
using Newtonsoft.Json;
using Syncfusion.EJ2.Charts;

namespace EJ2_Core_Application.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.worldmap = GetWorldMap();
            ViewBag.africa = GetAfricaMap();
            return View();
        }
        public object GetWorldMap()
        {
            string text = System.IO.File.ReadAllText("./wwwroot/scripts/MapsData/WorldMap.json");
            return JsonConvert.DeserializeObject(text);
        }
        public object GetAfricaMap()
        {
            string text = System.IO.File.ReadAllText("./wwwroot/scripts/MapsData/Africa.json");
            return JsonConvert.DeserializeObject(text);
        }
    }
}