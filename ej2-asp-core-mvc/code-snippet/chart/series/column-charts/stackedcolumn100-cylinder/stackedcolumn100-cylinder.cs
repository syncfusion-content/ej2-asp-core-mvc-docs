public ActionResult Index()
{
    List<CylindricalChartData> chartData = new List<CylindricalChartData>
    {
        new CylindricalChartData { x: new DateTime(2006, 01, 01), y: 900, y1: 190, y2: 250, y3: 150 },
        new CylindricalChartData { x: new DateTime(2007, 01, 01), y: 544, y1: 226, y2: 145, y3: 120 }, 
        new CylindricalChartData { x: new DateTime(2008, 01, 01), y: 880, y1: 194, y2: 190, y3: 115 },
        new CylindricalChartData { x: new DateTime(2009, 01, 01), y: 675, y1: 250, y2: 220, y3: 125 }, 
        new CylindricalChartData { x: new DateTime(2010, 01, 01), y: 765, y1: 222, y2: 225, y3: 132 },
        new CylindricalChartData { x: new DateTime(2011, 01, 01), y: 679, y1: 181, y2: 135, y3: 137 },
        new CylindricalChartData { x: new DateTime(2012, 01, 01), y: 770, y1: 128, y2: 152, y3: 110 }
    };
    ViewBag.dataSource = chartData;
    return View();
}
public class CylindricalChartData
{
    public DateTime x;
    public double y;
    public double y1;
    public double y2;
    public double y3;
}