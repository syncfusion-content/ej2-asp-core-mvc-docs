using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace EJ2MVCSampleBrowser.Controllers.CircularChart3D
{
    public partial class CircularChart3DController : Controller
    {
        public ActionResult InlineFormat()
        {
            List<CircularChart3DData> chartData = new List<CircularChart3DData>
            {
                new CircularChart3DData { x = new DateTime(2024, 01, 01), y = 13 },
                new CircularChart3DData { x = new DateTime(2024, 02, 01), y = 13 },
                new CircularChart3DData { x = new DateTime(2024, 03, 01), y = 17 },
                new CircularChart3DData { x = new DateTime(2024, 04, 01), y = 13.5 }
            };
            ViewBag.dataSource = chartData;
            return View();
        }
    }

    public class CircularChart3DData
    {
        public DateTime x { get; set; }
        public double y { get; set; }
    }
}