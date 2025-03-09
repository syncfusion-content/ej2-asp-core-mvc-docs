public IActionResult Index()
{
    ViewBag.dataSource = OrderDetails.GetAllRecords();
    return View();
} 