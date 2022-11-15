public IActionResult Index()
{
    ViewBag.DataSource = OrderDetails.GetAllRecords();
    return View();
}