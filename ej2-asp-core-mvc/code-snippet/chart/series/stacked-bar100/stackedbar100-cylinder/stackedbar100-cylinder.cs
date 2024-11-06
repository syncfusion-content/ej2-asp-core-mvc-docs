public ActionResult Index()
{
    List<CylindricalChartData> chartData = new List<CylindricalChartData>
    {
        new CylindricalChartData { x= "2014", y= 111.1, y1= 76.9,  y2= 66.1,  y3= 34.1 },
        new CylindricalChartData { x= "2015", y= 127.3, y1= 99.5,  y2= 79.3,  y3= 38.2 },
        new CylindricalChartData { x= "2016", y= 143.4, y1= 121.7, y2= 91.3,  y3= 44.0 },
        new CylindricalChartData { x= "2017", y= 159.9, y1= 142.5, y2= 102.4, y3= 51.6 },
        new CylindricalChartData { x= "2018", y= 175.4, y1= 166.7, y2= 112.9, y3= 61.9 },
        new CylindricalChartData { x= "2019", y= 189.0, y1= 182.9, y2= 122.4, y3= 71.5 },
        new CylindricalChartData { x= "2020", y= 202.7, y1= 197.3, y2= 120.9, y3= 82.0 }
    };
    ViewBag.dataSource = chartData;
    return View();
}
public class CylindricalChartData
{
    public string x;
    public double y;
    public double y1;
    public double y2;
    public double y3;
}