using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EJ2CoreSampleBrowser.Controllers.Chart
{
    public partial class ChartController : Controller
    {
        public IActionResult TooltipDistance()
        {
            List<ChartData> vietnamData = new List<ChartData>
            {
                new ChartData { x = 2016, y = 7.8 },
                new ChartData { x = 2017, y = 10.3 },
                new ChartData { x = 2018, y = 15.5 },
                new ChartData { x = 2019, y = 17.5 },
                new ChartData { x = 2020, y = 19.5 },
                new ChartData { x = 2021, y = 23.0 },
                new ChartData { x = 2022, y = 20.0 },
                new ChartData { x = 2023, y = 19.0 },
                new ChartData { x = 2024, y = 22.1 }
            };

            List<ChartData> polandData = new List<ChartData>
            {
                new ChartData { x = 2016, y = 8.9 },
                new ChartData { x = 2017, y = 10.3 },
                new ChartData { x = 2018, y = 10.8 },
                new ChartData { x = 2019, y = 9.0 },
                new ChartData { x = 2020, y = 7.9 },
                new ChartData { x = 2021, y = 8.5 },
                new ChartData { x = 2022, y = 7.4 },
                new ChartData { x = 2023, y = 6.4 },
                new ChartData { x = 2024, y = 7.1 }
            };

            ViewBag.vietnamData = vietnamData;
            ViewBag.polandData = polandData;

            return View();
        }

        public class ChartData
        {
            public double x;
            public double y;
        }
    }
}