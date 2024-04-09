public ActionResult Index()
{
    List<ChartData> chartData = new List<ChartData>
    {
        new ChartData { x= "Czechia",      y= 1.11 },
        new ChartData { x= "Spain",        y= 1.66 },
        new ChartData { x= "USA",          y= 1.56 },
        new ChartData { x= "Germany",      y= 3.1  },
        new ChartData { x= "Russia",       y= 1.35 },
        new ChartData { x= "Slovakia",     y= 1    },
        new ChartData { x= "South Korea",  y= 3.16 },
        new ChartData { x= "France",       y= 0.92 }
    };
    ViewBag.dataSource = chartData;
    return View();
}
public class ChartData
{
    public string x;
    public double y;
}