public ActionResult Index()
        {
            List<ChartData> chartData = new List<ChartData>
            {
                new ChartData { x= "USA", yValue= 46, yValue1=56 },
                new ChartData { x= "GBR", yValue= 27, yValue1=17 },
                new ChartData { x= "CHN", yValue= 26, yValue1=36 },
                new ChartData { x= "UK", yValue= 56,  yValue1=16 },
                new ChartData { x= "AUS", yValue= 12, yValue1=46 },
                new ChartData { x= "IND", yValue= 26, yValue1=16 },
                new ChartData { x= "DEN", yValue= 26, yValue1=12 },
                new ChartData { x= "MEX", yValue= 34, yValue1=32},
            };
            ViewBag.dataSource = chartData;
            return View();
        }
        public class ChartData
        {
            public string x;
            public double yValue;
            public double yValue1;
        }