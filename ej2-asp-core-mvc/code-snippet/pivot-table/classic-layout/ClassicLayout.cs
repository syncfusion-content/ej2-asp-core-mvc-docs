public ActionResult Index()
{
    var data = GetPivotData();
    ViewBag.DataSource = data;
    ViewBag.drilledMembers = new string[] { "Accessories", "Bikes" };
    ViewBag.filterSettings = new string[] { "Cleaners", "Fenders" };
    return View();
}