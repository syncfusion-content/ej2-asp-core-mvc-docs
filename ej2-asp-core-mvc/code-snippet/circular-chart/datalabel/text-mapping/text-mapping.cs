public IActionResult Index()
{
    List<CircularChartData> circularData = new List<CircularChartData>
    {
        new CircularChartData { X = "Jan",  Y = 3, Text = "January" },
        new CircularChartData { X = "Feb",  Y = 3.5, Text = "February" },
        new CircularChartData { X = "Mar",  Y = 7, Text = "March" },
        new CircularChartData { X = "Apr",  Y = 13.5, Text = "April" }
    };
    ViewBag.dataSource = circularData;
    return View();
}
public class CircularChartData
{
    public string X;
    public double Y;
    public string Text;
}