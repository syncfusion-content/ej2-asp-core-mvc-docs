public ActionResult Index()
{
    List<ColumnChartData> chartData = new List<ColumnChartData>
    {
        new ColumnChartData { Country = "USA",       Gold = -50 },
        new ColumnChartData { Country = "China",     Gold = 40 },
        new ColumnChartData { Country = "Japan",     Gold = -70 },
        new ColumnChartData { Country = "Australia", Gold = 60 },
        new ColumnChartData { Country = "France",    Gold = -50 },
        new ColumnChartData { Country = "Germany",   Gold = -40 },
        new ColumnChartData { Country = "Italy",     Gold = 40 },
        new ColumnChartData { Country = "Sweden",    Gold = 30 }
    };
    ViewBag.dataSource = chartData;
    return View();
}
public class ColumnChartData
{
    public string Country;
    public double Gold;
}