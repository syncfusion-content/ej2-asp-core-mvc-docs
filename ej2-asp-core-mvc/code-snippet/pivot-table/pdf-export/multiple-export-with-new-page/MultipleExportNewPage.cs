public ActionResult Index()
{
    var data = GetPivotData();
    ViewBag.DataSource = data;
    ViewBag.filterMembers = new string[] { "FY 2015" };
    ViewBag.countryFilterMembers = new string[] { "France" };
    return View();
}