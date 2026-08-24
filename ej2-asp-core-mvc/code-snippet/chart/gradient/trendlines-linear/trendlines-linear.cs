public ActionResult Index()
{
    List<OrdersData> chartData = new List<OrdersData>
    {
        new OrdersData { Month = "Jan", Orders = 24 },
        new OrdersData { Month = "Feb", Orders = 30 },
        new OrdersData { Month = "Mar", Orders = 27 },
        new OrdersData { Month = "Apr", Orders = 34 },
        new OrdersData { Month = "May", Orders = 41 },
        new OrdersData { Month = "Jun", Orders = 37 },
        new OrdersData { Month = "Jul", Orders = 49 },
        new OrdersData { Month = "Aug", Orders = 45 },
        new OrdersData { Month = "Sep", Orders = 39 },
        new OrdersData { Month = "Oct", Orders = 46 },
        new OrdersData { Month = "Nov", Orders = 54 },
        new OrdersData { Month = "Dec", Orders = 52 }
    };
    ViewBag.dataSource = chartData;
    return View();
}

public class OrdersData
{
    public string Month { get; set; }
    public double Orders { get; set; }
}