public ActionResult Index()
        {
            List<FunnelChartData> chartData = new List<FunnelChartData>
            {

                new FunnelChartData { XValue = "Renewed",     YValue = 18.20,  Text = "Renewed 18.20%" },
                new FunnelChartData { XValue = "Subscribe",   YValue = 27.3,   Text = "Subscribe 27.3%" },
                new FunnelChartData { XValue = "Support",     YValue = 55.9,   Text = "Support 55.9%" },
                new FunnelChartData { XValue = "Downloaded",  YValue = 76.8,   Text = "Downloaded 76.8%" },
                new FunnelChartData { XValue = "Visited",     YValue = 100,    Text = "Visited 100%" }
            };
            ViewBag.dataSource = chartData;
            return View();
        }
        public class FunnelChartData
        {
            public string XValue;
            public double YValue;
            public string Text;
        }

