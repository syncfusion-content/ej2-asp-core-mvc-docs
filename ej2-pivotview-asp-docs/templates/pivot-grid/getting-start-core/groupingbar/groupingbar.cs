public IActionResult Index()
{
    var data = GetPivotData();
    ViewBag.data = data;
    return View();
}