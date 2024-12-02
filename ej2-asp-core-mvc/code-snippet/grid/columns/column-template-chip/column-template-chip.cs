public IActionResult Index()
{
    var Emp = EmployeeDetails.GetAllRecords();
    ViewBag.DataSource = Emp;
    return View();
} 