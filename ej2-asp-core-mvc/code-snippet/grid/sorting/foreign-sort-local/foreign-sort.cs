 public IActionResult Index()
 {
   var orders = OrderDetails.GetAllRecords();
   ViewBag.datasource = orders;
   customerData= EmployeeData.GetAllRecords()           
   return View();
 }

      