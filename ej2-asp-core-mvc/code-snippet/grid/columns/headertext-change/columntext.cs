public IActionResult Index()
{
  var orders = OrdersDetails.GetAllRecords();
  ViewBag.DataSource = orders;
  ViewBag.dropdownData = new string[] { "OrderID", "CustomerID", "Freight", "OrderDate","ShipCountry" };
  return View();
}