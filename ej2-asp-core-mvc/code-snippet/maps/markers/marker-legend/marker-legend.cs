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
            ViewBag.world_map = GetWorldMap();
            ViewBag.markerdata = GetMarkerData();
            return View();
        }
        public object GetWorldMap()
        {
            string allText = System.IO.File.ReadAllText("./wwwroot/scripts/MapsData/WorldMap.js");
            return JsonConvert.DeserializeObject(allText);
        }
        
        public object GetMarkerData()
        {
            string allText = System.IO.File.ReadAllText("./wwwroot/scripts/MapsData/markerdata.js");
            return JsonConvert.DeserializeObject(allText);
        }
    }
}
