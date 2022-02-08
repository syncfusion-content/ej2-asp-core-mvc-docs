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
            ChartStripLine stripy = new ChartStripLine();
            stripy.Start = 20;
            stripy.End = 40;
            stripy.IsSegmented = true;
            stripy.SegmentStart = 2;
            stripy.SegmentEnd = 4;
            stripy.Color = "rgba(167,169,171, 0.3)";
            stripy.Visible = true;
            yaxisstriplines.Add(stripy);

            ViewBag.yAxis = yaxisstriplines;
            ViewBag.dataSource = chartData;
            return View();
        }
        public class LineChartData
        {
            public double xValue;
            public double yValue;
        }
