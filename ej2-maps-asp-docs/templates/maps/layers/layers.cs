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
            ViewBag.california = GetCaliforniaMap();
            ViewBag.texas = GetTexasMap();
            ViewBag.usamap = GetUSMaps();
            ViewBag.californiamap = GetCaliforniaMaps();
            ViewBag.texasmap = GetTexasMaps();
            return View();
        }
        public object GetUSMap()
        {
            string allText = System.IO.File.ReadAllText("./wwwroot/USA.json");
            return JsonConvert.DeserializeObject(allText);
        }
        public object GetCaliforniaMap()
        {
            string allText = System.IO.File.ReadAllText("./wwwroot/California.json");
            return JsonConvert.DeserializeObject(allText);
        }
        public object GetTexasMap()
        {
            string allText = System.IO.File.ReadAllText("./wwwroot/Texas.json");
            return JsonConvert.DeserializeObject(allText);
        }
        public object GetUSMaps()
        {
            string allText = System.IO.File.ReadAllText(Server.MapPath("~/App_Data/USA.json"));
            return JsonConvert.DeserializeObject(allText, typeof(object));
        }
        public object GetCaliforniaMaps()
        {
            string allText = System.IO.File.ReadAllText(Server.MapPath("~/App_Data/California.json"));
            return JsonConvert.DeserializeObject(allText, typeof(object));
        }
        public object GetTexasMaps()
        {
            string allText = System.IO.File.ReadAllText(Server.MapPath("~/App_Data/Texas.json"));
            return JsonConvert.DeserializeObject(allText, typeof(object));
        }
    }
}
