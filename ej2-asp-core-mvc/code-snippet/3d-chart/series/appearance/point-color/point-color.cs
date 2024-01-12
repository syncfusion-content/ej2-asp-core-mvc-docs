public ActionResult Index()
{
    List<ChartData> chartData = new List<ChartData>
    {
        new ChartData { x= "Jan", y= 6.96, color= "#ed4c40" },
        new ChartData { x= "Feb", y= 8.9,  color= "#3285f3" },
        new ChartData { x= "Mar", y= 12,   color= "#1dd7f3" },
        new ChartData { x= "Apr", y= 17.5, color= "#fe1684" },
        new ChartData { x= "May", y= 22.1, color= "#4633f2" }
    };
    ViewBag.dataSource = chartData;
    return View();
}
public class ChartData
{
    public string x;
    public double y;
    public string color;
}