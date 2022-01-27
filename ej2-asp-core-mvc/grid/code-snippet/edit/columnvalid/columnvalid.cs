 public IActionResult Index()
 {
   var orders = OrderDetails.GetAllRecords();
   ViewBag.DataSource = orders;            
   return View();
 }

       