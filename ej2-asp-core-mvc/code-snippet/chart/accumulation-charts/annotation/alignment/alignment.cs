 public ActionResult Index()
        {
            List<PieChartData> chartData = new List<PieChartData>
            {

                new PieChartData { x = "Chrome", y = 37 },
                new PieChartData { x = "UC Browser", y = 17 },
                new PieChartData { x = "iPhone", y = 19 },
                new PieChartData { x = "Others", y = 4  },
                new PieChartData { x = "Opera", y = 11 },
                new PieChartData { x = "Android", y = 12 },
            };
            ViewBag.dataSource = chartData;
            return View();
        }
        public class PieChartData
        {
            public string xValue;
            public double yValue;
        }

