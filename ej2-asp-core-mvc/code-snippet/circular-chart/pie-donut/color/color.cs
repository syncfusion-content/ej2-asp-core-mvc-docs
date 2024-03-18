public IActionResult Index()
{
    List<CircularChartData> circularData = new List<CircularChartData>
    {
        new CircularChartData { X = "Jan",  Y = 3,    Fill = "#498fff", Text = "January" },
        new CircularChartData { X = "Feb",  Y = 3.5,  Fill = "#ffa060", Text = "February" },
        new CircularChartData { X = "Mar",  Y = 7,    Fill = "#ff68b6", Text = "March" },
        new CircularChartData { X = "Apr",  Y = 13.5, Fill = "#81e2a1", Text = "April" }
    };
    ViewBag.dataSource = circularData;
    return View();
}
public class CircularChartData
{
    public string X;
    public double Y;
    public string Fill;
    public string Text;
}