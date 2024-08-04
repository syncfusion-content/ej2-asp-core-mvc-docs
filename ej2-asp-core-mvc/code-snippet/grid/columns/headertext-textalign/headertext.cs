public IActionResult Index()
{
  var orders = OrdersDetails.GetAllRecords();
  ViewBag.DataSource = orders;
  ViewBag.dropdownData = new string[] { "Left", "Right", "Center", "Justify"};
  return View();
}