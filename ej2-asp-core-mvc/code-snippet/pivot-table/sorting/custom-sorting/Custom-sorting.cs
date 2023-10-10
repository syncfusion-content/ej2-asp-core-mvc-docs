public ActionResult Index()
{
    var data = GetPivotData();
    ViewBag.DataSource = data;
    ViewBag.membersOrder = new string[] { "United Kingdom", "France" };
    ViewBag.membersOrder_1 = new string[] { "FY 2015","FY 2017" };
    return View();
}
