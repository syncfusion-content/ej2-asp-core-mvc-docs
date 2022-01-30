public class HomeController : Controller
{
    public static List<Orders> order = new List<Orders>();
    
    public ActionResult Index()
    {
        if (order.Count == 0)
            BindDataSource();
        ViewBag.data = order.ToArray();
        return View();
    }

    public void BindDataSource()
    {
        int code = 10000;
        for (int i = 1; i < 10; i++)
        {
            order.Add(new Orders(code + 1, "VINET", i + 0, 2.3 * i, new DateTime(1991, 05, 15), "Berlin"));
            order.Add(new Orders(code + 2, "ANATR", i + 2, 3.3 * i, new DateTime(1990, 04, 04), "Madrid"));
            order.Add(new Orders(code + 3, "ANTON", i + 1, 4.3 * i, new DateTime(1957, 11, 30), "Cholchester"));
            order.Add(new Orders(code + 4, "BLONP", i + 3, 5.3 * i, new DateTime(1930, 10, 22), "Marseille"));
            order.Add(new Orders(code + 5, "BOLID", i + 4, 6.3 * i, new DateTime(1953, 02, 18), "Tsawassen"));
            code += 5;
        }
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Update(Orders value, string action)
    {
        var data = order.Where(or => or.OrderID == value.OrderID).FirstOrDefault();
        if (data != null)
        {
            data.OrderID = value.OrderID;
            data.CustomerID = value.CustomerID;
            data.EmployeeID = value.EmployeeID;
            data.Freight = value.Freight;
            data.OrderDate = value.OrderDate;
            data.ShipCity = value.ShipCity;
        }
        return Json(value);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Insert(Orders value, string action)
    {
        order.Insert(0, value);
        return Json(value);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public void Remove(int key)
    {
        var data = order.Where(or => or.OrderID == key).FirstOrDefault();
        if (data != null)
        {
            order.Remove(data);
        }
    }

    public class Orders
    {
        public Orders()
        {

        }
        public Orders(long OrderId, string CustomerId, int EmployeeId, double Freight, DateTime OrderDate, string ShipCity)
        {
            this.OrderID = OrderId;
            this.CustomerID = CustomerId;
            this.EmployeeID = EmployeeId;
            this.Freight = Freight;
            this.OrderDate = OrderDate;
            this.ShipCity = ShipCity;
        }
        public long OrderID { get; set; }
        public string CustomerID { get; set; }
        public int EmployeeID { get; set; }
        public double Freight { get; set; }
        public DateTime OrderDate { get; set; }
        public string ShipCity { get; set; }
    }
}
