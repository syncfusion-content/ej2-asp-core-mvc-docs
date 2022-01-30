public IActionResult Index()
{
    ViewBag.DataSource = OrderDetails.GetAllRecords();
    ViewBag.ForeignData = EmployeeDetails.GetAllRecords();
    return View();
} 