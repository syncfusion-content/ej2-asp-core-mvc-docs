public IActionResult Index()
{
    List<MultiExportChartData> chartData = new List<MultiExportChartData>
    {
        new MultiExportChartData { x = new DateTime(2012, 01, 01), y = 11.0, y1 = 19.5, y2 = 7.1 },
        new MultiExportChartData { x = new DateTime(2013, 01, 01), y = 12.9, y1 = 17.5, y2 = 6.8 },
        new MultiExportChartData { x = new DateTime(2014, 01, 01), y = 13.4, y1 = 15.5, y2 = 4.1 },
        new MultiExportChartData { x = new DateTime(2015, 01, 01), y = 13.7, y1 = 10.3, y2 = 2.8 },
        new MultiExportChartData { x = new DateTime(2016, 01, 01), y = 12.7, y1 = 7.8,  y2 = 2.8 },
        new MultiExportChartData { x = new DateTime(2017, 01, 01), y = 12.5, y1 = 5.7,  y2 = 3.8 },
        new MultiExportChartData { x = new DateTime(2018, 01, 01), y = 12.7, y1 = 5.9,  y2 = 4.3 },
        new MultiExportChartData { x = new DateTime(2019, 01, 01), y = 12.4, y1 = 5.6,  y2 = 4.7 },
        new MultiExportChartData { x = new DateTime(2020, 01, 01), y = 13.5, y1 = 5.3,  y2 = 5.6 }
    };
    ViewBag.dataSource = chartData;
    return View();
}
public class MultiExportChartData
{
    public DateTime x;
    public double y;
    public double y1;
    public double y2;
}