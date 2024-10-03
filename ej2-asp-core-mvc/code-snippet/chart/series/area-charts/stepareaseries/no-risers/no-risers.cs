public IActionResult Index () 
{
    List<ChartData> chartData = new List<ChartData>
    {
        new ChartData { X = 1,  Y = 7 },
        new ChartData { X = 2,  Y = 1 },
        new ChartData { X = 3,  Y = 1 },
        new ChartData { X = 4,  Y = 14 },
        new ChartData { X = 5,  Y = 1 },
        new ChartData { X = 6,  Y = 10 },
        new ChartData { X = 7,  Y = 8 },
        new ChartData { X = 8,  Y = 6 },
        new ChartData { X = 9,  Y = 10 },
        new ChartData { X = 10, Y = 10 },
        new ChartData { X = 11, Y = 16 },
        new ChartData { X = 12, Y = 6 },
        new ChartData { X = 13, Y = 14 },
        new ChartData { X = 14, Y = 7 },
        new ChartData { X = 15, Y = 5 },
        new ChartData { X = 16, Y = 2 },
        new ChartData { X = 17, Y = 14 },
        new ChartData { X = 18, Y = 7 },
        new ChartData { X = 19, Y = 7 },
        new ChartData { X = 20, Y = 10 }
    };
    ViewBag.dataSource = chartData;
    return View();
}
public class ChartData
{
    public double X;
    public double Y;
}