public ActionResult Index()
    {
        List<StackedColumnChartData> chartData = new List<StackedColumnChartData>
        {
            new StackedColumnChartData { X = new DateTime(2006, 01, 01), Y = 900, Y1 = 190, Y2 = 250, Y3 = 150 },
            new StackedColumnChartData { X = new DateTime(2007, 01, 01), Y = 544, Y1 = 226, Y2 = 145, Y3 = 120 },
            new StackedColumnChartData { X = new DateTime(2008, 01, 01), Y = 880, Y1 = 194, Y2 = 190, Y3 = 115 },
            new StackedColumnChartData { X = new DateTime(2009, 01, 01), Y = 675, Y1 = 250, Y2 = 220, Y3 = 125 },
            new StackedColumnChartData { X = new DateTime(2010, 01, 01), Y = 765, Y1 = 222, Y2 = 225, Y3 = 132 },
            new StackedColumnChartData { X = new DateTime(2011, 01, 01), Y = 679, Y1 = 181, Y2 = 135, Y3 = 137 },
            new StackedColumnChartData { X = new DateTime(2012, 01, 01), Y = 770, Y1 = 128, Y2 = 152, Y3 = 110 }
        };
        ViewBag.dataSource = chartData;
        return View();
    }
    public class StackedColumnChartData
    {
        public DateTime X;
        public double Y;
        public double Y1;
        public double Y2;
        public double Y3;
    }