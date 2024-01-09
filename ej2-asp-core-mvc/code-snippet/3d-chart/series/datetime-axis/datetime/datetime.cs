public ActionResult Index()
{
    List<ChartData> chartData = new List<ChartData>
    {
        new ChartData { x= new DateTime(2000, 06, 11),  y= 10 },
        new ChartData { x= new DateTime(2002, 03, 07),  y= 30 },
        new ChartData { x= new DateTime(2004, 03, 06),  y= 15 },
        new ChartData { x= new DateTime(2006, 03, 30),  y= 65 },
        new ChartData { x= new DateTime(2008, 03, 08),  y= 90 },
        new ChartData { x= new DateTime(2010, 03, 08),  y= 85 }
    };
    ViewBag.dataSource = chartData;
    return View();
}
public class ChartData
{
    public DateTime x;
    public double y;
}