using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Syncfusion.EJ2.Maps;
using Newtonsoft.Json;

namespace EJ2_Core_Application.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			ViewBag.world_map = GetWorldMap();
			ViewBag.populationData = GetPopulationData();
            ViewBag.worldMap = GetMap();
            ViewBag.populationDensity = GetPopulationDensity();
			return View();
		}
		public object GetWorldMap()
		{
			string allText = System.IO.File.ReadAllText("./wwwroot/scripts/MapsData/WorldMap.json");
			return JsonConvert.DeserializeObject(allText);
		}
		public object GetPopulationData()
		{
			string text = System.IO.File.ReadAllText("./wwwroot/scripts/MapsData/populationdensity.js");
			return JsonConvert.DeserializeObject(text);
		}
		public object GetPopulationData()
        {
            string text = System.IO.File.ReadAllText("./wwwroot/scripts/MapsData/populationdensity.json");
            return JsonConvert.DeserializeObject(text);
        }
        public object GetMap()
        {
            string allText = System.IO.File.ReadAllText(Server.MapPath("~/App_Data/WorldMap.json"));
            return JsonConvert.DeserializeObject(allText, typeof(object));
        }
        public object GetPopulationDensity()
        {
            string allText = System.IO.File.ReadAllText(Server.MapPath("~/App_Data/populationdensity.json"));
            return JsonConvert.DeserializeObject(allText, typeof(object));
        }
	}
}