public IActionResult Index()
{
    var Order = InventoryDetails.GetAllRecords();
    ViewBag.DataSource = Order;
    ViewBag.dropdownData = new string[] { "Default", "Both", "Horizontal", "Vertical", "None" };
    return View();
}