public ActionResult Index()
{
    var Order = SalesService.GetSalesData();
    ViewBag.DataSource = Order;
    return View();
} 

public class SalesData
{
    public string Product { get; set; }
    public string Month { get; set; }
    public int Online { get; set; }
    public int Retail { get; set; }
    public int Total { get; set; }
}


public class SalesService
{
    public static List<SalesData> GetSalesData()
    {
        return new List<SalesData>
        {
            new SalesData { Product = "Laptop", Month = "January", Online = 1500, Retail = 2000, Total = 3500 },
            new SalesData { Product = "Mobile", Month = "February", Online = 1600, Retail = 2500, Total = 4100 },
            new SalesData { Product = "Tablet", Month = "March", Online = 1800, Retail = 2200, Total = 4000 },
            new SalesData { Product = "Smartwatch", Month = "April", Online = 2000, Retail = 2100, Total = 4100 },
            new SalesData { Product = "Camera", Month = "May", Online = 2200, Retail = 2300, Total = 4500 },
            new SalesData { Product = "Headphones", Month = "June", Online = 1700, Retail = 1800, Total = 3500 },
            new SalesData { Product = "Smart Speaker", Month = "July", Online = 1900, Retail = 2000, Total = 3900 },
            new SalesData { Product = "Printer", Month = "August", Online = 2100, Retail = 1900, Total = 4000 },
            new SalesData { Product = "Monitor", Month = "September", Online = 2000, Retail = 1900, Total = 3900 },
            new SalesData { Product = "Keyboard", Month = "October", Online = 1600, Retail = 1700, Total = 3300 },
            new SalesData { Product = "Mouse", Month = "November", Online = 1700, Retail = 1600, Total = 3300 },
            new SalesData { Product = "Router", Month = "December", Online = 1800, Retail = 2000, Total = 3800 }
        };
    }
}