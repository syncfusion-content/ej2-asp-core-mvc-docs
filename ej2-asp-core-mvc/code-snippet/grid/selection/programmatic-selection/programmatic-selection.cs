 public IActionResult Index()
 {
    var orders = InventorDetails.GetAllRecords();
    ViewBag.Datasource = orders;            
    return View();
 }

      