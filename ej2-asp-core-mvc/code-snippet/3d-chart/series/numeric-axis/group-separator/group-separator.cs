public ActionResult Index()
{
    List<ChartData> chartData = new List<ChartData>
    {
        new ChartData { x= 10,  y= 7000  },
        new ChartData { x= 20,  y= 1000  },
        new ChartData { x= 30,  y= 12000 },
        new ChartData { x= 40,  y= 14000 },
        new ChartData { x= 50,  y= 11000 },
        new ChartData { x= 60,  y= 5000  },
        new ChartData { x= 70,  y= 7300  },
        new ChartData { x= 80,  y= 9000  },
        new ChartData { x= 90,  y= 12000 },
        new ChartData { x= 100, y= 14000 },
        new ChartData { x= 110, y= 11000 },
        new ChartData { x= 120, y= 5000  }
    };
    ViewBag.dataSource = chartData;
    return View();
}
public class ChartData
{
    public double x;
    public double y;
}