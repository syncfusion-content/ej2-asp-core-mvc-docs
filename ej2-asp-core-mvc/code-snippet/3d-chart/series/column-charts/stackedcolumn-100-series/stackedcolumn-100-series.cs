public ActionResult Index()
{
    List<ChartData> chartData = new List<ChartData>
    {
        new ChartData { x= "2013", y= 9628912, y1= 4298390, y2= 2842133 },
        new ChartData { x= "2014", y= 9609326, y1= 4513769, y2= 3016710 },
        new ChartData { x= "2015", y= 7485587, y1= 4543838, y2= 3034081 },
        new ChartData { x= "2016", y= 7793066, y1= 4999266, y2= 29452956 },
        new ChartData { x= "2017", y= 6856880, y1= 5235842, y2= 3302336 }
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
}