public ActionResult Index()
{
    var data = getCSVData();
    ViewBag.DataSource = data;
    return View();
}