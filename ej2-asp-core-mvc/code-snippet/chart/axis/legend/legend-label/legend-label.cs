public IActionResult Index()
        {
            List<ColumnChartData> chartData = new List<ColumnChartData>
            {
                new ColumnChartData{ country= "USA", gold=50, silver=70, bronze=45 },
                new ColumnChartData{ country="China", gold=40, silver= 60, bronze=55 },
                new ColumnChartData{ country= "Japan", gold=70, silver= 60, bronze=50 },
                new ColumnChartData{ country= "Australia", gold=60, silver= 56, bronze=40 },
                new ColumnChartData{ country= "France", gold=50, silver= 45, bronze=35 },
                new ColumnChartData{ country= "Germany", gold=40, silver=30, bronze=22 },
                new ColumnChartData{ country= "Italy", gold=40, silver=35, bronze=37 },
                new ColumnChartData{ country= "Sweden", gold=30, silver=25, bronze=27 }
            };
            ViewBag.dataSource = chartData;
            return View();
        }
        public class ColumnChartData
        {
            public string country;
            public double gold;
            public double silver;
            public double bronze;
        }