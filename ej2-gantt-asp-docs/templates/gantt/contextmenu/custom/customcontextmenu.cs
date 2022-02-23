public IActionResult Index()
{
    ViewBag.DataSource = GanttData.EditingData();	
    return View();
}