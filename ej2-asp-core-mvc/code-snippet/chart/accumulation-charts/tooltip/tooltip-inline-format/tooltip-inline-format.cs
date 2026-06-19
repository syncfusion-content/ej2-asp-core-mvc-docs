public ActionResult Index()
{
    List<AccumulationChartData> chartData = new List<AccumulationChartData>
    {
        new AccumulationChartData { x = new DateTime(2024, 1, 1), y = 3 },
        new AccumulationChartData { x = new DateTime(2024, 2, 1), y = 3.5 },
        new AccumulationChartData { x = new DateTime(2024, 3, 1), y = 7 },
        new AccumulationChartData { x = new DateTime(2024, 4, 1), y = 13.5 },
        new AccumulationChartData { x = new DateTime(2024, 5, 1), y = 19 },
        new AccumulationChartData { x = new DateTime(2024, 6, 1), y = 23.5 },
        new AccumulationChartData { x = new DateTime(2024, 7, 1), y = 26 },
        new AccumulationChartData { x = new DateTime(2024, 8, 1), y = 25 },
        new AccumulationChartData { x = new DateTime(2024, 9, 1), y = 21 },
        new AccumulationChartData { x = new DateTime(2024, 10, 1), y = 15 }
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