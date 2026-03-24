using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EJ2CoreSampleBrowser.Controllers.Chart
{
    public partial class ChartController : Controller
    {
        public IActionResult FollowPointer()
        {
            List<ChartData> chartData = new List<ChartData>
            {
                new ChartData { x = "Coal", y = 34.4, text = "Coal: 34.4%" },
                new ChartData { x = "Natural Gas", y = 22.1, text = "Natural Gas: 22.1%" },
                new ChartData { x = "Hydro", y = 14.4, text = "Hydro: 14.4%" },
                new ChartData { x = "Nuclear", y = 9.0, text = "Nuclear: 9.0%" },
                new ChartData { x = "Wind", y = 8.1, text = "Wind: 8.1%" },
                new ChartData { x = "Others", y = 12.0, text = "Others: 12.0%" }
            };

            ViewBag.dataSource = chartData;
            return View();
        }

        public class ChartData
        {
            public string x;
            public double y;
            public string text;
        }
    }
}