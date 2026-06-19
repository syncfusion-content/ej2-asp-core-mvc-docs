public IActionResult Index()
{
    List<AccumulationChartData> chartData = new List<AccumulationChartData>
    {
        new AccumulationChartData { x = new DateTime(2024, 01, 01), y = 13, text = "Jan: 13" },
        new AccumulationChartData { x = new DateTime(2024, 02, 01), y = 13, text = "Feb: 13" },
        new AccumulationChartData { x = new DateTime(2024, 03, 01), y = 17, text = "Mar: 17" },
        new AccumulationChartData { x = new DateTime(2024, 04, 01), y = 13.5, text = "Apr: 13.5" }
    };

    ViewBag.dataSource = chartData;
    return View();
}

public class AccumulationChartData
{
    public DateTime x;
    public double y;
    public string text;
}