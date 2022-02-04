public IActionResult Index()
        {
           List<LineData> chartData = new List<LineData>
            {
                new LineData { xValue = new DateTime(2005, 01, 01), yValue = 21, yValue1 = 28 },
                new LineData { xValue = new DateTime(2006, 01, 01), yValue = 24, yValue1 = 44 },
                new LineData { xValue = new DateTime(2007, 01, 01), yValue = 36, yValue1 = 48 },
                new LineData { xValue = new DateTime(2008, 01, 01), yValue = 38, yValue1 = 50 },
                new LineData { xValue = new DateTime(2009, 01, 01), yValue = 54, yValue1 = 66 },
                new LineData { xValue = new DateTime(2010, 01, 01), yValue = 57, yValue1 = 78 },
                new LineData { xValue = new DateTime(2011, 01, 01), yValue = 70, yValue1 = 84 },
            };
            ViewBag.dataSource = chartData;
            return View();
        }
        public class LineData
        {
            public DateTime xValue;
            public double yValue;
            public double yValue1;
        }