public IActionResult Index()
{
    ViewBag.AdaptiveDataSource = AdaptiveDetails.GetAllRecords();
    return View();
} 