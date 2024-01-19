public ActionResult Index()
{
    List<ChartData> chartData = new List<ChartData>
    {
        new ChartData { country= "USA",       gold= 50 },
        new ChartData { country= "China",     gold= 40 },
        new ChartData { country= "Japan",     gold= 70 },
        new ChartData { country= "Australia", gold= 60 }
    };
    ViewBag.dataSource = chartData;
    return View();
}
public class ChartData
{
    public string country;
    public double gold;
}