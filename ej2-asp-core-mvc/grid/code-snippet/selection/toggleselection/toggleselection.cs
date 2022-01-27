 public IActionResult Index()
 {
   var orders = OrderDetails.GetAllRecords();
   ViewBag.datasource = orders;            
   return View();
 }

      