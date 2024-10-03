public IActionResult Index () 
{
    List<ChartData> chartData = new List<ChartData>
    {
        new ChartData { X = "Jan", High = 29, Low = 19 },
        new ChartData { X = "Feb", High = 32, Low = 22 },
        new ChartData { X = "Mar", High = 35, Low = 25 },
        new ChartData { X = "Apr", High = 37, Low = 27 },
        new ChartData { X = "May", High = 35, Low = 25 },
        new ChartData { X = "Jun", High = 32, Low = 22 },
        new ChartData { X = "Jul", High = 30, Low = 20 },
        new ChartData { X = "Aug", High = 32, Low = 22 },
        new ChartData { X = "Sep", High = 35, Low = 25 },
        new ChartData { X = "Oct", High = 37, Low = 27 },
        new ChartData { X = "Nov", High = 35, Low = 25 },
        new ChartData { X = "Dec", High = 32, Low = 22 }
    };
    ViewBag.dataSource = chartData;
    return View();
}
public class ChartData
{
    public string X;
    public double High;
    public double Low;
}