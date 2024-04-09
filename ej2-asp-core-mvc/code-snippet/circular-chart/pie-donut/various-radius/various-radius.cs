public IActionResult Index()
{
    List<CircularChartData> circularData = new List<CircularChartData>
    {
        new CircularChartData { X = "Belgium",            Y = 551500, R = "110.7" },
        new CircularChartData { X = "Cuba",               Y = 312685, R = "124.6" },
        new CircularChartData { X = "Dominican Republic", Y = 350000, R = "137.5" },
        new CircularChartData { X = "Egypt",              Y = 301000, R = "150.8" },
        new CircularChartData { X = "Kazakhstan",         Y = 300000, R = "155.5" },
        new CircularChartData { X = "Somalia",            Y = 357022, R = "160.6" },
        new CircularChartData { X = "Argentina",          Y = 505370, R = "100"   }
    };
    ViewBag.dataSource = circularData;
    return View();
}
public class CircularChartData
{
    public string X;
    public double Y;
    public string R;
}