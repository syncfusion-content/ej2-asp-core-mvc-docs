public ActionResult Index()
{
    List<ChartData> chartData = new List<ChartData>
    {
        new ChartData { x= "Jan", y= 12, text= "January : 12°C" },
        new ChartData { x= "Feb", y= 8,  text= "February : 8°C" },
        new ChartData { x= "Mar", y= 11, text= "March : 11°C"   },
        new ChartData { x= "Apr", y= 6,  text= "April : 6°C"    }
    };
    ViewBag.dataSource = chartData;
    return View();
}
public class ChartData
{
    public string x;
    public double y;
    public string text;
}