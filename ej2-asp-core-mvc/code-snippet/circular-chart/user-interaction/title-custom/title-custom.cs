public IActionResult Index()
{
    List<CircularChartData> circularData = new List<CircularChartData>
    {
        new CircularChartData { X = "Saudi Arabia",   Y = 58 },
        new CircularChartData { X = "Persian Gulf",   Y = 15 },
        new CircularChartData { X = "Canada",         Y = 13 },
        new CircularChartData { X = "Venezuela",      Y = 8  },
        new CircularChartData { X = "Mexico",         Y = 3  },
        new CircularChartData { X = "Russia",         Y = 2  },
        new CircularChartData { X = "Miscellaneous",  Y = 1  }
    };
    ViewBag.dataSource = circularData;
    return View();
}
public class CircularChartData
{
    public string X;
    public double Y;
}