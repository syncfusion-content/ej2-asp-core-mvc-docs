public IActionResult Index()
{
    List<CircularChartData> circularData = new List<CircularChartData>
    {
        new CircularChartData { X = "Jan",  Y = 13 },
        new CircularChartData { X = "Feb",  Y = 13 },
        new CircularChartData { X = "Mar",  Y = 17 },
        new CircularChartData { X = "Apr",  Y = 13.5 }
    };
    ViewBag.dataSource = circularData;
    return View();
}
public class CircularChartData
{
    public string X;
    public double Y;
}