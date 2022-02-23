public IActionResult Index()
{
    ViewBag.DataSource = GanttData.ProjectNewData();
    ViewBag.dropdata = new List<object>() {
               new { id= "Default", view= "Default" },
               new { id= "Grid", view= "Grid" },
               new { id= "Chart", view= "Chart" }
            };
    return View();
}