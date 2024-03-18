public IActionResult Index()
{
    List<CircularChartData> circularData = new List<CircularChartData>
    {
        new CircularChartData { X = "Net-tution",      Y = 21 },
        new CircularChartData { X = "Private Gifts",   Y = 8 },
        new CircularChartData { X = "All Other",       Y = 9 },
        new CircularChartData { X = "Local Revenue",   Y = 4 },
        new CircularChartData { X = "State Revenue",   Y = 21 },
        new CircularChartData { X = "Federal Revenue", Y = 16 },
        new CircularChartData { X = "Self-supporting Operations",  Y = 21 }
    };
    ViewBag.dataSource = circularData;
    return View();
}
public class CircularChartData
{
    public string X;
    public double Y;
}