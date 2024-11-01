 public IActionResult Index()
 {
   var orders = OrderDetails.GetAllRecords();
   ViewBag.datasource = orders;
   CustomerData= EmployeeData.GetAllRecords()           
   return View();
 }

      