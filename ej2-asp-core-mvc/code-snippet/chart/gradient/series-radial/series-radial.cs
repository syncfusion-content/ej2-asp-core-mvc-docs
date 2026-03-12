public ActionResult Index()
{
    List<SalesData> chartData = new List<SalesData>
    {
        new SalesData { Month = "Jan", Amount = 78  },
        new SalesData { Month = "Feb", Amount = 88  },
        new SalesData { Month = "Mar", Amount = 99  },
        new SalesData { Month = "Apr", Amount = 92  },
        new SalesData { Month = "May", Amount = 95  },
        new SalesData { Month = "Jun", Amount = 102 },
        new SalesData { Month = "Jul", Amount = 110 },
        new SalesData { Month = "Aug", Amount = 105 }
    };
    ViewBag.dataSource = chartData;
    return View();
}

public class SalesData
{
    public string Month  { get; set; }
    public double Amount { get; set; }
}