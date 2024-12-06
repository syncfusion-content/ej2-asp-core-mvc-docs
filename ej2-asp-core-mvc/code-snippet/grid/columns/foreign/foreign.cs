public IActionResult Index()
{
    ViewBag.dataSource = OrderDetails.GetAllRecords();
    ViewBag.foreignData = EmployeeDetails.GetAllRecords();
    return View();
}
