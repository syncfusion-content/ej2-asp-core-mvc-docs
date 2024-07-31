public IActionResult Index()
{
  var orders = OrdersDetails.GetAllRecords();
  ViewBag.datasource = orders;
  ViewBag.dropdownData = new string[] { "Left", "Right", "Center", "Justify"};
  return View();
}