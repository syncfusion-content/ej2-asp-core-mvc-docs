public IActionResult Index()
{
    var Order = Product.GetAllRecords();
    ViewBag.DataSource = Order;
    return View();
} 