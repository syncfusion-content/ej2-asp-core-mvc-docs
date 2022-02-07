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
            List<BubbleData> data = new List<BubbleData>
            {
                new BubbleData { name= "Australia", population= "383521" },
                new BubbleData { name= "Pakistan", population= "3090416" },
                new BubbleData { name= "Russia", population= "30916" }
            };
            ViewBag.bubbleData = data;
            return View();
        }
        public object GetWorldMap()
        {
            string allText = System.IO.File.ReadAllText("./wwwroot/scripts/MapsData/world_map.js");
            return JsonConvert.DeserializeObject(allText);
        }
        public object GetMap()
        {
            string allText = System.IO.File.ReadAllText(Server.MapPath("~/App_Data/WorldMap.json"));
            return JsonConvert.DeserializeObject(allText, typeof(object));
        }
        public class BubbleData
        {
            public string name { get; set; }
            public string population { get; set; }
        }
    }
}
