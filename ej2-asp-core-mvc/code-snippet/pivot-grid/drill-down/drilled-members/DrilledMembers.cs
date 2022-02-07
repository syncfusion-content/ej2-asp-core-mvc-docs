public ActionResult Index()
{
    var data = GetPivotData();
    ViewBag.data = data;
    ViewBag.drilledMembers = new string[] { "France" };
    return View();
}