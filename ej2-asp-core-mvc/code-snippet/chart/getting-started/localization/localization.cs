public ActionResult Index()
        {
            List<InternalChartData> chartData = new List<InternalChartData>
            {
             new InternalChartData{ x= 1900, y= 4,   y1= 2.6 },
             new InternalChartData{ x= 1920, y= 3.0, y1= 2.8 },
             new InternalChartData{ x= 1940, y= 3.8, y1= 2.6}, 
             new InternalChartData{ x= 1960, y= 3.4, y1= 3 },
             new InternalChartData{ x= 1980, y= 3.2, y1= 3.6 }, 
             new InternalChartData{ x= 2000, y= 3.9, y1= 3 }
            };
            ViewBag.dataSource = chartData;
            return View();
        }
        public class InternalChartData
        {
            public double x;
            public double y;
            public double y1;
        }