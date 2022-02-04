public ActionResult Index()
        {
              List<Group> chartData = new List<Group>
            {
               new Group{ x= 10, y=7000 },
               new Group{ x= 20, y= 1000 },
               new Group{ x= 30, y= 12000 }, 
               new Group{ x= 40, y= 14000 },
               new Group{ x= 50, y= 11000 }, 
               new Group{ x= 60, y= 5000 },
               new Group{ x= 70, y= 7300 },
               new Group{ x= 80, y= 9000 },
               new Group{ x= 90, y= 12000 },
               new Group{ x= 100, y= 14000 }, 
               new Group{ x= 110, y= 11000 },
               new Group{ x= 120, y= 5000 }
            };
            ViewBag.dataSource = chartData;
            return View();
        }
        public class Group
       {
            public double x;
            public double y;
        };