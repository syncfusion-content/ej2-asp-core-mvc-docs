public IActionResult Index()
{
    var Order = InventoryDetails.GetAllRecords();
    ViewBag.DataSource = Order;
    ViewBag.dropdownData = new string[] { "Header", "Both" };
    return View();
}