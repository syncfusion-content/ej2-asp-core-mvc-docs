public ActionResult Index()
        {
            List<StackedLineChartData> chartData = new List<StackedLineChartData>
            {
                new StackedLineChartData { X = "Food", Y = 90, Y1 = 40, Y2 = 70, Y3 = 120 },
                new StackedLineChartData { X = "Transport", Y = 80, Y1 = 90, Y2 = 110, Y3 = 70 },
                new StackedLineChartData { X = "Medical", Y = 50, Y1 = 80, Y2 = 120, Y3 = 50 },
                new StackedLineChartData { X = "Clothes", Y = 70, Y1 = 30, Y2 = 60, Y3 = 180 },
                new StackedLineChartData { X = "Personal Care", Y = 30, Y1 = 80, Y2 = 80, Y3 = 30 },
                new StackedLineChartData { X = "Books", Y = 10, Y1 = 40, Y2 = 30, Y3 = 270 },
                new StackedLineChartData { X = "Fitness", Y = 100,Y1 = 30, Y2 = 70, Y3 = 40 },
                new StackedLineChartData { X = "Electricity", Y = 55, Y1 = 95, Y2 = 55, Y3 = 75 },
                new StackedLineChartData { X = "Tax", Y = 20, Y1 = 50, Y2 = 40, Y3 = 65 },
                new StackedLineChartData { X = "Pet Care", Y = 40, Y1 = 20, Y2 = 80, Y3 = 95 },
                new StackedLineChartData { X = "Education", Y = 45, Y1 = 15, Y2 = 45, Y3 = 195 },
                new StackedLineChartData { X = "Entertainment", Y = 75, Y1 = 45, Y2 = 65, Y3 = 115 }
            };
            ViewBag.dataSource = chartData;
            return View();
        }
        public class StackedLineChartData
        {
            public string X;
            public double Y;
            public double Y1;
            public double Y2;
            public double Y3;
        }