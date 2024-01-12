public ActionResult Index()
{
    List<ChartData> chartData = new List<ChartData>
    {
        new ChartData { x= "Sochi",        y= 9,    y1= 10,  y2= 4  },
        new ChartData { x= "Rio",          y= 46,   y1= 4,   y2= 10 },
        new ChartData { x= "Pyeongchang",  y= 9,    y1= 11,  y2= 5  },
        new ChartData { x= "Tokyo",        y= 39,   y1= 7,   y2= 10 },
        new ChartData { x= "Beijing",      y= 8,    y1= 4,   y2= 5  }
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