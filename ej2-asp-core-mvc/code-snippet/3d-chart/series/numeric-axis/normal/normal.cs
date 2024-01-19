public ActionResult Index()
{
    List<ChartData> chartData = new List<ChartData>
    {
        new ChartData { x= 1,  y= 7  },
        new ChartData { x= 2,  y= 1  },
        new ChartData { x= 3,  y= 1  },
        new ChartData { x= 4,  y= 14 },
        new ChartData { x= 5,  y= 1  },
        new ChartData { x= 6,  y= 10 },
        new ChartData { x= 7,  y= 8  },
        new ChartData { x= 8,  y= 6  },
        new ChartData { x= 9,  y= 10 },
        new ChartData { x= 10, y= 10 },
        new ChartData { x= 11,  y= 16},
        new ChartData { x= 12, y= 6  },
        new ChartData { x= 13, y= 14 },
        new ChartData { x= 14, y= 7  },
        new ChartData { x= 15, y= 5  },
        new ChartData { x= 16, y= 2  },
        new ChartData { x= 17, y= 14 },
        new ChartData { x= 18, y= 7  },
        new ChartData { x= 19, y= 7  },
        new ChartData { x= 20, y= 10 }
    };
    ViewBag.dataSource = chartData;
    return View();
}
public class ChartData
{
    public double x;
    public double y;
}