public IActionResult Index()
{
  ViewBag.dataSource = OrderDetails.GetAllRecords();
  ViewBag.customerData= EmployeeData.GetAllRecords()           
  return View();
}

      