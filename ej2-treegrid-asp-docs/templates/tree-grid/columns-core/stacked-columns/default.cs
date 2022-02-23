public IActionResult Index()
{
    var tree = TreeData.GetStackedData();
    ViewBag.data = tree;
    return View();
}