public IActionResult Index()
{
    var Order = OrderDetails.GetAllRecords();
    ViewBag.DataSource = Order;
    ViewBag.dropdownData = new string[] { "Right","Left", "Center", "Justify"};
    return View();
} 

