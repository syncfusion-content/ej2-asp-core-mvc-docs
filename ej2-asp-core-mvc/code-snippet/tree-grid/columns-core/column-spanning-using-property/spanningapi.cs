public IActionResult Index()
{
    var tree = TreeData.GetDefaultData();
    ViewBag.data = tree;
    return View();
}