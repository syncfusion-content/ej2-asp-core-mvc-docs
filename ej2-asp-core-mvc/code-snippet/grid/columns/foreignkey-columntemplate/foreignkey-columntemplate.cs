public IActionResult Index()
{
    ViewBag.dataSource = OrdersDetails.GetAllRecords();
    ViewBag.foreignData = EmployeeDetails.GetAllRecords();
    return View();
}
