public IActionResult Index()
{
    ViewBag.DataSource =  OrdersDetails.GetAllRecords();;
    ViewBag.EmpDataSource = EmployeeView.GetAllRecords();
    ViewBag.CustomerDataSource = Customer.GetAllRecords();
    ViewBag.dropdownData = new string[] { "Expanded", "All", "None" };

    return View();
} 