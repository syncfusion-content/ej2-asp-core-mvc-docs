public IActionResult Index()
{
    List<ExcelExportChartData> chartData = new List<ExcelExportChartData>
    {
        new ExcelExportChartData { x= "John",  y= 10000 },
        new ExcelExportChartData { x= "Jake",  y= 12000 },
        new ExcelExportChartData { x= "Peter", y= 18000 },
        new ExcelExportChartData { x= "James", y= 11000 },
        new ExcelExportChartData { x= "Mary",  y= 9700  }
    };
    ViewBag.dataSource = chartData;
    return View();
}
public class ExcelExportChartData
{
    public string x;
    public double y;
}