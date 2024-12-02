public IActionResult Index()
{
    let Emp = EmployeeDetails.GetAllRecords();
    ViewBag.DataSource = Emp;
    return View();
} 