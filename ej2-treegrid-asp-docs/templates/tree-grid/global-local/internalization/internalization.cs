public IActionResult Index()
{
    var tree = TreeDataFormat.GetDataFormat();
    ViewBag.datasource = tree;
    return View();
}