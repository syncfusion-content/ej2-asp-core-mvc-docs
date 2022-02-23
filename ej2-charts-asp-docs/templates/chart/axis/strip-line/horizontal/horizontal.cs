public ActionResult Index()
        {
            List<StripLineChartData> chartData = new List<StripLineChartData>
            {
               new StripLineChartData { x = "Sun", y = 28 },
               new StripLineChartData { x = "Mon", y = 27 },
               new StripLineChartData { x = "Tue", y = 33 },
               new StripLineChartData { x = "Wed", y = 36 },
               new StripLineChartData { x = "Thu", y = 28 },
               new StripLineChartData { x = "Fri", y = 30 },
               new StripLineChartData { x = "Sat", y = 31 }
            };
            ViewBag.dataSource = chartData;
            return View();
        }
        public class StripLineChartData
        {
            public string x;
            public double y;
        }