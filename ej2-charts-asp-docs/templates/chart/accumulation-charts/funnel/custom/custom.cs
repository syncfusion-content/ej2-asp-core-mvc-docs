 public ActionResult Index()
        {
            List<FunnelChartData> chartData = new List<FunnelChartData>
            {

                new FunnelChartData { xValue = "Chrome", yValue = 37 },
                new FunnelChartData { xValue = "UC Browser", yValue = 17 },
                new FunnelChartData { xValue = "iPhone", yValue = 19 },
                new FunnelChartData { xValue = "Others", yValue = 4  },
                new FunnelChartData { xValue = "Opera", yValue = 11 },
                new FunnelChartData { xValue = "Android", yValue = 12 },
            };
            ViewBag.dataSource = chartData;
            return View();
        }
        public class FunnelChartData
        {
            public string xValue;
            public double yValue;
        }

