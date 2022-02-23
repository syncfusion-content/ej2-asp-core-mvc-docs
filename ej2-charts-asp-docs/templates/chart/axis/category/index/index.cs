 public ActionResult Index()
        {
            List<ColumnChartData> chartData = new List<ColumnChartData>
            {
                new ColumnChartData{ x= "Myanmar", y= 7.3 },
                new ColumnChartData{ x= "India", y= 7.9 },
                new ColumnChartData{ x= "Bangladesh", y= 6.8 },
                new ColumnChartData{ x= "Cambodia", y=7.0 },
                new ColumnChartData{ x= "China", y= 6.9 }
            };
            ViewBag.dataSource = chartData;
            List<ColumnChartData> chartData1 = new List<ColumnChartData>
            {
            new ColumnChartData{ x= "Poland", y=2.7 },
            new ColumnChartData{ x= "Australia", y=2.5 },
            new ColumnChartData{ x= "Singapore", y=2.0 },
            new ColumnChartData{ x= "Canada", y=1.4 },
            new ColumnChartData{ x= "Germany", y=1.8 }
            };
            ViewBag.dataSource1 = chartData1;
            return View();
        }
        public class ColumnChartData
        {
            public string x;
            public double y;
        }