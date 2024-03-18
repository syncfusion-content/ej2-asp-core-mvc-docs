public IActionResult Index()
{
    List<CircularChartData> circularData = new List<CircularChartData>
    {
        new CircularChartData { X = "Jan",  Y = 3 },
        new CircularChartData { X = "Feb",  Y = 3.5 },
        new CircularChartData { X = "Mar",  Y = undefined },
        new CircularChartData { X = "Apr",  Y = 13.5 },
        new CircularChartData { X = "May",  Y = 19 },
        new CircularChartData { X = "Jun",  Y = 23.5 },
        new CircularChartData { X = "Jul",  Y = null },
        new CircularChartData { X = "Aug",  Y = 25 },
        new CircularChartData { X = "Sep",  Y = 21 },
        new CircularChartData { X = "Oct",  Y = 15 }
    };
    ViewBag.dataSource = circularData;
    return View();
}
public class CircularChartData
{
    public string X;
    public double Y;
}