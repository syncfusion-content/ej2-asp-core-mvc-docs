public ActionResult Index()
        {
            List<ErrorBarData> chartData = new List<ErrorBarData>
            {
               new ErrorBarData{ x= 2005, y= 28 },
               new ErrorBarData{ x= 2006, y= 25 },
               new ErrorBarData{ x= 2007, y= 26 }, 
               new ErrorBarData{ x= 2008, y= 27 },
               new ErrorBarData{ x= 2009, y= 32 },
               new ErrorBarData{ x= 2010, y= 35 }, 
               new ErrorBarData{ x= 2011, y= 30 }
            };
            ViewBag.dataSource = chartData;
            return View();
        }
        public class ErrorBarData
         {
            public double x;
            public double y;
        }
