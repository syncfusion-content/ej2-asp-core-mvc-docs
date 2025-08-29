public IActionResult Index()
{
    var tree = TreeData.GetFormatData();
    ViewBag.data = tree;
    return View();
}