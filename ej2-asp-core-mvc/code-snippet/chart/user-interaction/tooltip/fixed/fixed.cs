public IActionResult Index()
{
    List<ColumnChartData> chartData = new List<ColumnChartData>
    {
        new ColumnChartData { xValue= "USA", yValue= 46 }, 
        new ColumnChartData { xValue= "GBR", yValue= 27 }, 
        new ColumnChartData { xValue= "CHN", yValue= 26 },
        new ColumnChartData { xValue= "UK",  yValue= 26 },
        new ColumnChartData { xValue= "AUS", yValue= 26 },
        new ColumnChartData { xValue= "IND", yValue= 26 },
        new ColumnChartData { xValue= "DEN", yValue= 26 },
        new ColumnChartData { xValue= "MEX", yValue= 26 }
    };
    ViewBag.dataSource = chartData;
    return View();
}
public class ColumnChartData
{
    public string xValue;
    public double yValue;
}