public ActionResult Index()
{
    List<ChartData> chartData = new List<ChartData>
    {
        new ChartData { country= "USA",       gold= 50, silver= 70, bronze= 45 },
        new ChartData { country= "China",     gold= 40, silver= 60, bronze= 55 },
        new ChartData { country= "Japan",     gold= 70, silver= 60, bronze= 50 },
        new ChartData { country= "Australia", gold= 60, silver= 56, bronze= 40 },
        new ChartData { country= "France",    gold= 50, silver= 45, bronze= 35 },
        new ChartData { country= "Germany",   gold= 40, silver= 30, bronze= 22 },
        new ChartData { country= "Italy",     gold= 40, silver= 35, bronze= 37 },
        new ChartData { country= "Sweden",    gold= 30, silver= 25, bronze= 27 }
    };
    ViewBag.dataSource = chartData;
    return View();
}
public class ChartData
{
    public string country;
    public double gold;
    public double silver;
    public double bronze;
}