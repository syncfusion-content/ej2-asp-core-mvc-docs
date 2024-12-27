public IActionResult Index()
{
    ViewBag.dataSource = OrdersDetails.GetAllRecords();
    ViewBag.customerDataSource = Customer.GetAllRecords();    
    return View();
} 