public IActionResult Index()
{
    var tree = TreeGridItems.GetTreeData();
    ViewBag.datasource = tree;
    return View();
}