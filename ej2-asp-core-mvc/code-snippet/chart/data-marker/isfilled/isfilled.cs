public ActionResult Index()
        {
            List<VerticalData> chartData = new List<VerticalData>
            {
               new VerticalData{ x= 2005, y= 28 },
               new VerticalData{ x= 2006, y= 25 },
               new VerticalData{ x= 2007, y= 26 }, 
               new VerticalData{ x= 2008, y= 27 },
               new VerticalData{ x= 2009, y= 32 },
               new VerticalData{ x= 2010, y= 35 }, 
               new VerticalData{ x= 2011, y= 30 }
            };
            ViewBag.dataSource = chartData;
            return View();
        }
        public class VerticalData
        {
            public double x;
            public double y;
        }