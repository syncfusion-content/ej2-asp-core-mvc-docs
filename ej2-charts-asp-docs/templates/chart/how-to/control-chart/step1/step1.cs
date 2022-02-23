public IActionResult Index()
        {
            List<LineChartData> chartData = new List<LineChartData>
            {
                new LineChartData { xValue = new DateTime(1975, 01, 01), yValue = 36},
                new LineChartData { xValue = new DateTime(1980, 01, 01), yValue = 32.5 },
                new LineChartData { xValue = new DateTime(1985, 01, 01), yValue = 39 },
                new LineChartData { xValue = new DateTime(1990, 01, 01), yValue = 34.4 },
                new LineChartData { xValue = new DateTime(1995, 01, 01), yValue = 31.5 },
                new LineChartData { xValue = new DateTime(2000, 01, 01), yValue = 40 },
                new LineChartData { xValue = new DateTime(2005, 01, 01), yValue = 60 },
                new LineChartData { xValue = new DateTime(2010, 01, 01), yValue = 66 },
            };
            ViewBag.dataSource = chartData;
            ViewBag.line = new { width = 0.0001 };
            return View();
        }
        public class LineChartData
        {
            public DateTime xValue;
            public double yValue;
        }