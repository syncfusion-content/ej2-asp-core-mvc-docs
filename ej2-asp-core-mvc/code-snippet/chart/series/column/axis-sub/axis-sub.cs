  public ActionResult Index()
        {
            List<LineChartData> chartData = new List<LineChartData>
            {
                new LineChartData { xValue = "2014", yValue = 21 },
                new LineChartData { xValue = "2015", yValue = 24 },
                new LineChartData { xValue = "2016", yValue = 36 },
                new LineChartData { xValue = "2017", yValue = 38 },
                new LineChartData { xValue = "2018", yValue = 54 },
                new LineChartData { xValue = "2019", yValue = 57 },
                new LineChartData { xValue = "2020", yValue = 70 },
            };
            ViewBag.dataSource = chartData;
            return View();
        }

        public class LineChartData
        {
            public string xValue;
            public double yValue;
            public double yValue1;
        }