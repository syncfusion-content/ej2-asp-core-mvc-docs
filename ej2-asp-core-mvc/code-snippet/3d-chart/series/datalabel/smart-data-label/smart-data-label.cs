using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

public class HomeController : Controller
{
    public ActionResult Index()
    {
        List<ChartData> chartData = new List<ChartData>
        {
            new ChartData { x = "2014", y = 21.1, y1 = 76.9, y2 = 66.1, y3 = 34.1 },
            new ChartData { x = "2015", y = 127.3, y1 = 20.5, y2 = 19.3, y3 = 38.2 },
            new ChartData { x = "2016", y = 143.4, y1 = 121.7, y2 = 91.3, y3 = 44.0 },
            new ChartData { x = "2017", y = 559.9, y1 = 342.5, y2 = 62.4, y3 = 91.6 },
            new ChartData { x = "2018", y = 175.4, y1 = 166.7, y2 = 112.9, y3 = 61.9 },
            new ChartData { x = "2019", y = 189.0, y1 = 182.9, y2 = 122.4, y3 = 71.5 },
            new ChartData { x = "2020", y = 202.7, y1 = 197.3, y2 = 120.9, y3 = 82.0 }
        };

        ViewBag.dataSource = chartData;

        return View();
    }

    public class ChartData
    {
        public string x { get; set; }
        public double y { get; set; }
        public double y1 { get; set; }
        public double y2 { get; set; }
        public double y3 { get; set; }
    }
}