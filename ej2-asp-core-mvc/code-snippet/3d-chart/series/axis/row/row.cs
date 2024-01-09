public ActionResult Index()
{
    List<ChartData> chartData = new List<ChartData>
    {
        new ChartData { x= "Jan", y= 15, y1= 33 },
        new ChartData { x= "Feb", y= 20, y1= 31 },
        new ChartData { x= "Mar", y= 35, y1= 30 },
        new ChartData { x= "Apr", y= 40, y1= 28 },
        new ChartData { x= "May", y= 80, y1= 29 },
        new ChartData { x= "Jun", y= 70, y1= 30 },
        new ChartData { x= "Jul", y= 65, y1= 33 },
        new ChartData { x= "Aug", y= 55, y1= 32 },
        new ChartData { x= "Sep", y= 50, y1= 34 },
        new ChartData { x= "Oct", y= 30, y1= 32 },
        new ChartData { x= "Nov", y= 35, y1= 32 },
        new ChartData { x= "Dec", y= 35, y1= 31 }
    };
    ViewBag.dataSource = chartData;
    return View();
}
public class ChartData
{
    public string x;
    public double y;
    public double y1;
}