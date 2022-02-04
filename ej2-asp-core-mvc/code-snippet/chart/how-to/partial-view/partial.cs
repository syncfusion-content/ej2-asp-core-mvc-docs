    public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create()
        {
            List<ChartData> chartData = new List<ChartData>
            {
                new ChartData { xValue = 10, yValue = 21 },
                new ChartData { xValue = 20, yValue = 24 },
                new ChartData { xValue = 30, yValue = 36 },
                new ChartData { xValue = 40, yValue = 38 },
                new ChartData { xValue = 50, yValue = 54 },
                new ChartData { xValue = 60, yValue = 57 },
                new ChartData { xValue = 70, yValue = 70 },
            };
            ViewBag.dataSource = chartData;
            return PartialView("_RefreshCharts");
        }
        public class ChartData
        {
            public double xValue;
            public double yValue;
        }