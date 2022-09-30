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
            List<MarkerData> data = new List<MarkerData>
            {
                 new MarkerData {latitude= 34.060620, longitude= -118.330491, city= "California" },
                 new MarkerData {latitude= 40.724546, longitude= -73.850344, city= "New York" }
            };
            ViewBag.markerData = data;
            return View();
        }
        public class MarkerData
        {
            public double latitude { get; set; }
            public double longitude { get; set; }
            public string city { get; set; }
        }
    }
}
