 public IActionResult Index()
 {
    var orders = OrderDetails.GetAllRecords();
    ViewBag.Datasource = orders;            
    return View();
 }