public ActionResult Index()
        {
            List<VerticalData> chartData = new List<VerticalData>
            {
               new VerticalData{ x= 2005, y= 28, y1= 18 },
               new VerticalData{ x= 2006, y= 25, y1= 10 },
               new VerticalData{ x= 2007, y= 26, y1= 20 }, 
               new VerticalData{ x= 2008, y= 27, y1= 35 },
               new VerticalData{ x= 2009, y= 32, y1= 23 },
               new VerticalData{ x= 2010, y= 35, y1= 25 }, 
               new VerticalData{ x= 2011, y= 30, y1= 15 }
            };
            ViewBag.dataSource = chartData;
            return View();
        }
        public class VerticalData
        {
            public double x;
            public double y;
            public double y1;
        }