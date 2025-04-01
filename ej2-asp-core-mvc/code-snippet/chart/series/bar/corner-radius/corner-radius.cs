public ActionResult Index()
{
    List<BarChartData> chartData = new List<BarChartData>
    {
        new BarChartData { X = 2006, Y = 7.8 }, 
        new BarChartData { X = 2007, Y = -7.2 },
        new BarChartData { X = 2008, Y = 6.8 }, 
        new BarChartData { X = 2009, Y = -10.7 },
        new BarChartData { X = 2010, Y = 10.8}, 
        new BarChartData { X = 2011, Y = -9.8 }
    };
    ViewBag.dataSource = chartData;
    return View();
}
public class BarChartData
{
    public double X;
    public double Y;
}