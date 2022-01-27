public IActionResult Index()
{
    ViewBag.DataSource = Merge.GetAllRecords()
    return View();
} 