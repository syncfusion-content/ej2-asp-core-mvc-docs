 public IActionResult Index()
 {
    var orders = InventorDetails.GetAllRecords();
    ViewBag.datasource = orders;            
    return View();
 }
