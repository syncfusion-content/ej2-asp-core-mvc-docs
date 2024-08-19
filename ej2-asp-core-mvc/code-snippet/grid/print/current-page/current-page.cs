public IActionResult Index()
{
    ViewBag.DataSource = OrdersDetails.GetAllRecords();
    ViewBag.dropdownData = new string[] { "AllPages", "CurrentPage" };

    return View();
} 