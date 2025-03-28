public ActionResult Index()
        {
            List<StackedLineChartData> chartData = new List<StackedLineChartData>
            {
                new StackedLineChartData { X = "2014", Y = 111.1, Y1 = 76.9,  Y2 = 66.1,  Y3 = 34.1 },
                new StackedLineChartData { X = "2015", Y = 127.3, Y1 = 99.5,  Y2 = 79.3,  Y3 = 38.2 },
                new StackedLineChartData { X = "2016", Y = 143.4, Y1 = 121.7, Y2 = 91.3,  Y3 = 44.0 },
                new StackedLineChartData { X = "2017", Y = 159.9, Y1 = 142.5, Y2 = 102.4, Y3 = 51.6 },
                new StackedLineChartData { X = "2018", Y = 175.4, Y1 = 166.7, Y2 = 112.9, Y3 = 61.9 },
                new StackedLineChartData { X = "2019", Y = 189.0, Y1 = 182.9, Y2 = 122.4, Y3 = 71.5 },
                new StackedLineChartData { X = "2020", Y = 202.7, Y1 = 197.3, Y2 = 120.9, Y3 = 82.0 }
            };
            ViewBag.dataSource = chartData;
            return View();
        }
        public class StackedLineChartData
        {
            public string X;
            public double Y;
            public double Y1;
            public double Y2;
            public double Y3;
        }