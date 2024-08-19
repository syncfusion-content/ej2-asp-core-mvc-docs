public IActionResult DefaultExporting()
{
    var order = OrdersDetails.GetAllRecords();
    ViewBag.dataSource = order;
    ViewBag.dropdownData = new string[] { "OrderID", "CustomerID", "Freight", "OrderDate", "ShipCountry", "ShipCity", "ShipAddress", "ShipName" };
    ViewBag.directionData = new string[] {"Left","Right","Fixed" };

    return View();
}
