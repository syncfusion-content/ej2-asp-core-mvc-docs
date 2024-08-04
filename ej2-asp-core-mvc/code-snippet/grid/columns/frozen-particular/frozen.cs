public IActionResult DefaultExporting()
{
    var order = OrdersDetails.GetAllRecords();
     ViewBag.dropdownData = new string[] { "OrderID", "CustomerID", "EmployeeID", "Freight", "OrderDate", "ShipCountry", "ShipCity", "ShipAddress", "ShipName" };
    ViewBag.dataSource = order;
    return View();
}
