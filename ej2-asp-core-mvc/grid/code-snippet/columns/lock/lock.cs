public IActionResult Index()
{
    var order = OrderDetails.GetAllRecords();
    ViewBag.DataSource = order;
    return View();
} 