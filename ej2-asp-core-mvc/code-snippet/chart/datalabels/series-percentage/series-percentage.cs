public ActionResult Index()
        {
            List<ColumnChartData> chartData1 = new List<ColumnChartData>
            {
                new ColumnChartData { x= "USA", y = 46 },
                new ColumnChartData { x= "GBR", y = 27 },
                new ColumnChartData { x= "CHN", y = 26 }
            };
            ViewBag.dataSource1 = chartData1;

            List<ColumnChartData> chartData2 = new List<ColumnChartData>
            {
                new ColumnChartData { x= "USA", y = 37 },
                new ColumnChartData { x= "GBR", y = 23 },
                new ColumnChartData { x= "CHN", y = 18 }
            };
            ViewBag.dataSource2 = chartData2;

            List<ColumnChartData> chartData3 = new List<ColumnChartData>
            {
                new ColumnChartData { x= "USA", y = 38 },
                new ColumnChartData { x= "GBR", y = 17 },
                new ColumnChartData { x= "CHN", y = 26 }
            };
            ViewBag.dataSource3 = chartData3;
            return View();
        }
    public class ColumnChartData
        {
            public string x;
            public double y;
        }