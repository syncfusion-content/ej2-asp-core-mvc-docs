public IActionResult Index()
{
    ViewBag.FirstGridData = OrderDetails.GetAllRecords();
    ViewBag.SecondGridData = EmployeeDetails.GetAllRecords();
    return View();
} 