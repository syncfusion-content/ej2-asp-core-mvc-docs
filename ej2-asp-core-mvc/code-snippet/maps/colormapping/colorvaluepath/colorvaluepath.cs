using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EJ2_Core_Application.Models;
using Syncfusion.EJ2;
using Newtonsoft.Json;

namespace EJ2_Core_Application.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.world_map = GetWorldMap();
            ViewBag.populationData = GetPopulationData();
            ViewBag.populationDensity = GetPopulationDensity();
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
            string text = System.IO.File.ReadAllText("./wwwroot/scripts/MapsData/Population-density.json");
            return JsonConvert.DeserializeObject(text);
        }
        public object GetMap()
        {
            string allText = System.IO.File.ReadAllText(Server.MapPath("~/App_Data/WorldMap.json"));
            return JsonConvert.DeserializeObject(allText, typeof(object));
        }
        public object GetPopulationDensity()
        {
            string text = System.IO.File.ReadAllText(Server.MapPath("~/App_Data/Population-density.json"));
            return JsonConvert.DeserializeObject(text, typeof(object));
        }
    }
}
