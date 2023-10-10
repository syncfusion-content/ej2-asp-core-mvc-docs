public ActionResult Index()
{
    var data = GetPivotData();
    ViewBag.DataSource = data;
    ViewBag.Excludefields = new string[] { "Amount" };
    return View();
}
