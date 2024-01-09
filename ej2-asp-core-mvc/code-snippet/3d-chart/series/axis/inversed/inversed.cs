public ActionResult Index()
{
    List<ChartData> chartData = new List<ChartData>
    {
        new ChartData { country= "USA",       gold= 50 },
        new ChartData { country= "China",     gold= 40 },
        new ChartData { country= "Japan",     gold= 70 },
        new ChartData { country= "Australia", gold= 60 },
        new ChartData { country= "France",    gold= 50 },
        new ChartData { country= "Germany",   gold= 40 },
        new ChartData { country= "Italy",     gold= 40 },
        new ChartData { country= "Sweden",    gold= 30 }
    };
    ViewBag.dataSource = chartData;
    return View();
}
public class ChartData
{
    public string country;
    public double gold;
}