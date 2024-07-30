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
            ViewBag.worldMap = GetMap();
            return View();
        }
        
        // To access the data in Core
        public object GetWorldMap()
        {
            string allText = System.IO.File.ReadAllText("./wwwroot/scripts/MapsData/WorldMap.js");
            return JsonConvert.DeserializeObject(allText);
        }

        // To access the data in MVC
        public object GetMap()
        {
            string allText = System.IO.File.ReadAllText(Server.MapPath("~/App_Data/WorldMap.json"));
            return JsonConvert.DeserializeObject(allText, typeof(object));
        }
    }
}
