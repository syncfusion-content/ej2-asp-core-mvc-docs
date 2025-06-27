public ActionResult Index()
{
    var data = GetPivotData();
    ViewBag.DataSource = data;
    ViewBag.drilledMembers = new string[] { "Accessories", "Bikes" };
    ViewBag.drilledMembersProducts = new string[] { "Helmets" };
    ViewBag.filterSettings = new string[] { "Cleaners", "Fenders" };
    return View();
}