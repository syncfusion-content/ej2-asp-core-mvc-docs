public IActionResult Index()
{
    ViewBag.DataSource = OrdersDetails.GetAllRecords().ToList();
    return View();
}