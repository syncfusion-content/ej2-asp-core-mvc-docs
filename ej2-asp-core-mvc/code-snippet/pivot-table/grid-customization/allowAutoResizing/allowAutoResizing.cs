public ActionResult Index()
{
    var data = GetPivotData();
    ViewBag.DataSource = data;
    ViewBag.filterMembers = new string[] { "FY 2017", "FY 2015" };
    return View();
}
