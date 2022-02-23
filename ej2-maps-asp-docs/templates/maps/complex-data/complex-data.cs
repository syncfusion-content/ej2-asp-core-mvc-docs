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
            ViewBag.worldmap = GetWorldMap();
            ViewBag.bubbleData = GetBubbleData();
            ViewBag.markerData = GetMarkerData();
            ViewBag.complexData = GetComplexData();
            return View();
        }
        public object GetWorldMap()
        {
            string allText = System.IO.File.ReadAllText("./wwwroot/scripts/MapsData/WorldMap.json");
            return JsonConvert.DeserializeObject(allText);
        }
        public object GetComplexData()
        {
            string allText = System.IO.File.ReadAllText("./wwwroot/scripts/MapsData/ComplexData.json");
            return JsonConvert.DeserializeObject(allText);
        }
        public object GetBubbleData()
        {
            string allText = System.IO.File.ReadAllText("./wwwroot/scripts/MapsData/BubbleData.json");
            return JsonConvert.DeserializeObject(allText);
        }
        public object GetMarkerData()
        {
            string allText = System.IO.File.ReadAllText("./wwwroot/scripts/MapsData/MarkerData.json");
            return JsonConvert.DeserializeObject(allText);
        }
    }
}
