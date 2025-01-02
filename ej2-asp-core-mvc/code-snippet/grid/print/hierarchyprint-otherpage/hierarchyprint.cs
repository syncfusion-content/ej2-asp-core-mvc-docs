public IActionResult Index()
{
    ViewBag.DataSource =  OrdersDetails.GetAllRecords();;
    ViewBag.EmployeeDataSource = EmployeeView.GetAllRecords();
    ViewBag.CustomerDataSource = Customer.GetAllRecords();
    return View();
} 