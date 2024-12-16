public ActionResult Index()
{
    ViewBag.appointments = GetScheduleData();
    var gridData = new List<Order>
    {
        new Order { OrderID = 10248, CustomerID = "VINET", ShipCity = "Reims", ShipName = "Vins et alcools Chevalier", OrderDate = new DateTime(2024, 1, 1) },
        new Order { OrderID = 10249, CustomerID = "TOMSP", ShipCity = "Münster", ShipName = "Toms Spezialitäten", OrderDate = new DateTime(2024, 1, 2) },
        new Order { OrderID = 10250, CustomerID = "HANAR", ShipCity = "Rio de Janeiro", ShipName = "Hanari Carnes", OrderDate = new DateTime(2024, 1, 3) },
        new Order { OrderID = 10251, CustomerID = "VICTE", ShipCity = "Lyon", ShipName = "Victuailles en stock", OrderDate = new DateTime(2024, 1, 4) },
        new Order { OrderID = 10252, CustomerID = "SUPRD", ShipCity = "Charleroi", ShipName = "Suprêmes délices", OrderDate = new DateTime(2024, 1, 5) },
        new Order { OrderID = 10253, CustomerID = "HANAR", ShipCity = "Rio de Janeiro", ShipName = "Hanari Carnes", OrderDate = new DateTime(2024, 1, 6) },
        new Order { OrderID = 10254, CustomerID = "CHOPS", ShipCity = "Bern", ShipName = "Chop-suey Chinese", OrderDate = new DateTime(2024, 1, 7) }
    };

    ViewBag.gridData = gridData;
    return View();
}

public List<AppointmentData> GetScheduleData()
{
    List<AppointmentData> appData = new List<AppointmentData>();
    appData.Add(new AppointmentData
    {
        Id = 2,
        Subject = "Meeting",
        StartTime = new DateTime(2024, 2, 15, 10, 0, 0),
        EndTime = new DateTime(2024, 2, 15, 12, 30, 0),
        IsAllDay = false,
        Status = "Completed",
        Priority = "High"
    });
    return appData;
}

public class AppointmentData
{
    public int Id { get; set; }
    public string Subject { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public bool IsAllDay { get; set; }
    public string Status { get; set; }
    public string Priority { get; set; }
}

public class Order
{
    public int OrderID { get; set; }
    public string CustomerID { get; set; }
    public string ShipCity { get; set; }
    public string ShipName { get; set; }
    public DateTime OrderDate { get; set; }
}