public ActionResult Index()
        {
            List<Data> chartData = new List<Data>
            {
            new Data{ x= "Jan", low= 87, high= 200 },
            new Data{ x= "Feb", low= 45, high= 135 },
            new Data{ x= "Mar", low= 19, high= 85 }, 
            new Data{ x= "Apr", low= 31, high= 108 },
            new Data{ x= "May", low= 27, high= 80 },
            new Data{ x= "June",low= 84, high= 130 },
            new Data{ x= "Jul", low= 77, high=150 }, 
            new Data{ x= "Aug", low= 54, high= 125 },
            new Data{ x= "Sep", low= 60, high= 155 },
            new Data{ x= "Oct", low= 60, high= 180 },
            new Data{ x= "Nov", low= 88, high= 180 },
            new Data{ x= "Dec", low= 84, high= 230 }
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
        }