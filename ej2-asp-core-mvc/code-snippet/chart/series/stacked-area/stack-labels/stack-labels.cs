public ActionResult Index()
        {
            List<StackedLineChartData> chartData = new List<StackedLineChartData>
            {
                new StackedLineChartData { X = new DateTime(2000, 0, 1), Y = 0.61, Y1 = 0.03, Y2 = 0.48, Y3 = 0.23 },
                new StackedLineChartData { X = new DateTime(2001, 0, 1), Y = 0.81, Y1 = 0.05, Y2 = 0.53, Y3 = 0.17 },
                new StackedLineChartData { X = new DateTime(2002, 0, 1), Y = 0.91, Y1 = 0.06, Y2 = 0.57, Y3 = 0.17 },
                new StackedLineChartData { X = new DateTime(2003, 0, 1), Y = 1,    Y1 = 0.09, Y2 = 0.61, Y3 = 0.20 },
                new StackedLineChartData { X = new DateTime(2004, 0, 1), Y = 1.19, Y1 = 0.14, Y2 = 0.63, Y3 = 0.23 },
                new StackedLineChartData { X = new DateTime(2005, 0, 1), Y = 1.47, Y1 = 0.20, Y2 = 0.64, Y3 = 0.36 },
                new StackedLineChartData { X = new DateTime(2006, 0, 1), Y = 1.74, Y1 = 0.29, Y2 = 0.66, Y3 = 0.43 },
                new StackedLineChartData { X = new DateTime(2007, 0, 1), Y = 1.98, Y1 = 0.46, Y2 = 0.76, Y3 = 0.52 },
                new StackedLineChartData { X = new DateTime(2008, 0, 1), Y = 1.99, Y1 = 0.64, Y2 = 0.77, Y3 = 0.72 },
                new StackedLineChartData { X = new DateTime(2009, 0, 1), Y = 1.70, Y1 = 0.75, Y2 = 0.55, Y3 = 1.29 },
                new StackedLineChartData { X = new DateTime(2010, 0, 1), Y = 1.48, Y1 = 1.06, Y2 = 0.54, Y3 = 1.38 },
                new StackedLineChartData { X = new DateTime(2011, 0, 1), Y = 1.38, Y1 = 1.25, Y2 = 0.57, Y3 = 1.82 },
                new StackedLineChartData { X = new DateTime(2012, 0, 1), Y = 1.66, Y1 = 1.55, Y2 = 0.61, Y3 = 2.16 },
                new StackedLineChartData { X = new DateTime(2013, 0, 1), Y = 1.66, Y1 = 1.55, Y2 = 0.67, Y3 = 2.51 },
                new StackedLineChartData { X = new DateTime(2014, 0, 1), Y = 1.67, Y1 = 1.65, Y2 = 0.67, Y3 = 2.61 }
            };
            ViewBag.dataSource = chartData;
            return View();
        }
        public class StackedLineChartData
        {
            public DateTime X;
            public double Y;
            public double Y1;
            public double Y2;
            public double Y3;
        }