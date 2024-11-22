public ActionResult Index()
        {
            List<ColumnChartData> chartData = new List<ColumnChartData>
            {
                new ColumnChartData{ x= "Traffic", y=56  },
                new ColumnChartData{ x="Child care", y=44.8 },
                new ColumnChartData{ x= "Transport", y=27.2 },
                new ColumnChartData{ x= "Weather", y=19.6},
                new ColumnChartData{ x= "Emergency", y=6.6 }
            };
            ViewBag.dataSource = chartData;
            return View();
        }

        public class ColumnChartData
        {
            public string x;
            public double y;
        };