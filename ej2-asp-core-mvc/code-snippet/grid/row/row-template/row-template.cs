public IActionResult Index()
{
    ViewBag.EmployeeDataSource = EmployeeDetails.GetAllRecords();
    return View();
} 