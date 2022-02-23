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
            ViewBag.usamap = GetUSAMap();
            return View();
        }
        public object GetUSMap()
        {
            string text = System.IO.File.ReadAllText("./wwwroot/scripts/MapsData/USA.json");
            return JsonConvert.DeserializeObject(text);
        }
        public object GetUSAMap()
        {
            string allText = System.IO.File.ReadAllText(Server.MapPath("~/App_Data/USA.json"));
            return JsonConvert.DeserializeObject(text);
        }
    }
}