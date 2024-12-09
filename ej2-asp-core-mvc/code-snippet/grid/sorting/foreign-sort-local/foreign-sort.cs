 public IActionResult Index()
 {
   var orders = OrderDetails.GetAllRecords();
   ViewBag.dataSource = orders;
   customerData= EmployeeData.GetAllRecords()           
   return View();
 }

      