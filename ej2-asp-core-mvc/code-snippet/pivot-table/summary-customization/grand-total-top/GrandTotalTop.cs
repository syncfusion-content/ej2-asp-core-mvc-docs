public ActionResult Index()
{
    var data = GetPivotData();
    ViewBag.DataSource = data;
    return View();
}