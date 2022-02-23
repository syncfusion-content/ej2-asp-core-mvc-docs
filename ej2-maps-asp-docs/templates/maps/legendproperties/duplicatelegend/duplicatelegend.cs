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
            ViewBag.legendData = GetLegendData();
            ViewBag.legendData1 = GetLegendData1();
            ViewBag.worldMap = GetMap();
            return View();
        }
        public object GetWorldMap()
        {
            string allText = System.IO.File.ReadAllText("./wwwroot/scripts/MapsData/WorldMap.json");
            return JsonConvert.DeserializeObject(allText);
        }
        public object GetPopulationData()
        {
            string text = System.IO.File.ReadAllText("./wwwroot/scripts/MapsData/LegendData.json");
            return JsonConvert.DeserializeObject(text);
        }
         public object GetLegendData()
        {
            string text = System.IO.File.ReadAllText("./wwwroot/scripts/MapsData/populationdensity.js");
            return JsonConvert.DeserializeObject(text);
        }
        public object GetMap()
        {
            string allText = System.IO.File.ReadAllText(Server.MapPath("~/App_Data/WorldMap.json"));
            return JsonConvert.DeserializeObject(allText, typeof(object));
        }
        public object GetLegendData1()
        {
            string allText = System.IO.File.ReadAllText(Server.MapPath("~/App_Data/LegendData.json"));
            return JsonConvert.DeserializeObject(allText, typeof(object));
        }
    }
}
