public ActionResult Index()
        {
            List<StackedLineChartData100> chartData = new List<StackedLineChartData100>
            {
                new StackedLineChartData100 { x= "Food", y= 90, y1= 40, y2= 70, y3= 120 },
                new StackedLineChartData100 { x= "Transport", y= 80, y1= 90, y2= 110, y3= 70 },
                new StackedLineChartData100 { x= "Medical", y= 50, y1= 80, y2= 120, y3= 50 },
                new StackedLineChartData100 { x= "Clothes", y= 70, y1= 30, y2= 60, y3= 180 },
                new StackedLineChartData100 { x= "Personal Care", y= 30, y1= 80, y2= 80, y3= 30 },
                new StackedLineChartData100 { x= "Books", y= 10, y1= 40, y2= 30, y3= 270 },
                new StackedLineChartData100 { x= "Fitness", y= 100,y1= 30, y2= 70, y3= 40 },
                new StackedLineChartData100 { x= "Electricity", y= 55, y1= 95, y2= 55, y3= 75 },
                new StackedLineChartData100 { x= "Tax", y= 20, y1= 50, y2= 40, y3= 65 },
                new StackedLineChartData100 { x= "Pet Care", y= 40, y1= 20, y2= 80, y3= 95 },
                new StackedLineChartData100 { x= "Education", y= 45, y1= 15, y2= 45, y3= 195 },
                new StackedLineChartData100 { x= "Entertainment", y= 75, y1= 45, y2= 65, y3= 115 }
            };
            ViewBag.dataSource = chartData;
            return View();
        }
        public class StackedLineChartData100
        {
            public string x;
            public double y;
            public double y1;
            public double y2;
            public double y3;
        }