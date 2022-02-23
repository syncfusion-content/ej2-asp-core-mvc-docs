public ActionResult Index()
        {
            List<MultipleAxesChartData> chartData = new List<MultipleAxesChartData>
            {
                new MultipleAxesChartData { x = "Sun", y = 35, y1 = 30 },
                new MultipleAxesChartData { x = "Mon", y = 40, y1 = 28 },
                new MultipleAxesChartData { x = "Tue", y = 80, y1 = 29 },
                new MultipleAxesChartData { x = "Wed", y = 70, y1 = 30 },
                new MultipleAxesChartData { x = "Thu", y = 65, y1 = 33 },
                new MultipleAxesChartData { x = "Fri", y = 55, y1 = 32 },
                new MultipleAxesChartData { x = "Sat", y = 50, y1 = 34 }
            };
            ViewBag.dataSource = chartData;
            return View();
        }
        public class MultipleAxesChartData
        {
            public string x;
            public double y;
            public double y1;
        }