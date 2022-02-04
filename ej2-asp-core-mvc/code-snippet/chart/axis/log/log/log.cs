public ActionResult Index()
        {
            List<Data> chartData = new List<Data>
           {
                new Data { xValue = new DateTime(2005, 01, 01), yValue = 100, yValue1 = 28 },
                new Data { xValue = new DateTime(2006, 01, 01), yValue = 200, yValue1 = 44 },
                new Data { xValue = new DateTime(2007, 01, 01), yValue = 500, yValue1 = 48 },
                new Data { xValue = new DateTime(2008, 01, 01), yValue = 1000, yValue1 = 50 },
                new Data { xValue = new DateTime(2009, 01, 01), yValue = 8000, yValue1 = 66 },
                new Data { xValue = new DateTime(2010, 01, 01), yValue = 90000, yValue1 = 78 },
                new Data { xValue = new DateTime(2011, 01, 01), yValue = 99000, yValue1 = 84 },
            };
            ViewBag.dataSource = chartData;
            return View();
    }

    public class Data
    {
        public DateTime xValue;
        public double yValue;
        public double yValue1;
    }