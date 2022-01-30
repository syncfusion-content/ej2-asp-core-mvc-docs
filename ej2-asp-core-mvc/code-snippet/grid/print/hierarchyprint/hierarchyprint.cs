public IActionResult Index()
{
    ViewBag.DataSource =  OrdersDetails.GetAllRecords();;
    ViewBag.EmpDataSource = EmployeeView.GetAllRecords();
    ViewBag.CustomerDataSource = Customer.GetAllRecords();
    return View();
} 