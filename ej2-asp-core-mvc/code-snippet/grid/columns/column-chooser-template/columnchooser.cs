public IActionResult Index()
{
    ViewBag.StackedHeaderData = OrdersDetails.GetAllRecords();
    return View();
} 