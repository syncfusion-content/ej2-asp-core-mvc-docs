public ActionResult Index()
        {
            List<StackedLineChartData> chartData = new List<StackedLineChartData>
            {
                new StackedLineChartData { X = 2000, Y = 0.61, Y1 = 0.03, Y2 = 0.48 },
                new StackedLineChartData { X = 2001, Y = 0.81, Y1 = 0.05, Y2 = 0.53 },
                new StackedLineChartData { X = 2002, Y = 0.91, Y1 = 0.06, Y2 = 0.57 },
                new StackedLineChartData { X = 2003, Y = 1,    Y1 = 0.09, Y2 = 0.61 }, 
                new StackedLineChartData { X = 2004, Y = 1.19, Y1 = 0.14, Y2 = 0.63 },
                new StackedLineChartData { X = 2005, Y = 1.47, Y1 = 0.20, Y2 = 0.64 },
                new StackedLineChartData { X = 2006, Y = 1.74, Y1 = 0.29, Y2 = 0.66 }, 
                new StackedLineChartData { X = 2007, Y = 1.98, Y1 = 0.46, Y2 = 0.76 },
                new StackedLineChartData { X = 2008, Y = 1.99, Y1 = 0.64, Y2 = 0.77 },
                new StackedLineChartData { X = 2009, Y = 1.70, Y1 = 0.75, Y2 = 0.55 }
            };
            ViewBag.dataSource = chartData;
            return View();
        }
        public class StackedLineChartData
        {
            public double X;
            public double Y;
            public double Y1;
            public double Y2;
        }