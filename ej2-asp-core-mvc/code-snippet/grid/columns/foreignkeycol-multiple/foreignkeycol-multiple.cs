public IActionResult Index()
{
    ViewBag.DataSource = OrderDetails.GetAllRecords();
    ViewBag.CustomerData = CustomerDetails.GetAllRecords();
    ViewBag.EmployeeData = EmployeeDetails.GetAllRecords();
    return View();
}