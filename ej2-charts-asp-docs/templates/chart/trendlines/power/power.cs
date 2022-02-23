 public IActionResult Index()
        {
            List<powerData> chartData = new List<powerData>
            {
                    new powerData { x= 1, y= 10 },
                    new powerData { x= 2, y= 50 },
                    new powerData { x= 3, y= 80 },
                    new powerData { x= 4, y= 110 },
                    new powerData { x= 5, y= 180 },
                    new powerData { x= 6, y= 220 },
                    new powerData { x= 7, y= 300 },
                    new powerData { x= 8, y= 370 },
                    new powerData { x= 9, y= 490 },
                    new powerData { x= 10, y= 500 }
            };
            ViewBag.dataSource = chartData;
            return View();
        }
        public class powerData
        {
            public double x;
            public double y;
        }