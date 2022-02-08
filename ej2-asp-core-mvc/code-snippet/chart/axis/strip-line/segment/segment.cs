public ActionResult Index()
        {
            List<LineChartData> chartData = new List<LineChartData>
            {
                new LineChartData { xValue = 1, yValue = 5 },
                new LineChartData { xValue = 2, yValue = 39 },
                new LineChartData { xValue = 3, yValue = 21 },
                new LineChartData { xValue = 4, yValue = 51 },
                new LineChartData { xValue = 5, yValue = 30 },
                new LineChartData { xValue = 6, yValue = 26 }
            };

            List<ChartStripLine> yaxisstriplines = new List<ChartStripLine>();
            ChartStripLine stripy1 = new ChartStripLine();
            stripy1.Start = 20;
            stripy1.End = 40;
            stripy1.IsSegmented = true;
            stripy1.SegmentStart = 2;
            stripy1.SegmentEnd = 4;
            stripy1.Color = "rgba(167,169,171, 0.3)";
            stripy1.Visible = true;
            yaxisstriplines.Add(stripy1);

            ViewBag.yAxis = yaxisstriplines;
            ViewBag.dataSource = chartData;
            return View();
        }
        public class LineChartData
        {
            public double xValue;
            public double yValue;
        }
