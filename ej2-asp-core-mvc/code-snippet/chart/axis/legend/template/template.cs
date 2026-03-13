using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace YourProject.Controllers
{
    public class CoalController : Controller
    {
        public IActionResult Index()
        {
            // === China Data ===
            List<CoalPoint> chinaData = new List<CoalPoint>
            {
                new CoalPoint { x = 2022, y = 4152.7 },
                new CoalPoint { x = 2023, y = 4362.1 },
                new CoalPoint { x = 2024, y = 4780.0 }
            };

            // === India Data ===
            List<CoalPoint> indiaData = new List<CoalPoint>
            {
                new CoalPoint { x = 2022, y = 863.2 },
                new CoalPoint { x = 2023, y = 968.8 },
                new CoalPoint { x = 2024, y = 1085.1 }
            };

            // === Indonesia Data ===
            List<CoalPoint> indonesiaData = new List<CoalPoint>
            {
                new CoalPoint { x = 2022, y = 693.4 },
                new CoalPoint { x = 2023, y = 781.3 },
                new CoalPoint { x = 2024, y = 836.1 }
            };

            // Pass all three datasets to the View
            ViewBag.ChinaData = chinaData;
            ViewBag.IndiaData = indiaData;
            ViewBag.IndonesiaData = indonesiaData;

            return View();
        }
    }

    public class CoalPoint
    {
        public int x { get; set; }
        public double y { get; set; }
    }
}