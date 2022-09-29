public IActionResult Index()
{
    ViewBag.DataSource = EmployeeDetails.GetAllRecords();
    return View();
}