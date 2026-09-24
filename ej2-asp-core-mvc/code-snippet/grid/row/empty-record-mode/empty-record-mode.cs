public IActionResult Index()
{
    ViewBag.DataSource = new List<object>();
    ViewBag.dropdownData = new string[] { "Sticky", "Normal" };
    return View();
}