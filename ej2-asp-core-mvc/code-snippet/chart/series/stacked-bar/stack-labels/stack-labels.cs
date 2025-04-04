public ActionResult Index()
        {
            List<StackedLineChartData> chartData = new List<StackedLineChartData>
            {
                new StackedLineChartData { X = "Jan", Y = 6,  Y1 = 6,  Y2 = -1 }, 
                new StackedLineChartData { X = "Feb", Y = 8 , Y1 = 8,  Y2 = -1.5 },
                new StackedLineChartData { X = "Mar", Y = 12, Y1 = 11, Y2 = -2 }, 
                new StackedLineChartData { X = "Apr", Y = 15, Y1 = 16, Y2 = -2.5 },
                new StackedLineChartData { X = "May", Y = 20, Y1 = 21, Y2 = -3 }, 
                new StackedLineChartData { X = "Jun", Y = 24, Y1 = 25, Y2 = -3.5 },
                new StackedLineChartData { X = "Jul", Y = 28, Y1 = 27, Y2 = -4 }, 
                new StackedLineChartData { X = "Aug", Y = 32, Y1 = 31, Y2 = -4.5 },
                new StackedLineChartData { X = "Sep", Y = 33, Y1 = 34, Y2 = -5 }, 
                new StackedLineChartData { X = "Oct", Y = 35, Y1 = 34, Y2 = -5.5 },
                new StackedLineChartData { X = "Nov", Y = 40, Y1 = 41, Y2 = -6 }, 
                new StackedLineChartData { X = "Dec", Y = 42, Y1 = 42, Y2 = -6.5 }
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
        }