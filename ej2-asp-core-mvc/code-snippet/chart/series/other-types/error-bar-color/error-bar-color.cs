public ActionResult Index()
        {
            List<ErrorBarData> chartData = new List<ErrorBarData>
            {
               new ErrorBarData{ x= 2006, y= 7.8, color= 'red', error= 1.5 },
               new ErrorBarData{ x= 2007, y= 7.2, color= 'green', error= 2.5 },
               new ErrorBarData{ x= 2008, y= 6.8, color= 'blue', error= 3.5 }, 
               new ErrorBarData{ x= 2009, y= 5.7, color= 'yellow', error= 1.5 },
               new ErrorBarData{ x= 2010, y= 10.8, color= 'grey', error= 0.5 },
               new ErrorBarData{ x= 2011, y= 9.8, color= 'brown', error= 1 }
            };
            ViewBag.dataSource = chartData;
            return View();
        }
        public class ErrorBarData
         {
            public double x;
            public double y;
            public string color;
            public double error;
        }
