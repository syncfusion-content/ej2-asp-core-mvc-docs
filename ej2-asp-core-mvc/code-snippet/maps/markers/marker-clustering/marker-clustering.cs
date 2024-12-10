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
            ViewBag.shapeData = this.GetWorldMap();
            ViewBag.shape_Data = this.GetWMap();
            ViewBag.ClusterData = this.ClusterData();
            ViewBag.Cluster_data = this.getData();
            return View();
        }
        public object ClusterData()
        {
            string allText = System.IO.File.ReadAllText(Server.MapPath("~/App_Data/MapData/ClusterData.json"));
            return JsonConvert.DeserializeObject(allText, typeof(object));
        }
        public object GetWorldMap()
        {
            string allText = System.IO.File.ReadAllText("./wwwroot/scripts/MapsData/WorldMap.js");
            return JsonConvert.DeserializeObject(allText);
        }
        public object getData()
        {
            string allText = System.IO.File.ReadAllText(Server.MapPath("./wwwroot/scripts/MapsData/ClusterData.json"));
            return JsonConvert.DeserializeObject(allText, typeof(object));
        }
        public object GetWMap()
        {
            string allText = System.IO.File.ReadAllText(Server.MapPath("~/App_Data/WorldMap.json"));
            return JsonConvert.DeserializeObject(allText, typeof(object));
        }
    }
}
