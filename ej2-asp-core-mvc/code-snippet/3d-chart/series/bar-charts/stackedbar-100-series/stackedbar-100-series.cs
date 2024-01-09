public ActionResult Index()
{
    List<ChartData> chartData = new List<ChartData>
    {
        new ChartData { x= "2013", y= 9628912, y1= 4298390, y2= 2842133, y3= 2006366 },
        new ChartData { x= "2014", y= 9609326, y1= 4513769, y2= 3016710, y3= 2165566 },
        new ChartData { x= "2015", y= 7485587, y1= 4543838, y2= 3034081, y3= 2279503 },
        new ChartData { x= "2016", y= 7793066, y1= 4999266, y2= 2945295, y3= 2359756 },
        new ChartData { x= "2017", y= 6856880, y1= 5235842, y2= 3302336, y3= 2505741 }
    };
    ViewBag.dataSource = chartData;
    return View();
}
public class ChartData
{
    public string x;
    public double y;
    public double y1;
    public double y2;
    public double y3;
}