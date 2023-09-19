public ActionResult Index()
{
    List<CylindricalChartData> chartData = new List<CylindricalChartData>
    {
        new CylindricalChartData { country= "USA",       gold= 50 },
        new CylindricalChartData { country= "Japan",     gold= 70 }, 
        new CylindricalChartData { country= "Australia", gold= 60 },
        new CylindricalChartData { country= "France",    gold= 50 }, 
        new CylindricalChartData { country= "Italy",     gold= 40 },
        new CylindricalChartData { country= "Sweden",    gold= 55 }
    };
    ViewBag.dataSource = chartData;
    return View();
}
public class CylindricalChartData
{
    public string country;
    public double gold;
}