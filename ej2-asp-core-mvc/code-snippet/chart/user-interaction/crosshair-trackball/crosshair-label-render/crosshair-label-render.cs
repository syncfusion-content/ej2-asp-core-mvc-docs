using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EJ2CoreSampleBrowser.Controllers.Chart
{
    public partial class ChartController : Controller
    {
        public IActionResult CrosshairLabelRender()
        {

            ViewBag.dataSource = new List<object>()
            {
                new { x = "January", y = 1200 },
                new { x = "February", y = 900 },
                new { x = "March", y = 1500 },
                new { x = "April", y = 700 },
                new { x = "May", y = 2000 },
                new { x = "June", y = 300 }
            };

            return View();
        }
    }
}