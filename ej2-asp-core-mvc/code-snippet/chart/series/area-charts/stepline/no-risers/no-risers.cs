public IActionResult Index () 
{
    List<ChartData> chartData = new List<ChartData>
    {
        new ChartData { X = 2005,  Y = 370 },
        new ChartData { X = 2006,  Y = 378 },
        new ChartData { X = 2007,  Y = 416 },
        new ChartData { X = 2008,  Y = 404 },
        new ChartData { X = 2009,  Y = 390 },
        new ChartData { X = 2010,  Y = 376 },
        new ChartData { X = 2011,  Y = 365 },
        new ChartData { X = 2012,  Y = 350 }
    };
    ViewBag.dataSource = chartData;
    return View();
}
public class ChartData
{
    public double X;
    public double Y;
}