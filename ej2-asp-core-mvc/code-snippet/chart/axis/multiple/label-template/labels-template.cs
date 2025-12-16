public ActionResult Index()
        {
            List<ColumnChartData> chartData = new List<ColumnChartData>
            {
                new ColumnChartData{ country: 'USA', gold: 46 },
                new ColumnChartData{ country: 'UK', gold: 27 },
                new ColumnChartData{ country: 'China', gold: 26 },
                new ColumnChartData{ country: 'Russia', gold: 19 },,
                new ColumnChartData{ country: 'Germany', gold: 17 }
            };
            ViewBag.dataSource = chartData;
            return View();
        }
        public class ColumnChartData
        {
            public string country;
            public double gold;
        }