public IActionResult Index()
{
    List<ExcelExportChartData> chartData = new List<ExcelExportChartData>
    {
        new ExcelExportChartData { X = "John",  Y = 10000 },
        new ExcelExportChartData { X = "Jake",  Y = 12000 },
        new ExcelExportChartData { X = "Peter", Y = 18000 },
        new ExcelExportChartData { X = "James", Y = 11000 },
        new ExcelExportChartData { X = "Mary",  Y = 9700  }
    };
    ViewBag.dataSource = chartData;
    return View();
}
public class ExcelExportChartData
{
    public string X;
    public double Y;
}