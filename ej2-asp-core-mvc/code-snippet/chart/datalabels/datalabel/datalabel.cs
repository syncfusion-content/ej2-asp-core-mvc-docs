 public ActionResult Index()
        {
            List<Data> chartData = new List<Data>
            {
           new Data{ x= "Jan", y= 3,   fill= "#498fff", text= "January" },
           new Data{ x= "Feb", y= 3.5, fill= "#ffa060", text= "February" },
           new Data{ x= "Mar", y= 7,   fill= "#ff68b6", text= "March" },
           new Data{ x= "Apr", y= 13.5,fill= "#81e2a1", text= "April" }
            };
            ViewBag.dataSource = chartData;
            return View();
        }
        public class Data
        {
            public string x;
            public double y;
            public string fill;
            public string text;
        }