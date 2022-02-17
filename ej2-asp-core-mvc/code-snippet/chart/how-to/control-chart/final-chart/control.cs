public IActionResult Index()
        {
            List<LineChartData> chartData = new List<LineChartData>
            {
                new LineChartData { xValue = new DateTime(1975, 01, 01), yValue = 36},
                new LineChartData { xValue = new DateTime(1980, 01, 01), yValue = 32.5 },
                new LineChartData { xValue = new DateTime(1985, 01, 01), yValue = 39 },
                new LineChartData { xValue = new DateTime(1990, 01, 01), yValue = 34.4 },
                new LineChartData { xValue = new DateTime(1995, 01, 01), yValue = 31.5 },
                new LineChartData { xValue = new DateTime(2000, 01, 01), yValue = 40 },
                new LineChartData { xValue = new DateTime(2005, 01, 01), yValue = 60 },
                new LineChartData { xValue = new DateTime(2010, 01, 01), yValue = 66 },
            };
            ViewBag.dataSource = chartData;
            
            List<ChartStripLine> yAxisStripline = new List<ChartStripLine>();
            ChartStripLine ystripline1 = new ChartStripLine();
            ystripline1.Start = "30";
            ystripline1.End = "40";
            ystripline1.Text = "";
            ystripline1.Color = "black";
            ystripline1.Visible = true;

            ChartStripLine ystripline2 = new ChartStripLine();
            ystripline2.Start = "20";
            ystripline2.End = "30";
            ystripline2.Text = "";
            ystripline2.Color = "black";
            ystripline2.Visible = true;

            ChartStripLine ystripline3 = new ChartStripLine();
            ystripline3.Start = "10";
            ystripline3.End = "20";
            ystripline3.Text = "";
            ystripline3.Color = "black";
            ystripline3.Visible = true;

            yAxisStripline.Add(ystripline1);
            yAxisStripline.Add(ystripline2);
            yAxisStripline.Add(ystripline3);
            ViewBag.yAxisStripLine = yAxisStripline;
            return View();
        }
        public class LineChartData
        {
            public DateTime xValue;
            public double yValue;
        }