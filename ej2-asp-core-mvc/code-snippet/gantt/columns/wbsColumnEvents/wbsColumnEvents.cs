public IActionResult Index()
{
    ViewBag.DataSource = GanttData.WBSData();
    return View();
}