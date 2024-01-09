public ActionResult Index()
{
    List<ChartData> chartData = new List<ChartData>
    {
        new ChartData { x= "WW",     y= 12,   y1= 22,   y2= 38.3, y3= 50   },
        new ChartData { x= "EU",     y= 9.9,  y1= 26,   y2= 45.2, y3= 63.6 },
        new ChartData { x= "APAC",   y= 4.4,  y1= 9.3,  y2= 18.2, y3= 20.9 },
        new ChartData { x= "LATAM",  y= 6.4,  y1= 28,   y2= 46.7, y3= 65.1 },
        new ChartData { x= "MEA",    y= 30,   y1= 45.7, y2= 61.5, y3= 73   },
        new ChartData { x= "NA",     y= 25.3, y1= 35.9, y2= 64,   y3= 81.4 }
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