public IActionResult Index()
{
    ViewBag.FirstTreeGridData = TreeGridItems.GetTreeData();
    ViewBag.SecondTreeGridData = TreeGridItems.GetData();
    return View();
} 