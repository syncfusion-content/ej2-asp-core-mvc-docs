public IActionResult Index()
{
    ViewBag.DataSource = telecastData.GetAllRecords()
    return View();
} 