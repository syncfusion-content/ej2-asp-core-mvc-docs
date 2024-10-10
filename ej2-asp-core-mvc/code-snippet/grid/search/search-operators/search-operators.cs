 public IActionResult Index()
 {
   var orders = OrdersDetails.GetAllRecords();
   ViewBag.datasource = orders;       
  ViewBag.dropdownData = new string[] { "contains", "startswith", "endswith","wildcard","like","equal","notequal"  };
     
   return View();
 }

    