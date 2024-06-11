public ActionResult Index()
{
    List<DynamicChartData> chartData = new List<DynamicChartData>
    {
        new DynamicChartData{ x= "Germany",        y= 72    },
        new DynamicChartData{ x= "Russia",         y= 103.1 },
        new DynamicChartData{ x= "Brazil",         y= 139.1 },
        new DynamicChartData{ x= "India",          y= 462.1 },
        new DynamicChartData{ x= "China",          y= 721.4 },
        new DynamicChartData{ x= "USA",            y= 286.9 },
        new DynamicChartData{ x= "Great Britain",  y= 115.1 },
        new DynamicChartData{ x= "Nigeria",        y= 97.2  }
    };
    ViewBag.dataSource = chartData;
    return View();
}
public class DynamicChartData
{
    public string x;
    public double y;
}