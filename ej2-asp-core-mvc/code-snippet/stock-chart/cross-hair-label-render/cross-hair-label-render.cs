using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace EJ2CoreSampleBrowser.Controllers.StockChart
{
    public partial class StockChartController : Controller
    {
        public IActionResult CrosshairLabel()
        {
            List<StockData> chartData = new List<StockData>
            {
                new StockData { x = new DateTime(2012,4,2), open = 320.70, high = 324.07, low = 317.73, close = 323.78, volume = 45638000 },
                new StockData { x = new DateTime(2012,4,3), open = 323.02, high = 324.29, low = 319.63, close = 321.63, volume = 40857000 },
                new StockData { x = new DateTime(2012,4,4), open = 319.54, high = 319.81, low = 315.86, close = 317.89, volume = 32519000 },
                new StockData { x = new DateTime(2012,4,5), open = 316.43, high = 318.53, low = 314.59, close = 316.47, volume = 46327000 },
                new StockData { x = new DateTime(2012,4,9), open = 314.55, high = 317.98, low = 312.95, close = 315.73, volume = 43610000 },
                new StockData { x = new DateTime(2012,4,10), open = 317.07, high = 317.56, low = 312.58, close = 313.74, volume = 49590000 },
                new StockData { x = new DateTime(2012,4,11), open = 317.30, high = 318.31, low = 315.96, close = 318.29, volume = 43936000 },
                new StockData { x = new DateTime(2012,4,12), open = 321.49, high = 326.89, low = 320.45, close = 325.83, volume = 11501600 },
                new StockData { x = new DateTime(2012,4,13), open = 324.09, high = 324.81, low = 312.08, close = 312.61, volume = 16302200 },
                new StockData { x = new DateTime(2012,4,16), open = 311.81, high = 312.21, low = 301.13, close = 303.33, volume = 11372800 }
            };

            ViewBag.dataSource = chartData;

            return View();
        }

        public class StockData
        {
            public DateTime x;
            public double open;
            public double high;
            public double low;
            public double close;
            public double volume;
        }
    }
}