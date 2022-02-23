public IActionResult Index()
        {
              List<ColumnChartData> chartData = new List<ColumnChartData>
            {
                new ColumnChartData { x= "USA", yValue= 46 },
                new ColumnChartData { x= "GBR", yValue= 27 },
                new ColumnChartData { x= "CHN", yValue= 26 },
                new ColumnChartData { x= "UK", yValue= 26 },
                new ColumnChartData { x= "AUS", yValue= 26 },
                new ColumnChartData { x= "IND", yValue= 26 },
                new ColumnChartData { x= "DEN", yValue= 26 },
                new ColumnChartData { x= "MEX", yValue= 26 },
            };
            ViewBag.dataSource = chartData;
            return View();
        }
        public class ColumnChartData
        {
            public string x;
            public double yValue;
        }