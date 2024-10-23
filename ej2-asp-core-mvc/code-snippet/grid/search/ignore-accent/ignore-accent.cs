 public IActionResult Index()
 {
   var orders = ProductDetails.GetAllRecords();
   ViewBag.datasource = orders;            
   return View();
 }

    