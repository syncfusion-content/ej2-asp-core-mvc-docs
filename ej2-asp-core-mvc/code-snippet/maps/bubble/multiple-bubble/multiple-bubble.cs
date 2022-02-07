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
                new BubbleData { country= "United States", femaleRatio=50.50442726, maleRatio=49.49557274, femaleRatioColor="green", maleRatioColor="blue" },
                new BubbleData { country= "India", femaleRatio=48.18032713, maleRatio=51.81967287, femaleRatioColor="blue", maleRatioColor="#c2d2d6" },
                new BubbleData { country= "Oman", femaleRatio=34.15597234, maleRatio=65.84402766, femaleRatioColor="#09156d", maleRatioColor="orange" },
                new BubbleData {  country= "United Arab Emirates", femaleRatio=27.59638942, maleRatio=72.40361058, femaleRatioColor="#09156d", maleRatioColor="orange" }
            };
            List<BubbleData> data1 = new List<BubbleData>
            {
                new BubbleData { country= "United States", femaleRatio=50.50442726, maleRatio=49.49557274, femaleRatioColor="green", maleRatioColor="blue" },
                new BubbleData { country= "India", femaleRatio=48.18032713, maleRatio=51.81967287, femaleRatioColor="blue", maleRatioColor="#c2d2d6" },
                new BubbleData { country= "Oman", femaleRatio= 34.15597234, maleRatio=65.84402766, femaleRatioColor="#09156d", maleRatioColor="orange" },
                new BubbleData { country= "United Arab Emirates", femaleRatio= 27.59638942, maleRatio=72.40361058, femaleRatioColor="#09156d", maleRatioColor="orange" }
            };
            ViewBag.bubbleData = data;
            ViewBag.bubblesData = data1;
            MapsBubble bubble = new MapsBubble();
            bubble.Visible = true;
            bubble.ValuePath = "femaleRatio";
            bubble.ColorValuePath = "femaleRatioColor";
            bubble.MinRadius = 5;
            bubble.MaxRadius = 20;
            bubble.DataSource = ViewBag.bubbleData;
            MapsBubble bubble1 = new MapsBubble();
            bubble1.Visible = true;
            bubble1.ValuePath = "maleRatio";
            bubble1.ColorValuePath = "maleRatioColor";
            bubble1.MinRadius = 15;
            bubble1.MaxRadius = 25;
            bubble1.DataSource = ViewBag.bubblesData;
            bubble1.BubbleType = Syncfusion.EJ2.Maps.BubbleType.Circle;
            bubble1.Opacity = 0.4;
            List<MapsBubble> bubbleSettings = new List<MapsBubble>();
            bubbleSettings.Add(bubble);
            bubbleSettings.Add(bubble1);
            ViewBag.bubbleSettings = bubbleSettings;
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
            public string country { get; set; }
            public double femaleRatio { get; set; }
            public double maleRatio { get; set; }
            public string femaleRatioColor { get; set; }
            public string maleRatioColor { get; set; }
        }
    }
}
