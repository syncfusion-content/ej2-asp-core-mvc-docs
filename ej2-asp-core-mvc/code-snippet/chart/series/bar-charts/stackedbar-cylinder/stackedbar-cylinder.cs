public ActionResult Index()
{
    List<CylinderChartData> chartData = new List<CylinderChartData>
    {
        new CylinderChartData { x= 2000, y= 0.61, y1= 0.03, y2= 0.48 },
        new CylinderChartData { x= 2001, y= 0.81, y1= 0.05, y2= 0.53 },
        new CylinderChartData { x= 2002, y= 0.91, y1= 0.06, y2= 0.57 },
        new CylinderChartData { x= 2003, y= 1,    y1= 0.09, y2= 0.61 },
        new CylinderChartData { x= 2004, y= 1.19, y1= 0.14, y2= 0.63 },
        new CylinderChartData { x= 2005, y= 1.47, y1= 0.20, y2= 0.64 },
        new CylinderChartData { x= 2006, y= 1.74, y1= 0.29, y2= 0.66 },
        new CylinderChartData { x= 2007, y= 1.98, y1= 0.46, y2= 0.76 },
        new CylinderChartData { x= 2008, y= 1.99, y1= 0.64, y2= 0.77 },
        new CylinderChartData { x= 2009, y= 1.70, y1= 0.75, y2= 0.55 }              
    };
    ViewBag.dataSource = chartData;
    return View();
}
public class CylinderChartData
{
    public double x;
    public double y;
    public double y1;
    public double y2;
}