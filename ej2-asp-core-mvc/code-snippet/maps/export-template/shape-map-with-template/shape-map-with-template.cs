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
            ViewBag.usa = GetUSMap();
            List<MarkerData> data = new List<MarkerData>
            {
                 new MarkerData {latitude= 31.85866353245237, longitude= -99.06254504620819, name= "Texas" },
                 new MarkerData {latitude= 38.04814225870669, longitude= -92.39290879419217, name= "Missouri" },
                 new MarkerData {latitude= 46.71856608662662, longitude= -109.02246313616106, name= "Montana" }
            };
            ViewBag.markerData = data;
            return View();
        }
        public class MarkerData
        {
            public double latitude { get; set; }
            public double longitude { get; set; }
            public string name { get; set; }
        }

        public object GetUSMap()
        {
            string allText = System.IO.File.ReadAllText("./wwwroot/usa.json");
            return JsonConvert.DeserializeObject(allText);
        }

        public object GetUSMap()
        {
            string allText = System.IO.File.ReadAllText(Server.MapPath("~/App_Data/usa.json"));
            return JsonConvert.DeserializeObject(allText, typeof(object));
        }
    }
}