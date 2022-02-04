public ActionResult Index()
        {
            List<ColumnChartData> chartData = new List<ColumnChartData>
            {
                new ColumnChartData { x= "USA", yValue= 46 },
                new ColumnChartData { x= "GBR", yValue= 27 },
                new ColumnChartData { x= "CHN", yValue= 26 },
                new ColumnChartData { x= "UK", yValue= 23 },
                new ColumnChartData { x= "AUS", yValue= 16 },
                new ColumnChartData { x= "IND", yValue= 36 },
                new ColumnChartData { x= "DEN", yValue= 12 },
                new ColumnChartData { x= "MEX", yValue= 20 },
            };
            ViewBag.dataSource = chartData;
            return View();
        }
        public class ColumnChartData
        {
            public string x;
            public double yValue;
        }