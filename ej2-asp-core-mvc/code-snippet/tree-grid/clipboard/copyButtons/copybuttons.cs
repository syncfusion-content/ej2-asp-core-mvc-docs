public IActionResult Index()
{
    var treeData = TreeGridItems.GetTreeData();
    ViewBag.datasource = treeData;
    return View();
}