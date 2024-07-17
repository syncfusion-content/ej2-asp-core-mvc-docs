public IActionResult Index()
{
    var Order = InventorDetails.GetAllRecords();
    ViewBag.DataSource = Order;
    ViewBag.dropdownData = new string[] { "Clip", "Ellipsis", "EllipsisWithTooltip" };
    return View();
}