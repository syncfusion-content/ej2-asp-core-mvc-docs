public ActionResult Index()
{
    List<PieChartData> chartData = new List<PieChartData>
    {
        new PieChartData { X = "Jan", Y = 3 },
        new PieChartData { X = "Feb", Y = 3.5 },
        new PieChartData { X = "Mar", Y = 7 },
        new PieChartData { X = "Apr", Y = 13.5 },
        new PieChartData { X = "May", Y = 19 },
        new PieChartData { X = "Jun", Y = 23.5 },
        new PieChartData { X = "Jul", Y = 26 },
        new PieChartData { X = "Aug", Y = 25 },
        new PieChartData { X = "Sep", Y = 21 },
        new PieChartData { X = "Oct", Y = 15 }
    };
    ViewBag.dataSource = chartData;
    return View();
}
public class PieChartData
{
    public string X;
    public double Y;
}