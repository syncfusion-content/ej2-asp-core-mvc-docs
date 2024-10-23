public ActionResult Index()
        {
            List<ErrorBarData> chartData = new List<ErrorBarData>
            {
                new ErrorBarData{ x= 2005, y= 28, color = "red", error = 4 },
                new ErrorBarData{ x= 2006, y= 25, color = "blue", error = 3 },
                new ErrorBarData{ x= 2007, y= 26, color = "green", error = 2 },
                new ErrorBarData{ x= 2008, y= 27, color = "orange", error = 1 },
                new ErrorBarData{ x= 2009, y= 32, color = "yellow", error = 3 },
                new ErrorBarData{ x= 2010, y= 35, color = "grey", error = 2 },
                new ErrorBarData{ x= 2011, y= 30, color = "aqua", error = 1 }
            };
            ViewBag.dataSource = chartData;
            return View();
        }
public class ErrorBarData
{
    public double x;
    public double y;
    public string color;
    public double error;
}