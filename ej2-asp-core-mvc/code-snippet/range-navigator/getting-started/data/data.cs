public IActionResult Index()
        {
        List <data> dataSource = new List<data>
            {
                new data { x = new DateTime(2005, 01, 01), y = 21, y1 = 28 },
                new data { x = new DateTime(2006, 01, 01), y = 24, y1 = 44 },
                new data { x = new DateTime(2007, 01, 01), y = 36, y1 = 48 },
                new data { x = new DateTime(2008, 01, 01), y = 38, y1 = 50 },
                new data { x = new DateTime(2009, 01, 01), y = 54, y1 = 66 },
                new data { x = new DateTime(2010, 01, 01), y = 57, y1 = 78 },
                new data { x = new DateTime(2011, 01, 01), y = 70, y1 = 84 }
            };
            ViewBag.dataSource = dataSource;
            return View();
        }
       public class data
        {
            public DateTime x;
            public double y;
            public double y1;
        }