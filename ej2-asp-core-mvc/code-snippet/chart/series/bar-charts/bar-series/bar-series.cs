 public ActionResult Index()
        {
            List<ChartData> chartData = new List<ChartData>
            {
                new ChartData { x= "USA", yValue= 46 },
                new ChartData { x= "GBR", yValue= 27 },
                new ChartData { x= "CHN", yValue= 26 },
                new ChartData { x= "UK",  yValue= 56 },
                new ChartData { x= "AUS", yValue= 12 },
                new ChartData { x= "IND", yValue= 26 },
                new ChartData { x= "DEN", yValue= 26 },
                new ChartData { x= "MEX", yValue= 34 }
            };
            ViewBag.dataSource = chartData;
            return View();
        }
        public class ChartData
        {
            public string x;
            public double yValue;
        }