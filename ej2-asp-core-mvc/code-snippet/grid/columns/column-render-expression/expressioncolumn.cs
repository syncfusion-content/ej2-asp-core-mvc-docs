public IActionResult Index()
{
    var Order = FoodDetails.GetAllRecords();
    ViewBag.DataSource = Order;
    return View();
} 