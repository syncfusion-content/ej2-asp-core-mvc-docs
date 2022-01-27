public IActionResult Index()
{
    ViewBag.DataSource = OrderDetails.GetAllRecords();
    ViewBag.DropDownData = DropDownDetails.GetAllRecords();
    return View();
} 