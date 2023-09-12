public static List<ExpandoObject> ExpandoOrders { get; set; } = new List<ExpandoObject>();

public IActionResult Index()
{
    ExpandoOrders = Enumerable.Range(1, 75).Select((x) =>
    {
        dynamic d = new ExpandoObject();
        d.OrderID = 1000 + x;
        d.Customer = new ExpandoObject();
        d.Customer.Freight = (new double[] { 2, 1, 4, 5, 3 })[new Random().Next(5)] * x;
        d.Customer.OrderDate = (new DateTime[] { new DateTime(2010, 11, 5), new DateTime(2018, 10, 3), new DateTime(1995, 9, 9), new DateTime(2012, 8, 2), new DateTime(2015, 4, 11) })[new Random().Next(5)];
        d.Customer.ShipCountry = (new string[] { "USA", "UK", "Denmark", "Australia", "india" })[new Random().Next(5)];
        d.Freight = (new double[] { 2, 1, 4, 5, 3 })[new Random().Next(5)] * x;
        d.OrderDate = (new DateTime[] { new DateTime(2010, 11, 5), new DateTime(2018, 10, 3), new DateTime(1995, 9, 9), new DateTime(2012, 8, 2), new DateTime(2015, 4, 11) })[new Random().Next(5)];
        d.ShipCountry = (new string[] { "USA", "UK" })[new Random().Next(2)];
        d.Verified = (new bool[] { true, false })[new Random().Next(2)];
        return d;
    }).Cast<ExpandoObject>().ToList<ExpandoObject>();
    ViewBag.ExpandoData = ExpandoOrders;
    return View();
}