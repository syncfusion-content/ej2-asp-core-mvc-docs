public ActionResult Index()
{
    List<ChartData> chartData = new List<ChartData>
    {
        new ChartData { x= new DateTime(2017, 12, 20), y= 21 },
        new ChartData { x= new DateTime(2017, 12, 21), y= 24 },
        new ChartData { x= new DateTime(2017, 12, 22), y= 24 },
        new ChartData { x= new DateTime(2017, 12, 26), y= 70 },
        new ChartData { x= new DateTime(2017, 12, 27), y= 75 },
        new ChartData { x= new DateTime(2018, 01, 02), y= 82 },
        new ChartData { x= new DateTime(2018, 01, 03), y= 53 },
        new ChartData { x= new DateTime(2018, 01, 04), y= 54 },
        new ChartData { x= new DateTime(2018, 01, 05), y= 53 },
        new ChartData { x= new DateTime(2018, 01, 08), y= 45 }
    };
    ViewBag.dataSource = chartData;
    return View();
}
public class ChartData
{
    public DateTime x;
    public double y;
}