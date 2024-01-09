public ActionResult Index()
{
    List<ChartData> chartData = new List<ChartData>
    {
        new ChartData { x= "South Korea",     y= 39.4 },
        new ChartData { x= "India",           y= 61.3 },
        new ChartData { x= "Pakistan",        y= 20.4 },
        new ChartData { x= "Germany",         y= 65.1 },
        new ChartData { x= "Australia",       y= 15.8 },
        new ChartData { x= "Italy",           y= 29.2 },
        new ChartData { x= "United Kingdom",  y= 44.6 },
        new ChartData { x= "Saudi Arabia",    y= 9.7  },
        new ChartData { x= "Russia",          y= 40.8 },
        new ChartData { x= "Mexico",          y= 31   },
        new ChartData { x= "Brazil",          y= 75.9 },
        new ChartData { x= "China",           y= 51.4 }
    };
    ViewBag.dataSource = chartData;
    return View();
}
public class ChartData
{
    public string x;
    public double y;
}