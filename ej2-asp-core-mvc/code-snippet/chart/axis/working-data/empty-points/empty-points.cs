public IActionResult Index()
        {
            List<EmptyData> chartData = new List<EmptyData>
            {
               new EmptyData{ month="Jan", sales= 35 },
               new EmptyData{ month= "Feb", sales= 28 },
               new EmptyData{ month="Mar", sales=null },
               new EmptyData{ month="Apr", sales=32 },
               new EmptyData{ month="May", sales=40 },
               new EmptyData{ month= "Jun", sales=32 },
               new EmptyData{ month="Jul", sales=35 },
               new EmptyData{ month="Aug", sales=null },
               new EmptyData{ month="Sep", sales=38 },
               new EmptyData{ month="Oct", sales=30 },
               new EmptyData{ month="Nov", sales=25 },
               new EmptyData{ month= "Dec", sales=32 }
            };
            ViewBag.dataSource = chartData;
            return View();
        }
        public class EmptyData
        {
            public string month;
            public Nullable<double> sales;
        }