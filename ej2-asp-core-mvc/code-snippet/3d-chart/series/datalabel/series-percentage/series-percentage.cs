public ActionResult Index()
{
    List<ChartData> chartData = new List<ChartData>
    {
        new ChartData { country= "USA",  gold= 46 },
        new ChartData { country= "GBR",  gold= 27 },
        new ChartData { country= "CHN",  gold= 26 }
    };
    ViewBag.dataSource = chartData;
    return View();
}
public class ChartData
{
    public string country;
    public double gold;
}