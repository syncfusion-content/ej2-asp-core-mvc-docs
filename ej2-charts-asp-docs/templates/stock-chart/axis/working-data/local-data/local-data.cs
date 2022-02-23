using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EJ2CoreSampleBrowser.Controllers.StockChart
{
    public partial class StockChartController : Controller
    {
        public IActionResult Default()
        {
            return View();
        }
        public class ChartData
        {
            public DateTime x;
            public double high;
            public double low;
            public double close;
            public double open;
            public int volume;
        }
    }
}