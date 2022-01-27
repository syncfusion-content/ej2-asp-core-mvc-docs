 public IActionResult Index()
 {
    var orders = OrdersDetails.GetAllRecords();
    ViewBag.DataSource = orders;            
    return View();
  }

       