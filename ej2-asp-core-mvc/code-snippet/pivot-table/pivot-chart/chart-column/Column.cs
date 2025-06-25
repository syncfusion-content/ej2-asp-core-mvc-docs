public ActionResult Index()
{
    var data = GetPivotData();
    ViewBag.DataSource = data;
    ViewBag.drilledMembers = new string[] { "FY 2015", "FY 2016" };
    return View();
}