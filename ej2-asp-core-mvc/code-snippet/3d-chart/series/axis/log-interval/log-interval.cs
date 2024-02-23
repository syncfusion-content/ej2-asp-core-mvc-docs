public ActionResult Index()
{
    List<ChartData> chartData = new List<ChartData>
    {
        new ChartData { x= new DateTime(1995, 01, 01), y= 80 },
        new ChartData { x= new DateTime(1996, 01, 01), y= 200 },
        new ChartData { x= new DateTime(1997, 01, 01), y= 400 },
        new ChartData { x= new DateTime(1998, 01, 01), y= 600 },
        new ChartData { x= new DateTime(1999, 01, 01), y= 700 },
        new ChartData { x= new DateTime(2000, 01, 01), y= 1400 },
        new ChartData { x= new DateTime(2001, 01, 01), y= 2000 },
        new ChartData { x= new DateTime(2002, 01, 01), y= 4000 },
        new ChartData { x= new DateTime(2003, 01, 01), y= 6000 },
        new ChartData { x= new DateTime(2004, 01, 01), y= 8000 },
        new ChartData { x= new DateTime(2005, 01, 01), y= 11000 }
    };
    ViewBag.dataSource = chartData;
    return View();
}
public class ChartData
{
    public DateTime x;
    public double y;
}