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
            ViewBag.africaMap = GetAfricaMap();
            ViewBag.africaMapShape = GetAfricaMapShape();
            return View();
        }
        public object GetAfricaMap()
        {
            string allText = System.IO.File.ReadAllText("./wwwroot/scripts/MapsData/Africa.json");
            return JsonConvert.DeserializeObject(allText);
        }
		
        public object GetAfricaMapShape()
        {
            string allText = System.IO.File.ReadAllText(Server.MapPath("~/App_Data/Africa.json"));
            return JsonConvert.DeserializeObject(allText, typeof(object));
        }
    }
}
