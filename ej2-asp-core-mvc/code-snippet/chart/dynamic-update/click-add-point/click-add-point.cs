public ActionResult Index()
{
    List<DynamicChartData> chartData = new List<DynamicChartData>
    {
        new DynamicChartData { x = 20,  y = 20 },
        new DynamicChartData { x = 80,  y = 80 }
    };
    ViewBag.dataSource = chartData;
    return View();
}
public class DynamicChartData
{
    public double x;
    public double y;
}