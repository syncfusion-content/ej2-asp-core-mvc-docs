public IActionResult Index()
        {
            List<ColumnChartData> chartData = new List<ColumnChartData>
            {
                new ColumnChartData { X = new DateTime(1975, 01, 01), Y = 16,   Y1 = 10,  Y2 = 4.5 },
                new ColumnChartData { X = new DateTime(1980, 01, 01), Y = 12.5, Y1 = 7.5, Y2 = 5 },
                new ColumnChartData { X = new DateTime(1985, 01, 01), Y = 19,   Y1 = 11,  Y2 = 6.5 },
                new ColumnChartData { X = new DateTime(1990, 01, 01), Y = 14.4, Y1 = 7,   Y2 = 4.4 },
                new ColumnChartData { X = new DateTime(1995, 01, 01), Y = 11.5, Y1 = 8,   Y2 = 5 },
                new ColumnChartData { X = new DateTime(2000, 01, 01), Y = 14,   Y1 = 6,   Y2 = 1.5 },
                new ColumnChartData { X = new DateTime(2005, 01, 01), Y = 10,   Y1 = 3.5, Y2 = 2.5 },
                new ColumnChartData { X = new DateTime(2010, 01, 01), Y = 16,   Y1 = 7,   Y2 = 3.7 }
            };
            ViewBag.dataSource = chartData;
            return View();
        }
        public class ColumnChartData
        {
            public DateTime X;
            public double Y;
            public double Y1;
            public double Y2;
        }