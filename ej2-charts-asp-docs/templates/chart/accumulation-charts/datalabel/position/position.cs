  public ActionResult Index()
        {
            List<PieChartData> chartData = new List<PieChartData>
            {

                new PieChartData { xValue = "Chrome", yValue = 37, text = "37%", fill="#498fff"},
                new PieChartData { xValue = "UC Browser", yValue = 17, text = "17%", fill="#ffa060"},
                new PieChartData { xValue = "iPhone", yValue = 19, text = "19%", fill="#ff68b6"},
                new PieChartData { xValue = "Others", yValue = 4 , text = "4%", fill="#81e2a1"},
            };
            ViewBag.dataSource = chartData;
            return View();
        }
        public class PieChartData
        {
            public string xValue;
            public double yValue;
            public string text;
            public string fill;
        }

