public IActionResult Index()
{
    ViewBag.DataSource = OrdersDetails.GetAllRecords();
    ViewBag.EmployeeData =Employees.GetAllRecords();
    return View();
} 