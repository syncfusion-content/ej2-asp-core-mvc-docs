public ActionResult Index()
{
    List<ColumnData> chartData = new List<ColumnData>
    {
        new ColumnData { Year = "2012", USA_Total = 104, USA_Gold = 46, UK_Total = 65, UK_Gold = 29 },
        new ColumnData { Year = "2016", USA_Total = 121, USA_Gold = 46, UK_Total = 67, UK_Gold = 27 },
        new ColumnData { Year = "2020", USA_Total = 113, USA_Gold = 39, UK_Total = 65, UK_Gold = 22 },
    };
    ViewBag.dataSource = chartData;
    return View();
}
public class ColumnData
{
    public string Year;
    public double USA_Total;
    public double USA_Gold;
    public double UK_Total;
    public double UK_Gold;
}