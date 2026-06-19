public IActionResult Index()
{
    List<ChartData> chartData = new List<ChartData>
    {
        new ChartData { x = new DateTime(1975, 01, 01), y = 16, y1 = 10, y2 = 4.5 },
        new ChartData { x = new DateTime(1980, 01, 01), y = 12.5, y1 = 7.5, y2 = 5 },
        new ChartData { x = new DateTime(1985, 01, 01), y = 19, y1 = 11, y2 = 6.5 },
        new ChartData { x = new DateTime(1990, 01, 01), y = 14.4, y1 = 7, y2 = 4.4 },
        new ChartData { x = new DateTime(1995, 01, 01), y = 11.5, y1 = 8, y2 = 5 },
        new ChartData { x = new DateTime(2000, 01, 01), y = 14, y1 = 6, y2 = 1.5 },
        new ChartData { x = new DateTime(2005, 01, 01), y = 10, y1 = 3.5, y2 = 2.5 },
        new ChartData { x = new DateTime(2010, 01, 01), y = 16, y1 = 7, y2 = 3.7 }
    };

    ViewBag.dataSource = chartData;
    return View();
}

public class ChartData
{
    public DateTime x;
    public double y;
    public double y1;
    public double y2;
}