public ActionResult Index()
{
    var data = GetGroupData();
    ViewBag.DataSource = data;
    return View();
}
