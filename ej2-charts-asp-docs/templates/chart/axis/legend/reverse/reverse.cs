public IActionResult Index()
        {
            List<ColumnChartData> chartData = new List<ColumnChartData>
            {
                new ColumnChartData { x= "USA", yValue= 46, yValue1=37, yValue2=38 },
                new ColumnChartData { x= "GBR", yValue= 27, yValue1=23, yValue2=17 },
                new ColumnChartData { x= "CHN", yValue= 26, yValue1=18, yValue2=26 }
            };
            ViewBag.dataSource = chartData;
            return View();
        }
        public class ColumnChartData
        {
            public string x;
            public double yValue;
            public double yValue1;
            public double yValue2;
        }