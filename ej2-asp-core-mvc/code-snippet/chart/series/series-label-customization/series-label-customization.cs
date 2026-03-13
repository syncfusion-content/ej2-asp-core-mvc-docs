using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EJ2CoreSampleBrowser.Controllers.Chart
{
    public partial class ChartController : Controller
    {
        public IActionResult SeriesLabelCustomization()
        {

            ViewBag.vietnamData = new List<object>()
            {
                new { x = 2016, y = 7.8 },
                new { x = 2017, y = 10.3 },
                new { x = 2018, y = 15.5 },
                new { x = 2019, y = 17.5 },
                new { x = 2020, y = 19.5 },
                new { x = 2021, y = 23.0 },
                new { x = 2022, y = 20.0 },
                new { x = 2023, y = 19.0 },
                new { x = 2024, y = 22.1 }
            };

            ViewBag.indonesiaData = new List<object>()
            {
                new { x = 2016, y = 4.8 },
                new { x = 2017, y = 5.2 },
                new { x = 2018, y = 6.2 },
                new { x = 2019, y = 7.8 },
                new { x = 2020, y = 9.3 },
                new { x = 2021, y = 14.3 },
                new { x = 2022, y = 15.6 },
                new { x = 2023, y = 16.0 },
                new { x = 2024, y = 17.0 }
            };

            ViewBag.franceData = new List<object>()
            {
                new { x = 2016, y = 14.6 },
                new { x = 2017, y = 15.5 },
                new { x = 2018, y = 15.4 },
                new { x = 2019, y = 14.4 },
                new { x = 2020, y = 11.6 },
                new { x = 2021, y = 13.9 },
                new { x = 2022, y = 12.1 },
                new { x = 2023, y = 10.0 },
                new { x = 2024, y = 10.8 }
            };

            ViewBag.polandData = new List<object>()
            {
                new { x = 2016, y = 8.9 },
                new { x = 2017, y = 10.3 },
                new { x = 2018, y = 10.8 },
                new { x = 2019, y = 9.0 },
                new { x = 2020, y = 7.9 },
                new { x = 2021, y = 8.5 },
                new { x = 2022, y = 7.4 },
                new { x = 2023, y = 6.4 },
                new { x = 2024, y = 7.1 }
            };

            ViewBag.mexicoData = new List<object>()
            {
                new { x = 2016, y = 19.0 },
                new { x = 2017, y = 20.0 },
                new { x = 2018, y = 20.2 },
                new { x = 2019, y = 18.4 },
                new { x = 2020, y = 16.8 },
                new { x = 2021, y = 18.5 },
                new { x = 2022, y = 18.4 },
                new { x = 2023, y = 16.3 },
                new { x = 2024, y = 13.7 }
            };

            return View();
        }
    }
}