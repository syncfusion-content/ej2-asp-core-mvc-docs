public ActionResult Index()
{
    ViewBag.headerTextOne = new TabHeader { Text = "USA" };
    ViewBag.headerTextTwo = new TabHeader { Text = "France" };
    ViewBag.headerTextThree = new TabHeader { Text = "Australia" };
    return View();
}