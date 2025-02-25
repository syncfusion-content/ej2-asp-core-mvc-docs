public IActionResult Index()
{
    ViewBag.dataSource = EmployeeDetails.GetAllRecords();
    return View();
}