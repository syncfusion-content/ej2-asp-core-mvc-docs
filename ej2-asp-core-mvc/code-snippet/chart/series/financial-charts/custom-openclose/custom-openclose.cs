public ActionResult Index()
        {
            List<Data> chartData = new List<Data>
            {
            new Data{ x= "Jan", open= 120, high= 160, low= 100, close= 140 },
            new Data{ x= "Feb", open= 150, high= 190, low= 130, close= 170 },
            new Data{ x= "Mar", open= 130, high= 170, low= 110, close= 150 },
            new Data{ x= "Apr", open= 160, high= 180, low= 120, close= 140 },
            new Data{ x= "May", open= 150, high= 170, low= 110, close= 130 }
            };
            ViewBag.dataSource = chartData;
            return View();
        }
        public class Data
        {
            public string x;
            public double y;
            public double high;
            public double low;
            public double open;
            public double close;
        }