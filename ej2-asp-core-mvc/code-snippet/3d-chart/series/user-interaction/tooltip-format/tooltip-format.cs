public ActionResult Index()
{
    List<ChartData> chartData = new List<ChartData>
    {
        new ChartData { month = new DateTime(2024, 1, 1), sales = 35 },
        new ChartData { month = new DateTime(2024, 2, 1), sales = 28 },
        new ChartData { month = new DateTime(2024, 3, 1), sales = 34 },
        new ChartData { month = new DateTime(2024, 4, 1), sales = 32 },
        new ChartData { month = new DateTime(2024, 5, 1), sales = 40 },
        new ChartData { month = new DateTime(2024, 6, 1), sales = 32 },
        new ChartData { month = new DateTime(2024, 7, 1), sales = 35 },
        new ChartData { month = new DateTime(2024, 8, 1), sales = 55 },
        new ChartData { month = new DateTime(2024, 9, 1), sales = 38 },
        new ChartData { month = new DateTime(2024, 10, 1), sales = 30 },
        new ChartData { month = new DateTime(2024, 11, 1), sales = 25 },
        new ChartData { month = new DateTime(2024, 12, 1), sales = 32 }
    };
    ViewBag.dataSource = chartData;
    return View();
}
public class ChartData
{
    public DateTime month { get; set; }
    public double sales { get; set; }
}