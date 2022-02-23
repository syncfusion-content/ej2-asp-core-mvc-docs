public IActionResult Index()
        {
           List<LineChartData> chartData = new List<LineChartData>
            {
                new LineChartData { xValue = new DateTime(2005, 01, 01), yValue = 21, yValue1 = 28 },
                new LineChartData { xValue = new DateTime(2006, 01, 01), yValue = 24, yValue1 = 44 },
                new LineChartData { xValue = new DateTime(2007, 01, 01), yValue = 36, yValue1 = 48 },
                new LineChartData { xValue = new DateTime(2008, 01, 01), yValue = 38, yValue1 = 50 },
                new LineChartData { xValue = new DateTime(2009, 01, 01), yValue = 54, yValue1 = 66 },
                new LineChartData { xValue = new DateTime(2010, 01, 01), yValue = 57, yValue1 = 78 },
                new LineChartData { xValue = new DateTime(2011, 01, 01), yValue = 70, yValue1 = 84 },
                new LineChartData { xValue = new DateTime(2012, 01, 01), yValue = 78, yValue1 = 84 },
                new LineChartData { xValue = new DateTime(2013, 01, 01), yValue = 60, yValue1 = 84 },
                new LineChartData { xValue = new DateTime(2014, 01, 01), yValue = 78, yValue1 = 84 },
            };
            ViewBag.dataSource = chartData;
            return View();
        }

        public class LineChartData
        {
            public DateTime xValue;
            public double yValue;
            public double yValue1;
        }