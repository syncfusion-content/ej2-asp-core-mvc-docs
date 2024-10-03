 public IActionResult Index()
 {
   var orders = OrdersDetails.GetAllRecords();
   ViewBag.datasource = orders;       
  ViewBag.dropdownData = new string[] { "startswith", "endswith","wildcard","like","equal","notequal"  };
     
   return View();
 }

    