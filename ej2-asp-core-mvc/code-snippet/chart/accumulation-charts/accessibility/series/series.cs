   public ActionResult Index()
        {
            List<PyramidChartData> chartData = new List<PyramidChartData>
            {

                new PyramidChartData { xValue = "Chrome", yValue = 37 },
                new PyramidChartData { xValue = "UC Browser", yValue = 17 },
                new PyramidChartData { xValue = "iPhone", yValue = 19 },
                new PyramidChartData { xValue = "Others", yValue = 14  },
                new PyramidChartData { xValue = "Opera", yValue = 11 },
                new PyramidChartData { xValue = "Android", yValue = 12 },
            };
            ViewBag.dataSource = chartData;
            return View();
        }
        public class PyramidChartData
        {
            public string xValue;
            public double yValue;
        }

 