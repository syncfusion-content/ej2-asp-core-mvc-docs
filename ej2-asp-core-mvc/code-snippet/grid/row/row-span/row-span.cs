public IActionResult Index()
{
    ViewBag.DataSource = ColumnSpanData.GetAllRecords()
    return View();
} 