 public IActionResult Index()
 {
    ViewBag.datasource = OrdersDetails.GetAllRecords();            
    return View();
 }