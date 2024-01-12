public ActionResult Index()
{
    List<ChartData> chartData = new List<ChartData>
    {
        new ChartData { x= new DateTime(2000, 07, 11),  y= 10 },
        new ChartData { x= new DateTime(2002, 04, 07),  y= 30 },
        new ChartData { x= new DateTime(2004, 04, 06),  y= 15 },
        new ChartData { x= new DateTime(2006, 04, 30),  y= 65 },
        new ChartData { x= new DateTime(2008, 04, 08),  y= 90 },
        new ChartData { x= new DateTime(2010, 04, 08),  y= 85 }
    };
    ViewBag.dataSource = chartData;
    return View();
}
public class ChartData
{
    public DateTime x;
    public double y;
}