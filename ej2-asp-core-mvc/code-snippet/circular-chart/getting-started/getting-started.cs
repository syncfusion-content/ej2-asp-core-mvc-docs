public IActionResult Index()
{
    List<CircularChartData> circularData = new List<CircularChartData>
    {
        new CircularChartData { X = "Chrome",            Y = 62.92 },
        new CircularChartData { X = "Internet Explorer", Y = 6.12  },
        new CircularChartData { X = "Opera",             Y = 3.15  },
        new CircularChartData { X = "Edge",              Y = 5.5   },
        new CircularChartData { X = "Safari",            Y = 19.97 },
        new CircularChartData { X = "Others",            Y = 2.34  }
    };
    ViewBag.dataSource = circularData;
    return View();
}
public class CircularChartData
{
    public string X;
    public double Y;
}