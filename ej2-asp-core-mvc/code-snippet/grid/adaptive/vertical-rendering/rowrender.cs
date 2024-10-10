public IActionResult Index()
{
    ViewBag.AdaptiveDataSource = AdaptiveDetails.GetAllRecords();
    ViewBag.dropdownData = new string[] { "Horizontal", "Vertical" };
    return View();
} 