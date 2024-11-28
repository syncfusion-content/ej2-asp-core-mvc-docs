public IActionResult Index()
{
    var Order = StudentDetails.GetAllRecords();
    ViewBag.DataSource = Order;
    return View();
} 