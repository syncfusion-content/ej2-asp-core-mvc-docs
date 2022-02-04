public IActionResult Index()
        {
              List<ColumnChartData> chartData = new List<ColumnChartData>
            {
                new ColumnChartData { x= "John", yValue= 10000, yValue1=37, yValue2=38 },
                new ColumnChartData { x= "Jake", yValue= 12000, yValue1=23, yValue2=17 },
                new ColumnChartData { x= "Peter", yValue= 18000, yValue1=18, yValue2=26 },
                new ColumnChartData { x= "James", yValue= 11000, yValue1=18, yValue2=26 }
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