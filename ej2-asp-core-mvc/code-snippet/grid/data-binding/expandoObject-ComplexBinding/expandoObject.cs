public static List<ExpandoObject> ExpandoOrders { get; set; } = new List<ExpandoObject>();
public ActionResult Index()
{
    string[] customerID = { "John Doe", "Jane Smith", "Alice Johnson", "Bob Brown", "Charlie Davis" };
    string[] shipCountrys = { "USA", "UK", "Denmark", "Australia", "India" };

    ExpandoOrders = Enumerable.Range(1, 75).Select((x) =>
    {
        dynamic order = new ExpandoObject();
       order.OrderID = 1000 + x;
       order.Customer = new ExpandoObject();
       order.Customer.CustomerID = customerID[x % customerID.Length];
       order.Customer.Freight = (new double[] { 2, 1, 4, 5, 3 })[new Random().Next(5)] * x;
       order.Customer.OrderDate = (new DateTime[] { new DateTime(2010, 11, 5), new DateTime(2018, 10, 3), new DateTime(1995, 9, 9), new DateTime(2012, 8, 2), new DateTime(2015, 4, 11) })[new Random().Next(5)];
       order.Customer.ShipCountry = shipCountrys[x % shipCountrys.Length];;
        return order;
    }).Cast<ExpandoObject>().ToList<ExpandoObject>();
    ViewBag.ExpandoData = ExpandoOrders;
    return View();
}