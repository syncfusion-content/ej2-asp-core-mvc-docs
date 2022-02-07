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
            ViewBag.world_map = GetWorldMap();
            ViewBag.usa = GetUSMap();
            ViewBag.worldMap = GetWorldMaps();
            ViewBag.usaMap = GetUSMaps();
            return View();
        }
        public object GetUSMap()
        {
            string allText = System.IO.File.ReadAllText("./wwwroot/scripts/MapsData/USA.json");
            return JsonConvert.DeserializeObject(allText);
        }
        public object GetWorldMap()
        {
            string text = System.IO.File.ReadAllText("./wwwroot/scripts/MapsData/WorldMap.json");
            return JsonConvert.DeserializeObject(text);
        }
        public object GetWorldMaps()
        {
            string allText = System.IO.File.ReadAllText(Server.MapPath("~/App_Data/WorldMap.json"));
            return JsonConvert.DeserializeObject(allText, typeof(object));
        }
        public object GetUSMaps()
        {
            string allText = System.IO.File.ReadAllText(Server.MapPath("~/App_Data/USA.json"));
            return JsonConvert.DeserializeObject(allText, typeof(object));
        }
    }
}
