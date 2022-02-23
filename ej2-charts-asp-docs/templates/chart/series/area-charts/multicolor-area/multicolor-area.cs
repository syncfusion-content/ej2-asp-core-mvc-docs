 public IActionResult Index()
        {
            List<ChartData> chartData = new List<ChartData>
            {
               new ChartData{ x= 2005, y= 28 },
               new ChartData{ x= 2006, y= 25},
               new ChartData{ x= 2007, y= 26 },
               new ChartData{ x= 2008, y= 27 },
               new ChartData{ x= 2009, y= 32}, 
               new ChartData{ x= 2010, y= 35 }, 
               new ChartData{ x= 2011, y= 25 }
            };
            ViewBag.dataSource = chartData;
            return View();
        }
        public class ChartData
        {
            public double x;
            public double y;
        }