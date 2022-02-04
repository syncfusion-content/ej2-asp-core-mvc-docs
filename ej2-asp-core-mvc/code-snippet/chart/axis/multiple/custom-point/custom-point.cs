public ActionResult Index()
        {
            List<ColumnChartData> chartData = new List<ColumnChartData>
            {
                new ColumnChartData{ country= "Russia", gold=50  },
                new ColumnChartData{ country="China", gold=40 },
                new ColumnChartData{ country= "Japan", gold=70 },
                new ColumnChartData{ country= "Australia", gold=60},
                new ColumnChartData{ country= "France", gold=50 },
                new ColumnChartData{ country= "Germany", gold=40 },
                new ColumnChartData{ country= "Italy", gold=40 },
                new ColumnChartData{ country= "United States", gold=30 }
            };
            ViewBag.dataSource = chartData;
            return View();
        }
        public class ColumnChartData
        {
            public string country;
            public double gold;
        }