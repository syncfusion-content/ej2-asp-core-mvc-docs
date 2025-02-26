public ActionResult Index()
{
    ViewBag.employeeData = EmployeeDetails.GetAllRecords();
    ViewBag.employeePerformanceData = EmployeePerformanceDetails.GetAllRecords();
    return View();
} 