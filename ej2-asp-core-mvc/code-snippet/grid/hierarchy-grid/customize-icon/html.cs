public IActionResult Index()
{
    ViewBag.DataSource =  OrderDetails.GetAllRecords();
    ViewBag.EmployeeDataSource =  EmployeeDetails.GetAllRecords();
    return View();
} 