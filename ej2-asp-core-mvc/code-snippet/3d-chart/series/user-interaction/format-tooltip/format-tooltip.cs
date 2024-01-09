public ActionResult Index()
{
    List<ChartData> chartData = new List<ChartData>
    {
        new ChartData { month= "Jan", sales= 35 },
        new ChartData { month= "Feb", sales= 28 },
        new ChartData { month= "Mar", sales= 34 },
        new ChartData { month= "Apr", sales= 32 },
        new ChartData { month= "May", sales= 40 },
        new ChartData { month= "Jun", sales= 32 },
        new ChartData { month= "Jul", sales= 35 },
        new ChartData { month= "Aug", sales= 55 },
        new ChartData { month= "Sep", sales= 38 },
        new ChartData { month= "Oct", sales= 30 },
        new ChartData { month= "Nov", sales= 25 },
        new ChartData { month= "Dec", sales= 32 }
    };
    ViewBag.dataSource = chartData;
    return View();
}
public class ChartData
{
    public string month;
    public double sales;
}