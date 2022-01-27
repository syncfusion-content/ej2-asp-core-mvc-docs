 public IActionResult Index()
 {
   var orders = OrdersDetails.GetAllRecords();
   ViewBag.datasource = orders;            
   return View();
 }

       