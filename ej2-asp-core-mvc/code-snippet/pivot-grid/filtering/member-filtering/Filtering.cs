public ActionResult Index()
{
    var data = GetPivotData();
    ViewBag.data = data;
    ViewBag.filterMembers = new string[] { "United States" };
    return View();
}