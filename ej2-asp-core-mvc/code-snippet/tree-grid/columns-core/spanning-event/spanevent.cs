public IActionResult Index()
{
    var tree = TreeData.GetSpanData();
    ViewBag.datasource = tree;
    return View();
}