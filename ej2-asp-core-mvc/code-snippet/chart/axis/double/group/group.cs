public ActionResult Index()
        {
            List<ColumnChartData> chartData = new List<ColumnChartData>
            {
                new ColumnChartData{ x= "USA", y=50  },
                new ColumnChartData{ x="China", y=40 },
                new ColumnChartData{ x= "Japan", y=70 },
                new ColumnChartData{ x= "Australia", y=60},
                new ColumnChartData{ x= "France", y=50 },
                new ColumnChartData{ x= "Germany", y=40 },
                new ColumnChartData{ x= "Italy", y=40 },
                new ColumnChartData{ x= "Sweden", y=30 }
            };
            ViewBag.dataSource = chartData;
            return View();
        }

        public class ColumnChartData
        {
            public string x;
            public double y;
        }