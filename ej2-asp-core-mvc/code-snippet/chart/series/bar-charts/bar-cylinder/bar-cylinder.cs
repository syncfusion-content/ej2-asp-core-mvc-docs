public ActionResult Index()
{
    List<CylinderChartData> chartData = new List<CylinderChartData>
    {
        new CylinderChartData { x= 2006, y= 9 },
        new CylinderChartData { x= 2007, y= 7.8 },
        new CylinderChartData { x= 2008, y= 10.5 },
        new CylinderChartData { x= 2009, y= 8.4 },
        new CylinderChartData { x= 2010, y= 6 },
        new CylinderChartData { x= 2011, y= 11 }               
    };
    ViewBag.dataSource = chartData;
    return View();
}
public class CylinderChartData
{
    public double x;
    public double y;
}