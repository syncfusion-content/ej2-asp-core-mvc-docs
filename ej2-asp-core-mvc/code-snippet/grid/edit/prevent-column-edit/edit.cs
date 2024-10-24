 public IActionResult Index()
 {
    ViewBag.datasource = OrderDetails.GetAllRecords();
    ViewBag.dropdownData = new string[] { "OrderID", "CustomerID", "Freight", "OrderDate", "ShipCountry" };  
    return View();
 }

      