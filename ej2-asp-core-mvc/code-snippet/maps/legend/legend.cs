using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Suncfusion.EJ2.Maps;
using EJ2_Core_Application.Models;
using Newtonsoft.Json;

namespace EJ2_Core_Application.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.world_map = GetWorldMap();
            ViewBag.worldMap = GetMap();
            ViewBag.unCountries = GetElectionData();
            ViewBag.uncountries = GetData();
            return View();
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
        public object GetData()
        {
            string allText = System.IO.File.ReadAllText(Server.MapPath("~/App_Data/electiondata.json"));
            return JsonConvert.DeserializeObject(allText, typeof(object));
        }
        public object GetElectionData()
        {
            string text = System.IO.File.ReadAllText("./wwwroot/scripts/MapsData/electiondata.json");
            return JsonConvert.DeserializeObject(text);
        }
    }
}
