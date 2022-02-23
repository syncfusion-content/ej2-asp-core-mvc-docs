public ActionResult Index()
        {
            List<PieChartData> chartData = new List<PieChartData>
            {

                new PieChartData { xValue = "Chrome", yValue = 37 },
                new PieChartData { xValue = "UC Browser", yValue = 17 },
                new PieChartData { xValue = "iPhone", yValue = 19 },
                new PieChartData { xValue = "Others", yValue = 4  },
                new PieChartData { xValue = "Opera", yValue = 11 },
                new PieChartData { xValue = "Android", yValue = 12 },
            };
            ViewBag.dataSource = chartData;
            return View();
        }
        public class PieChartData
        {
            public string xValue;
            public double yValue;
        }

 