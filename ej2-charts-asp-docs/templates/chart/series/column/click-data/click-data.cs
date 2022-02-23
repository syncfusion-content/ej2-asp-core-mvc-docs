  public IActionResult Index()
        {
              List<ChartData> chartData = new List<ChartData>
            {
                new ChartData { xValue = "Chrome", yValue = 37, text = "37%"},
                new ChartData { xValue = "UC Browser", yValue = 17, text = "17%"},
                new ChartData { xValue = "iPhone", yValue = 19, text = "19%"},
                new ChartData { xValue = "Others", yValue = 4 , text = "4%"},
                new ChartData { xValue = "Opera", yValue = 11, text = "11%"},
                new ChartData { xValue = "Android", yValue = 12, text = "12%"},
            };
            ViewBag.dataSource = chartData;
            return View();
        }
        public class ChartData
        {
            public string xValue;
            public double yValue;
            public string text;
        }