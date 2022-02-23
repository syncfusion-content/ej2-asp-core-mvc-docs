using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EJ2_Core_Application.Models;
using Newtonsoft.Json;
using Syncfusion.EJ2;
using Syncfusion.EJ2.Charts;

namespace EJ2_Core_Application.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.world_map = GetWorldMap();
            ViewBag.unCountries = GetUnCountries();
            ViewBag.unitedCountries = GetUnitedCountries();
            ViewBag.worldMap = GetMap();
            return View();
        }
        public object GetUnCountries()
        {
            string allText = System.IO.File.ReadAllText("./wwwroot/scripts/MapsData/uncountries.json");
            return JsonConvert.DeserializeObject(allText);
        }
        public object GetWorldMap()
        {
            string text = System.IO.File.ReadAllText("./wwwroot/scripts/MapsData/WorldMap.json");
            return JsonConvert.DeserializeObject(text);
        }
        public object GetMap()
        {
            string allText = System.IO.File.ReadAllText(Server.MapPath("~/App_Data/WorldMap.json"));
            return JsonConvert.DeserializeObject(allText, typeof(object));
        }
        public object GetUnitedCountries()
        {
            string allText = System.IO.File.ReadAllText(Server.MapPath("~/App_Data/uncountries.json"));
            return JsonConvert.DeserializeObject(allText, typeof(object));
        }
    }
}
