public ActionResult Index()
{
    var data = GetPivotData();
    ViewBag.data = data;
    return View();
}
