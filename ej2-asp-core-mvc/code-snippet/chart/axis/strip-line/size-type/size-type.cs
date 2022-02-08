public ActionResult Index()
        {
            List<LineChartData> chartData = new List<LineChartData>
            {
                new LineChartData { xValue = new DateTime(2005, 01, 01), yValue = 21 },
                new LineChartData { xValue = new DateTime(2006, 01, 01), yValue = 24 },
                new LineChartData { xValue = new DateTime(2007, 01, 01), yValue = 36 },
                new LineChartData { xValue = new DateTime(2008, 01, 01), yValue = 38 },
            };
            ViewBag.dataSource = chartData;

            List<ChartStripLine> yaxisstriplines = new List<ChartStripLine>();
            ChartStripLine stripy1 = new ChartStripLine();
            stripy1.Start = new DateTime(2005, 01, 01);
            stripy1.Size = 1;
            stripy1.SizeType = SizeType.Years;
            stripy1.Color = "rgba(167,169,171, 0.3)";
            stripy1.Visible = true;
            yaxisstriplines.Add(stripy1);

            ViewBag.yAxis = yaxisstriplines;
            return View();
        }
        public class LineChartData
        {
            public System.DateTime xValue;
            public double yValue;
        }