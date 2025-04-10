public ActionResult Index()
    {
        List<RangeChartData> chartData = new List<RangeChartData>
        {
            new RangeChartData { X = "Jan", Low = 0.7, High = 6.1, Low1 = 1.7, High1 = 7.1 }, 
            new RangeChartData { X = "Feb", Low = 1.3, High = 6.3, Low1 = 1.9, High1 = 7.7 }, 
            new RangeChartData { X = "Mar", Low = 1.9, High = 8.5, Low1 = 1.2, High1 = 7.5 },
            new RangeChartData { X = "Apr", Low = 3.1, High = 10.8, Low1 = 2.5, High1 = 9.8 }, 
            new RangeChartData { X = "May", Low = 5.7, High = 14.40, Low1 = 4.7, High1 = 11.4 }, 
            new RangeChartData { X = "Jun", Low = 8.4, High = 16.90, Low1 = 6.4, High1 = 14.4 },
            new RangeChartData { X = "Jul", Low = 10.6, High = 19.20, Low1 = 9.6, High1 = 17.2 }, 
            new RangeChartData { X = "Aug", Low = 10.5, High = 18.9, Low1 = 10.7, High1 = 17.9 }, 
            new RangeChartData { X = "Sep", Low = 8.5, High = 16.1, Low1 = 7.5, High1 = 15.1 },
            new RangeChartData { X = "Oct", Low = 6.0, High = 12.5, Low1 = 3.0, High1 = 10.5 }, 
            new RangeChartData { X = "Nov", Low = 1.5, High = 6.9, Low1 = 1.2, High1 = 7.9 }, 
            new RangeChartData { X = "Dec", Low = 5.1, High = 12.1, Low1 = 4.1, High1 = 9.1 }
        };
        ViewBag.dataSource = chartData;
        return View();
    }
    public class RangeChartData
    {
        public string X;
        public double Low;
        public double High;
        public double Low1;
        public double High1;
    }