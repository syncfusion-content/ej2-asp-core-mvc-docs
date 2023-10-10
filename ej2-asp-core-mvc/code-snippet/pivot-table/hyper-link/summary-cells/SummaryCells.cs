public ActionResult Index()
{
    var data = GetPivotData();
    ViewBag.DataSource = data;
    ViewBag.yearMembers = new string[] { "FY 2015" };
    ViewBag.countryMembers = new string[] { "France" };
    return View();
}
