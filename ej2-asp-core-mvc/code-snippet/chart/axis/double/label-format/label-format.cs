 public ActionResult Index()
        {
            List<ChartData> chartData = new List<ChartData>
            {
                new ChartData { xValue = 10, yValue = 21, yValue1 = 28 },
                new ChartData { xValue = 20, yValue = 24, yValue1 = 44 },
                new ChartData { xValue = 30, yValue = 36, yValue1 = 48 },
                new ChartData { xValue = 40, yValue = 38, yValue1 = 50 },
                new ChartData { xValue = 50, yValue = 54, yValue1 = 66 },
                new ChartData { xValue = 60, yValue = 57, yValue1 = 78 },
                new ChartData { xValue = 70, yValue = 70, yValue1 = 84 },
            };
            ViewBag.dataSource = chartData;
            return View();
        }

        public class ChartData
        {
            public double xValue;
            public double yValue;
            public double yValue1;
        }