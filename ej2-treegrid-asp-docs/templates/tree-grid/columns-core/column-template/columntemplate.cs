public IActionResult Index()
{
    var tree = TreeData.GetTemplateData();
    ViewBag.dataSource = tree;
    return View();
}