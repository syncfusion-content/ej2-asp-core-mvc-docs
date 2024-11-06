public IActionResult Index () {
    List<ChartData> chartData = new List<ChartData>
    {
        new ChartData { x = "Jan", high = 14, low = 4, high1 = 29, low1 = 19 },
        new ChartData { x = "Feb", high = 17, low = 7, high1 = 32, low1 = 22 },
        new ChartData { x = "Mar", high = 20, low = 10, high1 = 35, low1 = 25 },
        new ChartData { x = "Apr", high = 22, low = 12, high1 = 37, low1 = 27 },
        new ChartData { x = "May", high = 20, low = 10, high1 = 35, low1 = 25 },
        new ChartData { x = "Jun", high = 17, low = 7, high1 = 32, low1 = 22 },
        new ChartData { x = "Jul", high = 15, low = 5, high1 = 30, low1 = 20 },
        new ChartData { x = "Aug", high = 17, low = 7, high1 = 32, low1 = 22 },
        new ChartData { x = "Sep", high = 20, low = 10, high1 = 35, low1 = 25 },
        new ChartData { x = "Oct", high = 22, low = 12, high1 = 37, low1 = 27 },
        new ChartData { x = "Nov", high = 20, low = 10, high1 = 35, low1 = 25 },
        new ChartData { x = "Dec", high = 17, low = 7, high1 = 32, low1 = 22 }
    };
    ViewBag.dataSource = chartData;
    return View();
}
public class ChartData
{
    public string x;
    public double high;
    public double low;
    public double high1;
    public double low1;
}