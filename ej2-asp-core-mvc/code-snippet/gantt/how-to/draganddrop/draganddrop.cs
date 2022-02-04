public IActionResult Index()
{
    ViewBag.DataSource = GanttData.ProjectNewData();
    ViewBag.projectResources = projectResources();
    return View();
}