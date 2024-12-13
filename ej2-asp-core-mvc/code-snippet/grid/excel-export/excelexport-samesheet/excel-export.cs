public IActionResult Index()
{
    ViewBag.firstGridData = OrderDetails.GetAllRecords();
    ViewBag.secondGridData = EmployeeDetails.GetAllRecords();
    return View();
}