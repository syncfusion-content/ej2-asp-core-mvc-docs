public ActionResult Index()
{
    var data = GetPivotData();
    ViewBag.DataSource = data;
    ViewBag.drilledMembers = new string[] { "France", "Germany" };
    return View();
}