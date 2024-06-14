public ActionResult Demo()
{
    var orders = new List<Order>
    {
        new Order { OrderID = 10248, CustomerID = "VINET", OrderDate = new DateTime(1996, 7, 4), Freight = 32.38m },
        new Order { OrderID = 10249, CustomerID = "TOMSP", OrderDate = new DateTime(1996, 7, 5), Freight = 11.61m },
        new Order { OrderID = 10250, CustomerID = "HANAR", OrderDate = new DateTime(1996, 7, 8), Freight = 65.83m },
        new Order { OrderID = 10251, CustomerID = "VICTE", OrderDate = new DateTime(1996, 7, 8), Freight = 41.34m },
        new Order { OrderID = 10252, CustomerID = "SUPRD", OrderDate = new DateTime(1996, 7, 9), Freight = 51.3m },
        new Order { OrderID = 10253, CustomerID = "HANAR", OrderDate = new DateTime(1996, 7, 10), Freight = 58.17m },
        new Order { OrderID = 10254, CustomerID = "CHOPS", OrderDate = new DateTime(1996, 7, 11), Freight = 22.98m },
        new Order { OrderID = 10255, CustomerID = "RICSU", OrderDate = new DateTime(1996, 7, 12), Freight = 148.33m },
        new Order { OrderID = 10256, CustomerID = "WELLI", OrderDate = new DateTime(1996, 7, 15), Freight = 13.97m }
    };

    ViewBag.OrderData = orders;
    return View(ViewBag.OrderData);
}

public class Order
{
    public int OrderID { get; set; }
    public string CustomerID { get; set; }
    public DateTime OrderDate { get; set; }
    public decimal Freight { get; set; }
}