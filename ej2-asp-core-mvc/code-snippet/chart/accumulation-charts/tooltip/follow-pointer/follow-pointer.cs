using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EJ2CoreSampleBrowser.Controllers.Chart
{
    public partial class ChartController : Controller
    {
        public IActionResult FollowPointer()
        {
            ViewBag.dataSource = new List<object>()
            {
                new { x = "Coal", y = 34.4, text = "Coal: 34.4%" },
                new { x = "Natural Gas", y = 22.1, text = "Natural Gas: 22.1%" },
                new { x = "Hydro", y = 14.4, text = "Hydro: 14.4%" },
                new { x = "Nuclear", y = 9.0, text = "Nuclear: 9.0%" },
                new { x = "Wind", y = 8.1, text = "Wind: 8.1%" },
                new { x = "Others", y = 12.0, text = "Others: 12.0%" }
            };

            return View();
        }
    }
}