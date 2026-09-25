public IActionResult Index()
{
    ViewBag.DataSource = GroceryData.GetRecords();
    return View();
}