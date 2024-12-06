public IActionResult Index()
{
    ViewBag.dataSource = OrderDetails.GetAllRecords();
    ViewBag.customerData = CustomerDetails.GetAllRecords();
    ViewBag.employeeData = EmployeeDetails.GetAllRecords();
    return View();
}