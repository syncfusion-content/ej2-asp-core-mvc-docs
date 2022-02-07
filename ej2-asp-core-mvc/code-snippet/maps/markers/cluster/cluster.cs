using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Syncfusion.EJ2.Maps;
using System.Web.Script.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using EJ2MVCSampleBrowser.Models;

namespace EJ2MVCSampleBrowser.Controllers.Maps
{
    public partial class MapsController : Controller
    {
        // GET: MarkerClustering
        public ActionResult MarkerClustering()
        {
            ViewBag.shapeData = GetWorldMap();
            ViewBag.clusterdata = GetClusterData();
            return View();
        }
        public object GetWorldMap()
        {
            string allText = System.IO.File.ReadAllText("./wwwroot/scripts/MapsData/WorldMap.js");
            return JsonConvert.DeserializeObject(allText);
        }
        public object GetClusterData()
        {
            string text = System.IO.File.ReadAllText("./wwwroot/scripts/MapsData/ClusterData.js");
            return JsonConvert.DeserializeObject(text, typeof(object));
        }
        
    }
}
