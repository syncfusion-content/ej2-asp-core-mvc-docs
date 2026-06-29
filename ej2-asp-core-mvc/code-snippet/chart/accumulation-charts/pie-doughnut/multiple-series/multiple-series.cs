using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public partial class AccumulationChartController : Controller
    {
        public ActionResult MultipleSeries()
        {
            List<MultiplePieSeriesData> totalSalesData = new List<MultiplePieSeriesData>
            {
                new MultiplePieSeriesData { x = "Electronics", y = 45000, text = "45K" },
                new MultiplePieSeriesData { x = "Fashion", y = 32000, text = "32K" },
                new MultiplePieSeriesData { x = "Home & Garden", y = 18000, text = "18K" },
                new MultiplePieSeriesData { x = "Sports", y = 15000, text = "15K" },
                new MultiplePieSeriesData { x = "Books", y = 8000, text = "8K" }
            };

            List<MultiplePieSeriesData> totalProfitData = new List<MultiplePieSeriesData>
            {
                new MultiplePieSeriesData { x = "Electronics", y = 18000, text = "18K", profit = "40%" },
                new MultiplePieSeriesData { x = "Fashion", y = 12800, text = "12.8K", profit = "40%" },
                new MultiplePieSeriesData { x = "Home & Garden", y = 6300, text = "6.3K", profit = "35%" },
                new MultiplePieSeriesData { x = "Sports", y = 4500, text = "4.5K", profit = "30%" },
                new MultiplePieSeriesData { x = "Books", y = 2400, text = "2.4K", profit = "30%" }
            };

            ViewBag.totalSalesData = totalSalesData;
            ViewBag.totalProfitData = totalProfitData;
            ViewBag.border = new { color = "#333", width = 2 };
            return View();
        }
    }

    public class MultiplePieSeriesData
    {
        public string x { get; set; }
        public double y { get; set; }
        public string text { get; set; }
        public string profit { get; set; }
    }
}
