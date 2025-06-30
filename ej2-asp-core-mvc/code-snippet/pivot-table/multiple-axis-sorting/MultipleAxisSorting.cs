public ActionResult Index()
{
    var data = GetPivotData();
    ViewBag.Data = data;
    return View();
}